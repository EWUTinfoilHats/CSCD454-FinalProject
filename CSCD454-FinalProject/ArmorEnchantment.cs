using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD454_FinalProject.Items
{
    public abstract class ArmorEnchantment : Armor
    {
        protected Armor enchantedArmor;

        public ArmorEnchantment(Armor baseArmor)
        {
            if(!(baseArmor is SimpleArmorEnchantment))
            {
                enchantedArmor = baseArmor.GetBaseArmor();
            }
            else
            {
                enchantedArmor = baseArmor;
            }
        }

        public override Armor GetBaseArmor()
        {
            return enchantedArmor.GetBaseArmor();
        }
    }
}
