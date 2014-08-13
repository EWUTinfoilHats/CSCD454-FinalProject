using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Items;
using CSCD454_FinalProject.Items.Weapons;


namespace CSCD454_FinalProject.Entitys.Enemies
{
    class Darkmantle : Monster, MonsterPrototype
    {
        public Darkmantle()
        {
            this.Name = "Dark Mantle";
            this.attributes = new int[] { 11, 15, 14, 2, 11, 10 };
            this.Level = 1;
            this.HPMax = 15;
            this.HP = HPMax;
            this.BaB = new int[] { 2 };
            this.SavingThrows = new int[] { 5, 3, 0 };
            this.SetMainHand(Weapons.dagger);
            this.SetArmor(Armors.leatherArmor);
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
