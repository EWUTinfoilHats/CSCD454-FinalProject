using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Items;

namespace CSCD454_FinalProject.Entitys.Enemies
{
    class HumanSkeleton : Monster, MonsterPrototype
    {
        public HumanSkeleton()
        {
            this.attributes = new int[] { 15, 14, 10, 10, 10, 10 };
            this.Level = 1;
            this.HPMax = 8;
            this.HP = HPMax;
            this.BaB = new int[] { 0 };
            this.SavingThrows = new int[] { 0, 2, 2 };
            this.SetArmor(CSCD454_FinalProject.Items.Armors.chainShirt);
            this.SetMainHand(CSCD454_FinalProject.Items.Weapons.Weapons.lightMace);
            this.Size = CSCD454_FinalProject.Size.Medium;
        }

        public Monster Clone()
        { 
            return (Monster)this.MemberwiseClone();
        }
    }
}
