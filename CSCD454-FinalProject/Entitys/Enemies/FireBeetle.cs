using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD454_FinalProject.Entitys.Enemies
{
    class FireBeetle : Monster, MonsterPrototype
    {
        public FireBeetle()
        {
            this.attributes = new int[] { 10, 11, 11, 10, 10, 7 };
            this.Level = 1;
            this.HPMax = 8;
            this.HP = HPMax;
            this.BaB = new int[] { 0 };
            this.SavingThrows = new int[] { 2, 0, 0 };
            this.Size = CSCD454_FinalProject.Size.Small;
            this.SetMainHand(CSCD454_FinalProject.Items.Weapons.Weapons.dagger);
            this.SetArmor(CSCD454_FinalProject.Items.Armors.paddedArmor);
        }

        public Monster Clone()
        {
            return (Monster)this.MemberwiseClone();
        }
    }
}
