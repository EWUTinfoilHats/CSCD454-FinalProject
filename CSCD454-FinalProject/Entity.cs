using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Items;

namespace CSCD454_FinalProject.Entitys
{
    public abstract class Entity
    {
        protected IList<int> attributes;
        //protected IList<Spell> spells;

        public Armor Armor
        {
            get;
            protected set;
        }

        public int CurMana
        {
            get;
            protected set;
        }

        public int HP
        {
            get;
            protected set;
        }

        public int HPMax
        {
            get;
            protected set;
        }

        public int Initiative
        {
            get;
            protected set;
        }

        public int Level
        {
            get;
            protected set;
        }

        public Weapon MainHand
        {
            get;
            protected set;
        }

        public Wieldable OffHand
        {
            get;
            protected set;
        }

        public Size Size
        {
            get;
            protected set;
        }

        public virtual void Attack(Entity target)
        {
            throw new NotImplementedException();
        }

        public bool Has2H()
        {
            throw new NotImplementedException();
        }

        public bool IsDead()
        {
            return HP == 0;
        }

        public int TouchArmorClass()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
