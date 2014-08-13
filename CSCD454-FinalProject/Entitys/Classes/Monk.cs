using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Dice;
using CSCD454_FinalProject.Items;
using System.Collections;

namespace CSCD454_FinalProject.Entitys
{
    public class Monk : Player
    {
        public Monk(int[] abilities)
        {
            this.HitDie = D8.GetInstance();
            this.BaBStrat = new BaB8();
            this.ThrowStrategy = new Throw222();
            this.attributes = abilities;
            this.Level = 1;
            this.experience = 0;
            this.HPMax = 10 + Attribute.GetAbilityMod(attributes[(int)Attributes.Con]);
            this.HP = HPMax;
            this.BaB = BaBStrat.getBaB(Level);
            this.SavingThrows = ThrowStrategy.getThrows(Level);
            this.weaponProficiencies = new HashSet<string>();
            this.armorProfinciencies = new HashSet<string>();
            this.weaponProficiencies.UnionWith(new string[] { "Club", "Light Crossbow", "Heavy Crossbow", "Dagger", "Handaxe", "Javelin", "Kama", "Nunchaku", "Quarterstaff", "Sai", "Shortspear", "Shuriken", "Siangham", "Sling", "Spear" });
        }

        public override int TouchArmorClass()
        {
            return base.TouchArmorClass() + Attribute.GetAbilityMod(attributes[(int)Attributes.Wis]);
        }
    }
}
