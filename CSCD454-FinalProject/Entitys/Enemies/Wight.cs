using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Items;
using CSCD454_FinalProject.Items.Weapons;


namespace CSCD454_FinalProject.Entitys.Enemies
{
    class Wight : Monster, MonsterPrototype
    {
        public Wight()
        {
            this.Name = "Wight";
            this.attributes = new int[] { 12, 12, 10, 11, 13, 15 };
            this.Level = 3;
            this.HPMax = 26;
            this.HP = HPMax;
            this.BaB = new int[] { 3 };
            this.SavingThrows = new int[] { 3, 2, 5 };
            this.SetMainHand(Weapons.dagger);
            this.SetArmor(Armors.chainShirt);
            this.Size = Size.Medium;
            this.weaponProficiencies = new SortedSet<Weapon>();
            this.weaponProficiencies.Add(Weapons.dagger);
        }

        public Monster Clone()
        {
            return (Monster)this.MemberwiseClone();
        }
    }
}
