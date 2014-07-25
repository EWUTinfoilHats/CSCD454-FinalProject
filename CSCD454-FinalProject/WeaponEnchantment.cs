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

        public override Weapon GetBaseWeapon()
        {
            return enchantedWeapon;
        }
    }
}
