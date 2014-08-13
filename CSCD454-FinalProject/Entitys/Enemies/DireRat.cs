using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD454_FinalProject.Entitys.Enemies
{
    class DireRat : Monster, MonsterPrototype
    {

        public DireRat()
        {
            this.attributes = new int[] { 10,17,13,2,13,4 };
            this.Level = 1;
            this.HPMax = 9;
            this.HP = HPMax;
            this.BaB = new int[] { 0 };
            this.SavingThrows = new int[] { 3,5,1 };
            this.SetMainHand(CSCD454_FinalProject.Items.Weapons.Weapons.dagger);
            this.Size = CSCD454_FinalProject.Size.Small;
        }

        public Monster Clone()
        {
            return (Monster) this.MemberwiseClone();
        }
    }
}
