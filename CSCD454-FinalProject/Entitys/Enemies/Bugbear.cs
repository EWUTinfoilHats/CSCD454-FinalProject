using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Items;
using CSCD454_FinalProject.Items.Weapons;


namespace CSCD454_FinalProject.Entitys.Enemies
{
    class Bugbear : Monster, MonsterPrototype
    {
        public Bugbear()
        {
            this.attributes = new int[] { 16, 13, 13, 10, 10, 9 };
            this.Level = 2;
            this.HPMax = 16;
            this.HP = HPMax;
            this.BaB = new int[] { 2 };
            this.SavingThrows = new int[] { 2, 4, 1 };
            this.SetMainHand(Weapons.heavyMace);
            this.SetArmor(Armors.scaleMail);
            this.SetOffHand(Armors.buckler);
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
