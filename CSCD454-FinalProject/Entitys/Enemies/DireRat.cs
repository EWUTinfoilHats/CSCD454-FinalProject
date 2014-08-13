using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Items;
using CSCD454_FinalProject.Items.Weapons;

namespace CSCD454_FinalProject.Entitys.Enemies
{
    class DireRat : Monster, MonsterPrototype
    {

        public DireRat()
        {
            this.Name = "Dire Rat";
            this.attributes = new int[] { 10,17,13,2,13,4 };
            this.Level = 1;
            this.HPMax = 5;
            this.HP = HPMax;
            this.BaB = new int[] { 0 };
            this.SavingThrows = new int[] { 3,5,1 };
            this.SetMainHand(Weapons.dagger);
            this.Size = Size.Small;
            this.weaponProficiencies = new SortedSet<Weapon>();
            this.weaponProficiencies.Add(Weapons.dagger);
        }

        public Monster Clone()
        {
            return (Monster) this.MemberwiseClone();
        }
    }
}
