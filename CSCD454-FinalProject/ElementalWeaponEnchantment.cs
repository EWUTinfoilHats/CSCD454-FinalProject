using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Dice;

namespace CSCD454_FinalProject.Items
{
    public class ElementalWeaponEnchantment : WeaponEnchantment
    {
        public ElementalWeaponEnchantment(Weapon baseWeapon) : base(baseWeapon)
        {

        }

        public override int GetDamageRoll(int strength, bool isOffhand)
        {
            return DamageHelper(strength, isOffhand) + D6.GetInstance().Roll();
        }

        public override int GetCriticalDamageRoll(int strength, bool isOffhand)
        {
            return base.GetCriticalDamageRoll(strength, isOffhand) + D6.GetInstance().Roll();
        }

        public override string Name
        {
            get
            {
                return "Fiery " + base.Name;
            }
        }
    }
}
