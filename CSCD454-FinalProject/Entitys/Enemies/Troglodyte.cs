﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Items;
using CSCD454_FinalProject.Items.Weapons;


namespace CSCD454_FinalProject.Entitys.Enemies
{
    class Troglodyte : Monster, MonsterPrototype
    {
        public Troglodyte()
        {
            this.attributes = new int[] { 12, 9, 14, 8, 11, 11 };
            this.Level = 1;
            this.HPMax = 13;
            this.HP = HPMax;
            this.BaB = new int[] { 1 };
            this.SavingThrows = new int[] { 7, -1, 0 };
            this.SetMainHand(Weapons.lightMace);
            this.SetArmor(Armors.chainmail);
            this.Size = Size.Medium;
        }

        public Monster Clone()
        {
            return (Monster)this.MemberwiseClone();
        }
    }
}
