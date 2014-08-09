using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD454_FinalProject.Items
{
    public class MasterworkWeapon : WeaponEnchantment
    {
        public MasterworkWeapon(Weapon baseWep) : base(baseWep)
        {
            enchantedWeapon = baseWep.GetBaseWeapon();
        }

        public override int AttackMod
        {
            get
            {
                return 1;
            }
        }
    }
}
