using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD454_FinalProject.Entitys.Enemies
{
    class GiantCentipede : Monster, MonsterPrototype
    {

        public GiantCentipede()
        {
            this.attributes = new int[] { 9, 15, 12, 10, 10, 2 };
            this.Level = 1;
            this.HPMax = 9;
            this.HP = HPMax;
            this.BaB = new int[] { 0 };
            this.SavingThrows = new int[] { 3, 2, 0 };
            this.SetMainHand(CSCD454_FinalProject.Items.Weapons.Weapons.lightMace);
            this.SetArmor(CSCD454_FinalProject.Items.Armors.leatherArmor);
            this.Size = CSCD454_FinalProject.Size.Medium;
        }

        public Monster Clone()
        {
            return (Monster)this.MemberwiseClone();
        }
    }
}
