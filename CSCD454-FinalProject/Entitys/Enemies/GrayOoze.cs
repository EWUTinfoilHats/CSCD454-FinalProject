using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Items;
using CSCD454_FinalProject.Items.Weapons;


namespace CSCD454_FinalProject.Entitys.Enemies
{
    class GrayOoze : Monster, MonsterPrototype
    {
        public GrayOoze()
        {
            this.name = "Gray Ooze";
            this.attributes = new int[] { 16, 1, 26, 10, 1, 1 };
            this.Level = 4;
            this.HPMax = 50;
            this.HP = HPMax;
            this.BaB = new int[] { 0 };
            this.SavingThrows = new int[] { 9, -4, -4 };
            this.SetMainHand(Weapons.lightMace);
            this.Size = Size.Medium;
            this.weaponProficiencies = new SortedSet<Weapon>();
            this.weaponProficiencies.Add(Weapons.lightMace);
        }

        public Monster Clone()
        {
            return (Monster)this.MemberwiseClone();
        }
    }
}
