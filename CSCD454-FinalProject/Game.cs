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
                playerParty.Add(charFactory.CreateCharacter(ans, ui));
                ui.PushStringLine("");
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

        }

        private void RewardManagement(IList<Item> items)
        {

        }
    }
}
