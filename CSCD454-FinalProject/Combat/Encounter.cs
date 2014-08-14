using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Items;
using CSCD454_FinalProject.Entitys;
using CSCD454_FinalProject.UI;
using CSCD454_FinalProject.Dice;
using CSCD454_FinalProject.Entitys.Commands;
using CSCD454_FinalProject.Factories;

namespace CSCD454_FinalProject.Combat
{
    public class Encounter
    {
        private IList<Entity> playerParty;
        private IList<Entity> monsterParty;
        private int challengeRating;

        public Encounter(IList<Entity> players, IList<Entity> monsters, int CR)
        {
            playerParty = players;
            monsterParty = monsters;
            challengeRating = CR;
        }

        /// <summary>
        /// Runs until 1 party is dead
        /// </summary>
        /// <returns>Returns IList of Items that dropped as loot</returns>
        public IList<Item> Fight()
        {
            IList<Entity> combatList = new List<Entity>();
            CombatGroup combatGroup = new CombatGroup(playerParty, monsterParty);
            foreach (var e in combatGroup)
            {
                e.SetInitiative();
                combatList.Add(e);
            }

            combatList = combatList.OrderByDescending((c) => c.Initiative).ToList();

            foreach (var e in playerParty)
                e.PushUIString(e.Description);
            foreach (var e in monsterParty)
                e.PushUIString(e.Description);

            while(!AllDead(playerParty) && !AllDead(monsterParty))
            {               
                Queue<Entity> combatQueue = new Queue<Entity>(combatList);
                while(combatQueue.Count != 0 && !AllDead(playerParty) && !AllDead(monsterParty))
                {
                    Entity e = combatQueue.Dequeue();
                    if (e.IsDead())
                        continue;
                    EntityCombatCommand action = e.GetAction();
                    e.GetTarget(combatGroup);
                    action.Do(combatGroup);
                    e.UIDisplayHook();
                }
            }
            if (AllDead(monsterParty))
            {
                foreach(var p in playerParty)
                {
                    int exp = 100 + (challengeRating - 1) * 50;
                    p.AddExperience(exp);
                    p.PushUIString(p.Name + " gained " + exp + "xp.");
                }
                AbstractLootFactory lootFactory = new DefaultLootFactory();
                return lootFactory.GenerateLoot(challengeRating);
            }
            return new Item[0];
        }

        private bool AllDead(IList<Entity> party)
        {
            foreach(var e in party)
            {
                if (!e.IsDead())
                    return false;
            }
            return true;
        }
    }
}
