using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Items;
using CSCD454_FinalProject.Items.Weapons;


namespace CSCD454_FinalProject.Entitys.Enemies
{
    class Vargouille : Monster, MonsterPrototype
    {
        public Vargouille()
        {
            this.attributes = new int[] { 10, 13, 13, 5, 12, 8 };
            this.Level = 2;
            this.HPMax = 19;
            this.HP = HPMax;
            this.BaB = new int[] { 3 };
            this.SavingThrows = new int[] { 4, 4, 2 };
            this.SetMainHand(Weapons.dagger);
            this.SetArmor(Armors.studdedLeatherArmor);
            this.Size = Size.Small;
        }

        public Monster Clone()
        {
            return (Monster)this.MemberwiseClone();
        }
    }
}
