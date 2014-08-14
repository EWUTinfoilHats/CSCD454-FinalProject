using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD454_FinalProject.Items
{
    public class MasterworkArmor : ArmorEnchantment
    {
        public MasterworkArmor(Armor baseArmor) : base(baseArmor)
        {

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
                return "Masterwork " + enchantedArmor.Name;
            }
        }
    }
}
