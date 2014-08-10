using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Dice;
using CSCD454_FinalProject.Items;

namespace CSCD454_FinalProject.Entitys
{
    public abstract class Player : Entity
    {
        protected IList<Item> inventory;
        protected ISet<Weapon> weaponProficiencies;

        protected Die HitDie
        {
            get;
            set;
        }

        protected BaseAttackBonus BaBStrat
        {
            get;
            set;
        }

        protected int[] BaB
        {
            get;
            set;
        }

        protected DefenseStrategy ThrowStrategy
        {
            get;
            set;
        }

        protected int[] SavingThrows
        {
            get;
            set;
        }

        protected int experience
        {
            get;
            set;
        }

        new public virtual void Attack(Entity target)
        {
            throw new NotImplementedException();
        }

        public void AddExperience(int exp)
        {
            this.experience += exp;
            LevelUp();
        }

        private void LevelUp()
        {
            int expLvl = (int)Math.Floor(experience / 1000.0);
            if (expLvl > this.Level)
                incLevel(expLvl);
        }

        private void incLevel(int expLvl)
        {
            while (this.Level < expLvl)
            {
                this.Level++;
                incHP();
                incBaB(this.Level);
                incDef(this.Level);
            }
        }

        private void incHP()
        {
            this.HPMax = (this.HPMax + HitDie.Roll() + Attribute.GetAbilityMod(attributes[(int)Attributes.Con]));
        }

        private void incBaB(int level)
        {
            this.BaB = this.BaBStrat.getBaB(level);
        }

        private void incDef(int level)
        {
            this.SavingThrows = this.ThrowStrategy.getThrows(level);
        }
    }
}
