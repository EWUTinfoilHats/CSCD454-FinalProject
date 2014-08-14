using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Items;
using CSCD454_FinalProject.Items.Weapons;


namespace CSCD454_FinalProject.Entitys.Enemies
{
    class Choker : Monster, MonsterPrototype
    {
        public Choker()
        {
            this.Name = "Choker";
            this.attributes = new int[] { 16, 14, 13, 4, 13, 7 };
            this.Level = 2;
            this.HPMax = 16;
            this.HP = HPMax;
            this.BaB = new int[] { 2 };
            this.SavingThrows = new int[] { 2, 3, 4 };
            this.SetMainHand(Weapons.heavyMace);
            this.SetArmor(Armors.chainShirt);
            this.Size = Size.Small;
            this.weaponProficiencies = new SortedSet<Weapon>();
            this.weaponProficiencies.Add(Weapons.heavyMace);
        }

        public override Monster Clone()
        {
            return (Monster)this.MemberwiseClone();
        }
    }
}
