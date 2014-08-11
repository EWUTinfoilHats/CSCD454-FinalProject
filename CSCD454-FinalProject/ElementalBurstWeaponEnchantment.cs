using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Dice;

namespace CSCD454_FinalProject.Items
{
    public class ElementalBurstWeaponEnchantment : ElementalWeaponEnchantment
    {
        public ElementalBurstWeaponEnchantment(Weapon baseWeapon) : base(baseWeapon)
        {

        }

        public override int GetCriticalDamageRoll(int strength, bool isOffhand)
        {
            Die d10 = D10.GetInstance();
            int bonusDamage = 0;

            if (CriticalMultiplier >= 2)
            {
                bonusDamage += d10.Roll();
            }
            if (CriticalMultiplier >= 3)
            {
                bonusDamage += d10.Roll();
            }
            if (CriticalMultiplier >= 4)
            {
                bonusDamage += d10.Roll();
            }

            return base.GetCriticalDamageRoll(strength, isOffhand) + bonusDamage;
        }

        public override string Name
        {
            get
            {
                return "Fiery Burst " + base.Name;
            }
        }
    }
}
