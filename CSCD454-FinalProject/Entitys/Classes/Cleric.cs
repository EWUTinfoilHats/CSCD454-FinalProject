﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Dice;
using CSCD454_FinalProject.Items;
using System.Collections;
using CSCD454_FinalProject.Spells.DivineSpells;

namespace CSCD454_FinalProject.Entitys
{
    class Cleric : Player
    {
        public Cleric(int[] abilities)
        {
            this.HitDie = D8.GetInstance();
            this.BaBStrat = new BaB8();
            this.ThrowStrategy = new Throw202();
            this.attributes = abilities;
            this.Level = 1;
            this.experience = 0;
            this.HPMax = 10 + Attribute.GetAbilityMod(attributes[(int)Attributes.Con]);
            this.HP = HPMax;
            this.BaB = BaBStrat.getBaB(Level);
            this.SavingThrows = ThrowStrategy.getThrows(Level);
            this.weaponProficiencies = new HashSet<string>();
            this.armorProfinciencies = new HashSet<string>();
            weaponProficiencies.Add("simple");
            armorProfinciencies.UnionWith(new string[] { "light", "medium", "shield" });
            castingStat = Attributes.Wis;
            AddSpells(new Spells.ISpell[] { new CureWounds(), new InflictWounds() });
        }

        public override int CastingLevel
        {
            get
            {
                return Level;
            }
        }
    }
}
