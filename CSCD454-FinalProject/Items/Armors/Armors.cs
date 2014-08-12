using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD454_FinalProject.Items
{
    public class Armors
    {
        #region Light
        public static readonly Armor noArmor = (Armor)(new Armor()).SetName("No Armor").SetWeight(0).SetPrice(0);

        public static readonly Armor paddedArmor = (Armor)(new Armor()).SetType("light").SetArmorClass(1).SetMaxDexMod(8).SetArmorCheckPenalty(0).SetArcaneSpellFailure(5).SetName("Padded Armor").SetPrice(5).SetWeight(10);

        public static readonly Armor leatherArmor = (Armor)(new Armor()).SetType("light").SetArmorClass(2).SetMaxDexMod(6).SetArcaneSpellFailure(10).SetName("Leather Armor").SetPrice(10).SetWeight(15);

        public static readonly Armor studdedLeatherArmor = (Armor)(new Armor()).SetType("light").SetArmorClass(3).SetMaxDexMod(5).SetArmorCheckPenalty(-1).SetArcaneSpellFailure(15).SetName("Studded Leather Armor").SetPrice(25).SetWeight(20);

        public static readonly Armor chainShirt = (Armor)(new Armor()).SetType("light").SetArmorClass(4).SetMaxDexMod(4).SetArmorCheckPenalty(-2).SetArcaneSpellFailure(20).SetName("Chain Shirt").SetPrice(100).SetWeight(25);
        #endregion
        #region Medium
        public static readonly Armor hideArmor = (Armor)(new Armor()).SetType("medium").SetArmorClass(4).SetMaxDexMod(4).SetArmorCheckPenalty(-3).SetArcaneSpellFailure(20).SetName("Hide Armor").SetPrice(15).SetWeight(25);

        public static readonly Armor scaleMail = (Armor)(new Armor()).SetType("medium").SetArmorClass(5).SetMaxDexMod(3).SetArmorCheckPenalty(-4).SetArcaneSpellFailure(25).SetName("Scale Mail").SetPrice(50).SetWeight(30);

        public static readonly Armor chainmail = (Armor)(new Armor()).SetType("medium").SetArmorClass(6).SetMaxDexMod(2).SetArmorCheckPenalty(-5).SetArcaneSpellFailure(30).SetName("Chainmail").SetPrice(150).SetWeight(40);

        public static readonly Armor breastplate = (Armor)(new Armor()).SetType("medium").SetArmorClass(6).SetMaxDexMod(3).SetArmorCheckPenalty(-4).SetArcaneSpellFailure(25).SetName("Breastplate").SetPrice(200).SetWeight(30);
        #endregion
        #region Heavy
        public static readonly Armor splintMail = (Armor)(new Armor()).SetType("heavy").SetArmorClass(7).SetMaxDexMod(0).SetArmorCheckPenalty(-7).SetArcaneSpellFailure(40).SetName("Splint Mail").SetPrice(200).SetWeight(45);

        public static readonly Armor bandedMail = (Armor)(new Armor()).SetType("heavy").SetArmorClass(7).SetMaxDexMod(1).SetArmorCheckPenalty(-6).SetArcaneSpellFailure(35).SetName("Banded Mail").SetPrice(250).SetWeight(35);

        public static readonly Armor halfPlate = (Armor)(new Armor()).SetType("heavy").SetArmorClass(8).SetMaxDexMod(0).SetArmorCheckPenalty(-7).SetArcaneSpellFailure(40).SetName("Half-Plate").SetPrice(600).SetWeight(50);

        public static readonly Armor fullPlate = (Armor)(new Armor()).SetType("heavy").SetArmorClass(9).SetMaxDexMod(1).SetArmorCheckPenalty(-6).SetArcaneSpellFailure(35).SetName("Full Plate").SetPrice(1500).SetWeight(50);
        #endregion
        #region Shield
        public static readonly Shield buckler = (Shield)(new Shield()).SetArmorClass(1).SetArmorCheckPenalty(-1).SetArcaneSpellFailure(5).SetName("Buckler").SetPrice(5).SetWeight(5);

        public static readonly Shield heavyWoodenShield = (Shield)(new Shield()).SetArmorClass(2).SetArmorCheckPenalty(-2).SetArcaneSpellFailure(15).SetName("Heavy Wooden Shield").SetPrice(7).SetWeight(10);

        public static readonly Shield towerShield = (Shield)(new Shield()).SetArmorClass(4).SetMaxDexMod(2).SetArmorCheckPenalty(-10).SetArcaneSpellFailure(50).SetName("Tower Shield").SetPrice(30).SetWeight(45);
        #endregion
    }
}
