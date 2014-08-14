using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD454_FinalProject.Items
{
    public class SimpleArmorEnchantment : ArmorEnchantment
    {
        private int bonus;
        public SimpleArmorEnchantment(Armor baseArmor, int bonus) : base(baseArmor)
        {
            this.bonus = bonus;
            enchantedArmor = baseArmor.GetBaseArmor();
        }

        public override int ArmorClass
        {
            get
            {
                return base.ArmorClass + bonus;
            }
        }

        public override int ArmorCheckPenalty
        {
            get
            {
                return Math.Min(base.ArmorCheckPenalty + 1, 0);
            }
        }

        public override string Name
        {
            get
            {
                return "+" + bonus + " " + enchantedArmor.Name;
            }
        }
    }
}
