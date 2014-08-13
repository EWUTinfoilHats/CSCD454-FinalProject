using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Items;
using CSCD454_FinalProject.Items.Weapons;


namespace CSCD454_FinalProject.Entitys.Enemies
{
    class Ogre : Monster, MonsterPrototype
    {
        public Ogre()
        {
            this.Name = "Ogre";
            this.attributes = new int[] { 21, 8, 15, 6, 10, 7 };
            this.Level = 3;
            this.HPMax = 30;
            this.HP = HPMax;
            this.BaB = new int[] { 3 };
            this.SavingThrows = new int[] { 3, 5, 1 };
            this.SetMainHand(Weapons.heavyMace);
            this.SetArmor(Armors.fullPlate);
            this.Size = Size.Large;
            this.weaponProficiencies = new SortedSet<Weapon>();
            this.weaponProficiencies.Add(Weapons.heavyMace);
        }

        public Monster Clone()
        {
            return (Monster)this.MemberwiseClone();
        }
    }
}
