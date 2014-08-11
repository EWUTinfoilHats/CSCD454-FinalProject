using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Entitys;

namespace CSCD454_FinalProject.Items
{
    public class ManaPotion : Consumable
    {
        private int amount;

        public ManaPotion(int amount) : base()
        {
            this.amount = amount;
        }

        public override bool Apply(Entity target)
        {
            return target.AddMana(amount);
        }

        public override string Description
        {
            get
            {
                return "A potion that restores " + amount + " mana.";
            }
        }
    }
}
