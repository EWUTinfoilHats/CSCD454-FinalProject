using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Items;
using CSCD454_FinalProject.Items.Weapons;


namespace CSCD454_FinalProject.Entitys.Enemies
{
    class GelatinousCube : Monster, MonsterPrototype
    {
        public GelatinousCube()
        {
            this.name = "Gelatinous Cube";
            this.attributes = new int[] { 10, 1, 26, 10, 1, 1 };
            this.Level = 3;
            this.HPMax = 50;
            this.HP = HPMax;
            this.BaB = new int[] { 3 };
            this.SavingThrows = new int[] { 9, -5, -1 };
            this.SetMainHand(Weapons.lightMace);
            this.Size = Size.Large;
            this.weaponProficiencies = new SortedSet<Weapon>();
            this.weaponProficiencies.Add(Weapons.lightMace);
        }

        public Monster Clone()
        {
            return (Monster)this.MemberwiseClone();
        }
    }
}
