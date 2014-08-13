using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Items;
using CSCD454_FinalProject.Items.Weapons;


namespace CSCD454_FinalProject.Entitys.Enemies
{
    class RustMonster : Monster, MonsterPrototype
    {
        public RustMonster()
        {
            this.attributes = new int[] { 10, 17, 13, 2, 13, 8 };
            this.Level = 3;
            this.HPMax = 27;
            this.HP = HPMax;
            this.BaB = new int[] { 3 };
            this.SavingThrows = new int[] { 3, 5, 1 };
            this.SetMainHand(Weapons.unarmedStrike);
            this.SetArmor(Armors.scaleMail);
            this.Size = Size.Medium;
            this.weaponProficiencies = new SortedSet<Weapon>();
            this.weaponProficiencies.Add(Weapons.unarmedStrike);
        }

        public Monster Clone()
        {
            return (Monster)this.MemberwiseClone();
        }
    }
}
