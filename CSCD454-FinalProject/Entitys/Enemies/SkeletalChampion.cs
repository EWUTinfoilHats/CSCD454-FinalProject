using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Items;
using CSCD454_FinalProject.Items.Weapons;


namespace CSCD454_FinalProject.Entitys.Enemies
{
    class SkeletalChampion : Monster, MonsterPrototype
    {
        public SkeletalChampion()
        {
            this.Name = "Skeletal Champion";
            this.attributes = new int[] { 18, 13, 10, 9, 10, 12 };
            this.Level = 2;
            this.HPMax = 17;
            this.HP = HPMax;
            this.BaB = new int[] { 2 };
            this.SavingThrows = new int[] { 3, 1, 3 };
            this.SetMainHand(Weapons.heavyMace);
            this.SetOffHand(Armors.heavyWoodenShield);
            this.SetArmor(Armors.halfPlate);
            this.Size = Size.Medium;
            this.weaponProficiencies = new SortedSet<Weapon>();
            this.weaponProficiencies.Add(Weapons.heavyMace);
        }

        public Monster Clone()
        {
            return (Monster)this.MemberwiseClone();
        }
    }
}
