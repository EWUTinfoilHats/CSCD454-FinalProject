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

        public override string ItemName
        {
            get
            {
                return enchantedWeapon.ItemName;
            }
        }

        public override int AttackMod
        {
            get
            {
                return enchantedWeapon.AttackMod;
            }
        }

        public override int CriticalMultiplier
        {
            get
            {
                return enchantedWeapon.CriticalMultiplier;
            }
        }

        public override IList<Dice.Die> DamageDice
        {
            get
            {
                return enchantedWeapon.DamageDice;
            }
        }

        public override int DamageMod
        {
            get
            {
                return enchantedWeapon.DamageMod;
            }
        }

        public override string Name
        {
            get
            {
                return enchantedWeapon.Name;
            }
        }

        public override int ThreatRangeMax
        {
            get
            {
                return enchantedWeapon.ThreatRangeMax;
            }
        }

        public override int ThreatRangeMin
        {
            get
            {
                return enchantedWeapon.ThreatRangeMin;
            }
        }

        public override string Type
        {
            get
            {
                return enchantedWeapon.Type;
            }
        }

        public override int Price
        {
            get
            {
                return enchantedWeapon.Price + 1000;
            }
        }

        public override int Weight
        {
            get
            {
                return enchantedWeapon.Weight;
            }
        }
    }
}
