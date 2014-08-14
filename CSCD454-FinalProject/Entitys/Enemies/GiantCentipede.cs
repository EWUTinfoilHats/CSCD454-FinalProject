using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Items;
using CSCD454_FinalProject.Items.Weapons;


namespace CSCD454_FinalProject.Entitys.Enemies
{
    class GiantCentipede : Monster, MonsterPrototype
    {

        public GiantCentipede()
        {
            this.Name = "Giant Centipede";
            this.attributes = new int[] { 9, 15, 12, 10, 10, 2 };
            this.Level = 1;
            this.HPMax = 5;
            this.HP = HPMax;
            this.BaB = new int[] { 0 };
            this.SavingThrows = new int[] { 3, 2, 0 };
            this.SetMainHand(Weapons.lightMace);
            this.SetArmor(Armors.leatherArmor);
            this.Size = CSCD454_FinalProject.Size.Medium;
            this.weaponProficiencies = new SortedSet<Weapon>();
            this.weaponProficiencies.Add(Weapons.lightMace);
        }

        public override Monster Clone()
        {
            return (Monster)this.MemberwiseClone();
        }
    }
}
