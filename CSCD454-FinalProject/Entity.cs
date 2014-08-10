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

        public int Mana
        {
            get;
            protected set;
        }

        public int ManaMax
        {
            get;
            protected set;
        }

        public bool AddMana(int amount)
        {
            if (Mana == ManaMax)
                return false;
            Mana = Math.Min(Mana + amount, ManaMax);
            return true;
        }

        public bool RemoveMana(int amount)
        {
            if (Mana < amount)
                return false;
            Mana -= amount;
            return true;
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

        public bool AddHP(int amount)
        {
            if (IsDead() || HP == HPMax)
                return false;
            HP = Math.Min(HPMax, HP + amount);
            return true;
        }

        public bool RemoveHP(int amount)
        {
            if (IsDead())
                return false;
            HP -= amount;
            return true;
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
