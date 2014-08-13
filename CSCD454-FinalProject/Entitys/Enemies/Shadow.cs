using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Items;
using CSCD454_FinalProject.Items.Weapons;


namespace CSCD454_FinalProject.Entitys.Enemies
{
    class Shadow : Monster, MonsterPrototype
    {
        public Shadow()
        {
            this.name = "Shadow";
            this.attributes = new int[] { 10, 14, 10, 6, 12, 15 };
            this.Level = 3;
            this.HPMax = 19;
            this.HP = HPMax;
            this.BaB = new int[] { 2 };
            this.SavingThrows = new int[] { 3, 3, 4 };
            this.SetMainHand(Weapons.lightMace);
            this.SetArmor(Armors.studdedLeatherArmor);
            this.Size = Size.Medium;
            this.weaponProficiencies = new SortedSet<Weapon>();
            this.weaponProficiencies.Add(Weapons.lightMace);
        }

        public override Monster Clone()
        {
            return (Monster)this.MemberwiseClone();
        }
    }
}
