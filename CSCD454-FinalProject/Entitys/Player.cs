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
        protected ISet<string> weaponProficiencies;
        protected ISet<string> armorProfinciencies;

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

        protected DefenseStrategy ThrowStrategy
        {
            get;
            set;
        }

        protected int experience
        {
            get;
            set;
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

        protected override int GetAttackBonus(bool offhand, int BaB)
        {
            int mod = 0;
            if(offhand)
            {
                if(OffHand.IsWeapon())
                {
                    if (!(weaponProficiencies.Contains(OffHand.Type) || weaponProficiencies.Contains(OffHand.Name)))
                    {
                        mod = -4;
                    }
                }
                else
                {
                    if (!(armorProfinciencies.Contains(OffHand.Type) || armorProfinciencies.Contains(OffHand.Name)))
                    {
                        mod = OffHand.ArmorCheckPenalty;
                    }
                }
            }
            else
            {
                if(!(weaponProficiencies.Contains(MainHand.Type) || weaponProficiencies.Contains(MainHand.Name)))
                {
                    mod = -4;
                }
            }
            return base.GetAttackBonus(offhand, BaB) + mod;
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
