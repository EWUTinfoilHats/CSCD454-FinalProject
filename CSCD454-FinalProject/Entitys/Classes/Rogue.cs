﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Dice;
using CSCD454_FinalProject.Items;
using System.Collections;

namespace CSCD454_FinalProject.Entitys
{
    public class Rogue : Player
    {
        public Rogue(int[] abilities)
        {
            this.HitDie = D8.GetInstance();
            this.BaBStrat = new BaB8();
            this.ThrowStrategy = new Throw020();
            this.attributes = abilities;
            this.Level = 1;
            this.experience = 0;
            this.HPMax = 10 + Attribute.GetAbilityMod(attributes[(int)Attributes.Con]);
            this.HP = HPMax;
            this.BaB = BaBStrat.getBaB(Level);
            this.SavingThrows = ThrowStrategy.getThrows(Level);
            this.weaponProficiencies = new HashSet<string>();
            this.armorProfinciencies = new HashSet<string>();
            weaponProficiencies.UnionWith(new string[] { "simple", "Rapier", "Hand Crossbow", "Sap", "Shortbow", "Short Sword" });
            armorProfinciencies.Add("light");
        }
    }
}
