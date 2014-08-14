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

        public override string ItemName
        {
            get
            {
                return enchantedArmor.ItemName;
            }
        }

        public override int ArcaneSpellFailure
        {
            get
            {
                return enchantedArmor.ArcaneSpellFailure;
            }
        }

        public override int ArmorClass
        {
            get
            {
                return enchantedArmor.ArmorClass;
            }
        }

        public override int ArmorCheckPenalty
        {
            get
            {
                return enchantedArmor.ArmorCheckPenalty;
            }
        }

        public override string Type
        {
            get
            {
                return enchantedArmor.Type;
            }
        }
    }
}
