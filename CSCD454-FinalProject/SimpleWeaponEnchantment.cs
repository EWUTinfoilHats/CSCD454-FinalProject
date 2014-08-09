using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD454_FinalProject.Items
{
    class SimpleWeaponEnchantment : WeaponEnchantment
    {
        private int bonus;
        public SimpleWeaponEnchantment(Weapon baseWep, int bonus) : base(baseWep)
        {
            enchantedWeapon = baseWep.GetBaseWeapon();
            this.bonus = bonus;
        }

        public override int AttackMod
        {
            get
            {
                return bonus;
            }
        }

        public override int DamageMod
        {
            get
            {
                return bonus;
            }
        }
    }
}
