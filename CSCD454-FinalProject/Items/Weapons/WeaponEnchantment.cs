using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD454_FinalProject.Items
{
    public abstract class WeaponEnchantment : Weapon
    {
        protected Weapon enchantedWeapon;

        public WeaponEnchantment(Weapon baseWep)
        {
            if (!(baseWep is SimpleWeaponEnchantment))
            {
                enchantedWeapon = baseWep.GetBaseWeapon();
            }
            else
            {
                enchantedWeapon = baseWep;
            }
        }

        public override Weapon GetBaseWeapon()
        {
            return enchantedWeapon.GetBaseWeapon();
        }
    }
}
