using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Items;
using CSCD454_FinalProject.Items.Weapons;


namespace CSCD454_FinalProject.Entitys.Enemies
{
    class Mimic : Monster, MonsterPrototype
    {
        public Mimic()
        {
            this.attributes = new int[] { 19, 12, 17, 10, 13, 10 };
            this.Level = 4;
            this.HPMax = 52;
            this.HP = HPMax;
            this.BaB = new int[] { 5 };
            this.SavingThrows = new int[] { 5, 5, 6 };
            this.SetMainHand(Weapons.heavyMace);
            this.SetArmor(Armors.scaleMail);
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
