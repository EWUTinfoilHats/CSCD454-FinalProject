using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Items;
using CSCD454_FinalProject.Items.Weapons;


namespace CSCD454_FinalProject.Entitys.Enemies
{
    class Stirge : Monster, MonsterPrototype
    {
        public Stirge()
        {
            this.name = "Stirge";
            this.attributes = new int[] { 3, 19, 10, 1, 12, 6 };
            this.Level = 1;
            this.HPMax = 5;
            this.HP = HPMax;
            this.BaB = new int[] { 1 };
            this.SavingThrows = new int[] { 2, 6, 1 };
            this.SetMainHand(Weapons.dagger);
            this.SetArmor(Armors.leatherArmor);
            this.Size = Size.Tiny;
            this.weaponProficiencies = new SortedSet<Weapon>();
            this.weaponProficiencies.Add(Weapons.dagger);
        }

        public override Monster Clone()
        {
            return (Monster)this.MemberwiseClone();
        }
    }
}
