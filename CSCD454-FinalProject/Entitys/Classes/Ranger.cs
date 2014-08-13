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
    public class Ranger : Player
    {
        public Ranger(int[] abilities)
        {
            this.HitDie = D10.GetInstance();
            this.BaBStrat = new BaB10();
            this.ThrowStrategy = new Throw220();
            this.attributes = abilities;
            this.Level = 1;
            this.experience = 0;
            this.HPMax = 10 + Attribute.GetAbilityMod(attributes[(int)Attributes.Con]);
            this.HP = HPMax;
            this.BaB = BaBStrat.getBaB(Level);
            this.SavingThrows = ThrowStrategy.getThrows(Level);
            this.weaponProficiencies = new HashSet<string>();
            this.armorProfinciencies = new HashSet<string>();
            weaponProficiencies.UnionWith(new string[] { "simple", "martial" });
            armorProfinciencies.UnionWith(new string[] { "light", "medium", "shield" });
            castingStat = Attributes.Wis;
        }
    }
}
