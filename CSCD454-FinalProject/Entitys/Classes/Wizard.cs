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
    public class Wizard : Player
    {
        public Wizard(int[] abilities)
        {
            this.HitDie = D6.GetInstance();
            this.BaBStrat = new BaB6();
            this.ThrowStrategy = new Throw002();
            this.attributes = abilities;
            this.Level = 1;
            this.experience = 0;
            this.HPMax = 10 + Attribute.GetAbilityMod(attributes[(int)Attributes.Con]);
            this.HP = HPMax;
            this.BaB = BaBStrat.getBaB(Level);
            this.SavingThrows = ThrowStrategy.getThrows(Level);
            this.weaponProficiencies = new HashSet<string>();
            this.armorProfinciencies = new HashSet<string>();
            weaponProficiencies.UnionWith(new string[] { "Club", "Dagger", "Heavy Crossbow", "Light Crossbow", "Quarterstaff" });
        }
    }
}
