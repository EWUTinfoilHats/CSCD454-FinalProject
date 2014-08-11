using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Entitys;

namespace CSCD454_FinalProject.Items
{
    public class HealthPotion : Consumable
    {
        private int amount;

        public HealthPotion(int amount) : base()
        {
            this.amount = amount;
        }

        public override bool Apply(Entity target)
        {
            return target.AddHP(amount);
        }

        public override string Description
        {
            get
            {
                return "A healing potion that restores " + amount + " hp.";
            }
        }
    }
}
