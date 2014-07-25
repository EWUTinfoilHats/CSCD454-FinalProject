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

        public override Armor GetBaseArmor()
        {
            return enchantedArmor;
        }
    }
}
