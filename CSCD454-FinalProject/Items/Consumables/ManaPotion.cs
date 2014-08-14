using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Entitys;
using CSCD454_FinalProject.Dice;

namespace CSCD454_FinalProject.Items
{
    public class ManaPotion : Consumable
    {
        private int level;

        public ManaPotion(int level) : base()
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
            total += level;
            if (target.AddMana(total))
            {
                target.PushUIString(target.Name + " recovered " + total + " mana.");
                return true;
            }
            return false;
        }

        public override string Description
        {
            get
            {
                return "A potion that restores " + level + "d6+" + level + " mana.";
            }
        }
    }
}
