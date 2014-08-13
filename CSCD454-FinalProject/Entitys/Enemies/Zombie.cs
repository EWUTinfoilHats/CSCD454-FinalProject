using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Items;
using CSCD454_FinalProject.Items.Weapons;


namespace CSCD454_FinalProject.Entitys.Enemies
{
    class Zombie : Monster, MonsterPrototype
    {
        public Zombie()
        {
            this.attributes = new int[] { 17, 10, 10, 10, 10, 10 };
            this.Level = 1;
            this.HPMax = 12;
            this.HP = HPMax;
            this.BaB = new int[] { 1 };
            this.SavingThrows = new int[] { 0, 0, 3 };
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
