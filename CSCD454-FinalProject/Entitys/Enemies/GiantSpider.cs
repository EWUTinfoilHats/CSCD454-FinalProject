using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Items;
using CSCD454_FinalProject.Items.Weapons;


namespace CSCD454_FinalProject.Entitys.Enemies
{
    class GiantSpider : Monster, MonsterPrototype
    {
        public GiantSpider()
        {
            this.attributes = new int[] { 11, 17, 12, 10, 10, 2 };
            this.Level = 1;
            this.HPMax = 16;
            this.HP = HPMax;
            this.BaB = new int[] { 2 };
            this.SavingThrows = new int[] { 4, 4, 1 };
            this.SetMainHand(Weapons.lightMace);
            this.SetArmor(Armors.paddedArmor);
            this.Size = Size.Medium;
        }

        public Monster Clone()
        {
            return (Monster)this.MemberwiseClone();
        }
    }
}
