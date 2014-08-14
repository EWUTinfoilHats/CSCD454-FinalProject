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

        public Encounter(IList<Entity> players, IList<Entity> monsters, int cR)
        {
            playerParty = players;
            monsterParty = monsters;
            challengeRating = cR;
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

            combatList = (IList<Entity>)combatList.OrderByDescending((c) => c.Initiative); //why do i need to cast this...

            while(!AllDead(playerParty) && !AllDead(monsterParty))
            {               
                Queue<Entity> combatQueue = new Queue<Entity>(combatList);
                while(combatQueue.Count != 0)
                {
                    Entity e = combatQueue.Dequeue();
                    EntityCommand action = e.GetAction();
                    e.GetTarget(combatGroup);
                    action.Do(combatGroup);
                    e.UIDisplayHook();
                }
            }
            if (AllDead(monsterParty))
            {
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
