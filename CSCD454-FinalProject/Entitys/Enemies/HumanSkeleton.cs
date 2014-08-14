using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Items;
using CSCD454_FinalProject.Items.Weapons;

namespace CSCD454_FinalProject.Entitys.Enemies
{
    class HumanSkeleton : Monster, MonsterPrototype
    {
        public HumanSkeleton()
        {
            this.Name = "Human Skeleton";
            this.attributes = new int[] { 15, 14, 10, 10, 10, 10 };
            this.Level = 1;
            this.HPMax = 8;
            this.HP = HPMax;
            this.BaB = new int[] { 0 };
            this.SavingThrows = new int[] { 0, 2, 2 };
            this.SetMainHand(Weapons.lightMace);
            this.SetArmor(Armors.chainShirt);
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
