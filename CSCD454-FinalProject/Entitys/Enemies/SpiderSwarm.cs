using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Items;
using CSCD454_FinalProject.Items.Weapons;

namespace CSCD454_FinalProject.Entitys.Enemies
{
    class SpiderSwarm : Monster, MonsterPrototype
    {

        public SpiderSwarm()
        {
            this.attributes = new int[] { 10, 17, 10, 10, 10, 2 };
            this.Level = 1;
            this.HPMax = 9;
            this.HP = HPMax;
            this.BaB = new int[] { 1 };
            this.SavingThrows = new int[] { 3, 3, 0 };
            this.SetMainHand(Weapons.lightMace);
            this.Size = CSCD454_FinalProject.Size.Diminutive;
        }

        public Monster Clone()
        {
            return (Monster)this.MemberwiseClone();
        }
    }
}
