using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Items;
using CSCD454_FinalProject.Items.Weapons;


namespace CSCD454_FinalProject.Entitys.Enemies
{
    class Cockatrice : Monster, MonsterPrototype
    {
        public Cockatrice()
        {
            this.attributes = new int[] { 6, 17, 11, 2, 13, 8 };
            this.Level = 3;
            this.HPMax = 27;
            this.HP = HPMax;
            this.BaB = new int[] { 5 };
            this.SavingThrows = new int[] { 4, 7, 2 };
            this.SetMainHand(Weapons.dagger);
            this.SetArmor(Armors.paddedArmor);
            this.Size = Size.Small;
            this.weaponProficiencies = new SortedSet<Weapon>();
            this.weaponProficiencies.Add(Weapons.dagger);
        }

        public Monster Clone()
        {
            return (Monster)this.MemberwiseClone();
        }
    }
}
