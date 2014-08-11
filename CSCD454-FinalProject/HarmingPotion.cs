using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Entitys;

namespace CSCD454_FinalProject.Items
{
    public class HarmingPotion : Consumable
    {
        private int amount;

        public HarmingPotion(int amount) : base()
        {
            this.amount = amount;
        }

        public override bool Apply(Entity target)
        {
            return target.RemoveHP(amount);
        }

        public override string Description
        {
            get
            {
                return "A throwable potion that drains " + amount + " hp.";
            }
        }
    }
}
