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

        protected override int GetAttackBonus(bool offhand, int BaB)
        {
            int mod = 0;
            if(offhand)
            {
                if(OffHand.IsWeapon())
                {
                    if (!(weaponProficiencies.Contains(OffHand.Type) || weaponProficiencies.Contains(OffHand.ItemName)))
                    {
                        mod = -4;
                    }
                }
                else
                {
                    if (!(armorProfinciencies.Contains(OffHand.Type) || armorProfinciencies.Contains(OffHand.ItemName)))
                    {
                        mod = OffHand.ArmorCheckPenalty;
                    }
                }
            }
            else
            {
                if(!(weaponProficiencies.Contains(MainHand.Type) || weaponProficiencies.Contains(MainHand.ItemName)))
                {
                    mod = -4;
                }
            }
            return base.GetAttackBonus(offhand, BaB) + mod;
        }

        protected override void incLevel(int expLvl)
        {
            while (this.Level < expLvl)
            {
                this.Level++;
                incHP();
                incBaB(this.Level);
                incDef(this.Level);
                HP = HPMax;
                Mana = ManaMax;
                ui.PushStringLine(Name + " leveled up!");
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
