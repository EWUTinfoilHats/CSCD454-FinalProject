using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Entitys;

namespace CSCD454_FinalProject
{
    public class CombatGroup
    {
        private IList<Entity> playerGroup;
        private IList<Entity> monsterGroup;
        private Entity target;

        public CombatGroup(IList<Entity> players, IList<Entity> monsters)
        {
            playerGroup = players;
            monsterGroup = monsters;
        }

        public IList<Entity> Players
        {
            get
            {
                return playerGroup;
            }
        }

        public IList<Entity> Monsters
        {
            get
            {
                return monsterGroup;
            }
        }

        public void SetTarget(Entity target)
        {
            this.target = target;
        }

        public Entity Target
        {
            get
            {
                return target;
            }
        }
    }
}
