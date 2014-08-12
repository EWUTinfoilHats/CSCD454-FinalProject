using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Entitys;
using CSCD454_FinalProject.Dice;

namespace CSCD454_FinalProject.Items
{
    public class HarmingPotion : Consumable
    {
        private int level;

        public HarmingPotion(int level) : base()
        {
            this.level = level;
        }

        public override bool Apply(Entity target)
        {
            Die d6 = D6.GetInstance();
            int total = 0;
            for (int i = 0; i < level; i++)
            {
                total += d6.Roll();
            }
                return target.RemoveHP(total + level);
        }

        public override string Description
        {
            get
            {
                return "A throwable potion that drains " + level + "d6+" + level + " hp.";
            }
        }
    }
}
