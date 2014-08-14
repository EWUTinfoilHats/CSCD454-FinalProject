using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.UI;
using CSCD454_FinalProject.Entitys;
using CSCD454_FinalProject.Factories;
using CSCD454_FinalProject.Maze;
using CSCD454_FinalProject.Items;


namespace CSCD454_FinalProject
{
    public class Game
    {
        private UserInteraction ui;
        private MazeTraversal maze;
        private IList<Entity> playerParty;
        
        public Game(UserInteraction ui)
        {
            this.ui = ui;
            AbstractCharacterFactory charFactory = new DefaultCharacterFactory();
            playerParty = new List<Entity>();
            for(int i = 0; i < 4; i++)
            {
                ui.PushStringLine(@"The list of classes that are in the game are:
Barbarian
Bard
Cleric
Druid
Fighter
Monk
Paladin
Ranger
Rogue
Sorcerer
Wizard");
                ui.PushString("Please enter the name of the class you would like to add to your party: ");
                string ans = ui.GetString().Split()[0].Trim();
                Entity player = charFactory.CreateCharacter(ans, ui);
                playerParty.Add(player);
                ui.PushStringLine("Added 1 " + player.GetType().Name);
            }
            maze = new MazeTraversal(playerParty);
        }

        public void Play()
        {
            while (!maze.AtEnd() && !AllDead())
            {
                maze.DisplayMaze(ui);
                ui.PushStringLine("");
                ui.PushStringLine(@"1: Move
2: Inventory");
                ui.PushString("Please enter the number corresponding to your selection: ");
                int selection = ui.GetIntInRange(1, 2);
                if(selection == 1)
                {
                    Move();
                }
                else
                {
                    Inventory();
                }
            }
            if(maze.AtEnd())
            {
                ui.PushStringLine("Congratulations! You have exited the maze.");
            }
            else
            {
                ui.PushStringLine("Sorry, your party has all died.");
            }
        }


        private bool AllDead()
        {
            foreach(var p in playerParty)
            {
                if (!p.IsDead())
                {
                    return false;
                }
            }
            return true;
        }

        private void Move()
        {
            ui.PushString("Please enter a direction you would like to move (up, down, left, right): ");
            IList<Item> rewards = maze.move(ui.GetString());
            if(rewards.Count != 0)
            {
                RewardManagement(rewards);
            }
        }

        private void Inventory()
        {
            Entity player = ui.GetTarget(playerParty);
            IList<Item> inventory = player.Inventory;

            int i = 1;
            foreach(var item in inventory)
            {
                ui.PushStringLine(i++ + ": " + item.Description);
            }

            ui.PushString("Please enter the number of the item, or a 0 to go back: ");
            int selection = ui.GetIntInRange(0, i - 1);
            if (selection == 0)
                return;
            selection -= 1; //offby one index
            Item selected = inventory[selection];

            if (selected is Weapon)
            {
                WeaponManagement((Weapon)selected, player);
            }
            else if (selected is Shield)
            {
                ShieldManagement((Shield)selected, player);
            }
            else if (selected is Armor)
            {
                ArmorManagement((Armor)selected, player);
            }
            else if (selected is Consumable)
            {
                ConsumableManagement((Consumable)selected, player);
            }
            else
            {
                ItemManagement(selected, player);
            }
        }

        private void WeaponManagement(Weapon wep, Entity player)
        {
            ui.PushStringLine("0: Go back");
            ui.PushStringLine("1: Equip to MainHand.");
            ui.PushStringLine("2: Equip to OffHand.");
            ui.PushStringLine("3: Give to Party member.");
            ui.PushStringLine("4: Throw away.");
            int selection = ui.GetIntInRange(0, 4);
            switch(selection)
            {
                case 0:
                    return;
                case 1:
                    player.RemoveItem(wep);
                    IList<Wieldable> returned = player.SetMainHand(wep);
                    foreach (var e in returned)
                        player.AddItem((Item)e);
                    break;
                case 2:
                    player.RemoveItem(wep);
                    player.AddItem((Item)player.SetOffHand(wep));
                    break;
                case 3:
                    Entity target = ui.GetTarget(playerParty);
                    player.RemoveItem(wep);
                    target.AddItem(wep);
                    break;
                case 4:
                    player.RemoveItem(wep);
                    break;
                default:
                    return;
            }
        }

        private void ShieldManagement(Shield shield, Entity player)
        {
            ui.PushStringLine("0: Go back");
            ui.PushStringLine("1: Equip to OffHand.");
            ui.PushStringLine("2: Give to Party member.");
            ui.PushStringLine("3: Throw away.");
            int selection = ui.GetIntInRange(0, 3);
            switch (selection)
            {
                case 0:
                    return;
                case 1:
                    player.RemoveItem(shield);
                    player.AddItem((Item)player.SetOffHand(shield));
                    break;
                case 2:
                    Entity target = ui.GetTarget(playerParty);
                    player.RemoveItem(shield);
                    target.AddItem(shield);
                    break;
                case 3:
                    player.RemoveItem(shield);
                    break;
                default:
                    return;
            }
        }

        private void ArmorManagement(Armor armor, Entity player)
        {
            ui.PushStringLine("0: Go back");
            ui.PushStringLine("1: Equip.");
            ui.PushStringLine("2: Give to Party member.");
            ui.PushStringLine("3: Throw away.");
            int selection = ui.GetIntInRange(0, 3);
            switch (selection)
            {
                case 0:
                    return;
                case 1:
                    player.RemoveItem(armor);
                    player.AddItem((Item)player.SetArmor(armor));
                    break;
                case 2:
                    Entity target = ui.GetTarget(playerParty);
                    player.RemoveItem(armor);
                    target.AddItem(armor);
                    break;
                case 3:
                    player.RemoveItem(armor);
                    break;
                default:
                    return;
            }
        }

        private void ConsumableManagement(Consumable cons, Entity player)
        {
            ui.PushStringLine("0: Go back");
            ui.PushStringLine("1: Use Item.");
            ui.PushStringLine("2: Give to Party member.");
            ui.PushStringLine("3: Throw away.");
            int selection = ui.GetIntInRange(0, 3);
            switch (selection)
            {
                case 0:
                    return;
                case 1:
                    Entity target = ui.GetTarget(playerParty);
                    if(((Consumable)cons).Apply(target))
                    {
                        player.RemoveItem(cons);
                    }
                    break;
                case 2:
                    target = ui.GetTarget(playerParty);
                    player.RemoveItem(cons);
                    target.AddItem(cons);
                    break;
                case 3:
                    player.RemoveItem(cons);
                    break;
                default:
                    return;
            }
        }

        private void ItemManagement(Item item, Entity player)
        {
            ui.PushStringLine("0: Go back");
            ui.PushStringLine("1: Give to Party member.");
            ui.PushStringLine("2: Throw away.");
            int selection = ui.GetIntInRange(0, 3);
            switch (selection)
            {
                case 0:
                    return;
                case 1:
                    Entity target = ui.GetTarget(playerParty);
                    player.RemoveItem(item);
                    target.AddItem(item);
                    break;
                case 2:
                    player.RemoveItem(item);
                    break;
                default:
                    return;
            }
        }

        private void RewardManagement(IList<Item> items)
        {
            foreach(var item in items)
            {
                ui.PushStringLine(item.Description);
                ui.PushStringLine("Please Select a player to give the item to.");
                Entity target = ui.GetTarget(playerParty);
                target.AddItem(item);
                ui.PushStringLine("");
            }
        }
    }
}
