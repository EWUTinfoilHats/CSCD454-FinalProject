using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Entitys;

namespace CSCD454_FinalProject
{
    public class CombatGroup : IEnumerable<Entity>
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

        public Entity this[int index]
        {
            get
            {
                if (index < 0)
                    throw new IndexOutOfRangeException();
                if (index < Players.Count)
                    return Players[index];
                if (index >= Players.Count + Monsters.Count)
                    throw new IndexOutOfRangeException();
                return Monsters[index - Players.Count];
            }
        }

        public IEnumerator<Entity> GetEnumerator()
        {
            return new CombatGroupEnum(this);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return new CombatGroupEnum(this);
        }

        public class CombatGroupEnum : IEnumerator<Entity>
        {
            private int cur;
            private CombatGroup group;

            public CombatGroupEnum(CombatGroup g)
            {
                cur = -1;
                group = g;
            }

            public Entity Current
            {
                get { return group[cur]; }
            }

            public void Dispose()
            {
                
            }

            public bool MoveNext()
            {
                cur++;
                if (cur >= group.Players.Count + group.Monsters.Count)
                    return false;
                return true;
            }

            public void Reset()
            {
                cur = -1;
            }

            object System.Collections.IEnumerator.Current
            {
                get { return Current; }
            }
        }
    }
}
