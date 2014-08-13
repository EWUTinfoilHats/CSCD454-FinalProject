using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Items;
using CSCD454_FinalProject.Items.Weapons;


namespace CSCD454_FinalProject.Entitys.Enemies
{
    class Ghoul : Monster, MonsterPrototype
    {
        public Ghoul()
        {
            this.Name = "Ghoul";
            this.attributes = new int[] { 13, 15, 10, 13, 14, 14 };
            this.Level = 1;
            this.HPMax = 13;
            this.HP = HPMax;
            this.BaB = new int[] { 1 };
            this.SavingThrows = new int[] { 3, 5, 1 };
            this.SetMainHand(Weapons.lightMace);
            this.SetArmor(Armors.leatherArmor);
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
