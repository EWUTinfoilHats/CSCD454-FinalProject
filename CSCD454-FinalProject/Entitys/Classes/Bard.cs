using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Dice;
using CSCD454_FinalProject.Items;
using System.Collections;
using CSCD454_FinalProject.Spells;
using CSCD454_FinalProject.Spells.ArcaneSpells;
using CSCD454_FinalProject.Spells.DivineSpells;

namespace CSCD454_FinalProject.Entitys
{
    public class Bard : Player
    {
        public Bard(int[] abilities)
        {
            this.HitDie = D8.GetInstance();
            this.BaBStrat = new BaB8();
            this.ThrowStrategy = new Throw022();
            this.attributes = abilities;
            this.Level = 1;
            this.experience = 0;
            this.HPMax = 10 + Attribute.GetAbilityMod(attributes[(int)Attributes.Con]);
            this.HP = HPMax;
            this.BaB = BaBStrat.getBaB(Level);
            this.SavingThrows = ThrowStrategy.getThrows(Level);
            this.weaponProficiencies = new HashSet<string>();
            this.armorProfinciencies = new HashSet<string>();
            weaponProficiencies.UnionWith(new string[] { "simple", "Longsword", "Rapier", "Sap", "Short Sword", "Shortbow" });
            armorProfinciencies.UnionWith(new string[] { "light", "shield" });
            castingStat = Attributes.Cha;
            AddSpells(new ISpell[] { new AcidSplash(), new BurningHands(), new RayOfFrost(), new CureWounds() });
        }

        public override int CastingLevel
        {
            get
            {
                return Level;
            }
        }

        public override int ArcaneSpellFailureChance
        {
            get
            {
                if(!Armor.GetType().Equals("light"))
                {
                    return base.ArcaneSpellFailureChance;
                }
                return OffHand.ArcaneSpellFailure;
            }
        }
    }
}
