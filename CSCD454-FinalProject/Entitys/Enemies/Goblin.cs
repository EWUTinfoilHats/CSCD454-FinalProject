using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Items;
using CSCD454_FinalProject.Items.Weapons;


namespace CSCD454_FinalProject.Entitys.Enemies
{
    class Goblin : Monster, MonsterPrototype
    {
        public Goblin()
        {
            this.name = "Goblin";
            this.attributes = new int[] { 11, 15, 12, 10, 9, 6 };
            this.Level = 1;
            this.HPMax = 6;
            this.HP = HPMax;
            this.BaB = new int[] { 1 };
            this.SavingThrows = new int[] { 3, 2, -1 };
            this.SetMainHand(Weapons.shortSword);
            this.SetOffHand(Armors.buckler);
            this.SetArmor(Armors.leatherArmor);
            this.Size = Size.Small;
            this.weaponProficiencies = new SortedSet<Weapon>();
            this.weaponProficiencies.Add(Weapons.shortSword);
        }

        public override Monster Clone()
        {
            return (Monster)this.MemberwiseClone();
        }
    }
}
