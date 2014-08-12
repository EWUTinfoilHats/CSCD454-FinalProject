using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Dice;

namespace CSCD454_FinalProject.Items.Weapons
{
    class Weapons
    {
        private static readonly Die[] d3 = new Die[] { D3.GetInstance() };
        private static readonly Die[] d4 = new Die[] { D4.GetInstance() };
        private static readonly Die[] d6 = new Die[] { D6.GetInstance() };
        private static readonly Die[] d8 = new Die[] { D8.GetInstance() };
        private static readonly Die[] d10 = new Die[] { D10.GetInstance() };
        private static readonly Die[] d12 = new Die[] { D12.GetInstance() };
        private static readonly Die[] twod4 = new Die[] { D4.GetInstance(), D4.GetInstance() };
        #region Simple
        public static readonly Weapon emptyHand = (Weapon)(new Weapon()).SetDamageDice(new Die[] { D0.GetInstance() }).SetType("simple").SetName("Empty Hand");

        public static readonly Weapon unarmedStrike = (Weapon)(new Weapon()).SetDamageDice(d3).SetLight().SetType("simple").SetName("Unarmed Strike");

//        public static readonly Weapon battleAspergillum = (Weapon)(new Weapon()).SetDamageDice(d6).SetLight().SetType("simple").SetName("Battle Aspergillum").SetPrice(5).SetWeight(4);

//        public static readonly Weapon brassKnuckles = (Weapon)(new Weapon()).SetDamageDice(d3).SetLight().SetType("simple").SetName("Brass Knuckles").SetPrice(1).SetWeight(1);

//        public static readonly Weapon cestus = (Weapon)(new Weapon()).SetDamageDice(d4).SetLight().SetType("simple").SetThreatRange(19).SetName("Cestus").SetPrice(5).SetWeight(1);

        public static readonly Weapon dagger = (Weapon)(new Weapon()).SetDamageDice(d4).SetLight().SetType("simple").SetThreatRange(19).SetName("Dagger").SetPrice(2).SetWeight(1);

//        public static readonly Weapon gauntlet = (Weapon)(new Weapon()).SetDamageDice(d3).SetLight().SetType("simple").SetName("Gauntlet").SetPrice(2).SetWeight(1);

        public static readonly Weapon lightMace = (Weapon)(new Weapon()).SetDamageDice(d6).SetLight().SetType("simple").SetName("Light Mace").SetPrice(5).SetWeight(4);

        public static readonly Weapon punchingDagger = (Weapon)(new Weapon()).SetDamageDice(d4).SetLight().SetType("simple").SetCriticalMultiplier(3).SetName("Punching Dagger").SetPrice(2).SetWeight(1);

        public static readonly Weapon sickle = (Weapon)(new Weapon()).SetDamageDice(d6).SetLight().SetType("simple").SetName("Sickle").SetPrice(6).SetWeight(2);

        public static readonly Weapon spikedGauntlet = (Weapon)(new Weapon()).SetDamageDice(d4).SetLight().SetType("simple").SetName("Spiked Gauntlet").SetPrice(5).SetWeight(1);

//        public static readonly Weapon woodenStake = (Weapon)(new Weapon()).SetDamageDice(d4).SetLight().SetType("simple").SetName("Wooden Stake").SetWeight(1);

        public static readonly Weapon club = (Weapon)(new Weapon()).SetDamageDice(d6).SetType("simple").SetName("Club").SetWeight(3);

        public static readonly Weapon heavyMace = (Weapon)(new Weapon()).SetDamageDice(d8).SetType("simple").SetName("Heavy Mace").SetPrice(12).SetWeight(8);

//        public static readonly Weapon mereClub = (Weapon)(new Weapon()).SetDamageDice(d4).SetType("simple").SetName("Mere Club").SetPrice(2).SetWeight(2);

        public static readonly Weapon morningstar = (Weapon)(new Weapon()).SetDamageDice(d8).SetType("simple").SetName("Morningstar").SetPrice(8).SetWeight(6);

        public static readonly Weapon shortspear = (Weapon)(new Weapon()).SetDamageDice(d6).SetType("simple").SetName("Shortspear").SetPrice(1).SetWeight(3);

//        public static readonly Weapon bayonet = (Weapon)(new Weapon()).SetDamageDice(d6).SetType("simple").Set2H().SetName("Bayonet").SetPrice(5).SetWeight(1);

//        public static readonly Weapon boarSpear = (Weapon)(new Weapon()).SetDamageDice(d8).SetType("simple").Set2H().SetName("Boar Spear").SetPrice(5).SetWeight(8);

        public static readonly Weapon longspear = (Weapon)(new Weapon()).SetDamageDice(d8).SetType("simple").Set2H().SetCriticalMultiplier(3).SetName("Longspear").SetPrice(5).SetWeight(9);

        //TODO doubleweapon support?
        public static readonly Weapon quarterstaff = (Weapon)(new Weapon()).SetDamageDice(d6).SetType("simple").Set2H().SetName("Quarterstaff").SetWeight(4);

        public static readonly Weapon spear = (Weapon)(new Weapon()).SetDamageDice(d8).SetType("simple").Set2H().SetCriticalMultiplier(3).SetName("Spear").SetPrice(2).SetWeight(6);

        public static readonly Weapon dart = (Weapon)(new Weapon()).SetDamageDice(d4).SetType("simple").SetName("Dart").SetPrice(1).SetWeight(1);

        public static readonly Weapon heavyCrossbow = (Weapon)(new Weapon()).SetDamageDice(d10).SetType("simple").Set2H().SetThreatRange(19).SetName("Heavy Crossbow").SetPrice(50).SetWeight(8);

        public static readonly Weapon javelin = (Weapon)(new Weapon()).SetDamageDice(d4).SetType("simple").SetName("Javelin").SetPrice(1).SetWeight(2);

        public static readonly Weapon lightCrossbow = (Weapon)(new Weapon()).SetDamageDice(d8).SetType("simple").Set2H().SetName("Light Crossbow").SetPrice(35).SetWeight(4);
        #endregion

        #region Martial
        public static readonly Weapon lightHammer = (Weapon)(new Weapon()).SetDamageDice(d4).SetLight().SetType("martial").SetLight().SetName("Light Hammer").SetPrice(1).SetWeight(2);

        public static readonly Weapon handaxe = (Weapon)(new Weapon()).SetDamageDice(d6).SetLight().SetType("martial").SetCriticalMultiplier(3).SetName("Handaxe").SetPrice(6).SetWeight(3);

        public static readonly Weapon kukri = (Weapon)(new Weapon()).SetDamageDice(d4).SetLight().SetType("martial").SetThreatRange(18).SetName("Kukri").SetPrice(8).SetWeight(2);

        public static readonly Weapon lightPick = (Weapon)(new Weapon()).SetDamageDice(d4).SetLight().SetType("martial").SetCriticalMultiplier(4).SetName("Light Pick").SetName("Light Pick").SetPrice(4).SetWeight(3);

        public static readonly Weapon starknife = (Weapon)(new Weapon()).SetDamageDice(d4).SetLight().SetType("martial").SetCriticalMultiplier(3).SetName("Starknife").SetPrice(24).SetWeight(3);

        public static readonly Weapon shortSword = (Weapon)(new Weapon()).SetDamageDice(d6).SetLight().SetType("martial").SetThreatRange(19).SetName("Short Sword").SetPrice(10).SetWeight(2);

        public static readonly Weapon battleaxe = (Weapon)(new Weapon()).SetDamageDice(d8).SetType("martial").SetCriticalMultiplier(3).SetName("Battleaxe").SetPrice(10).SetWeight(6);

        public static readonly Weapon longsword = (Weapon)(new Weapon()).SetDamageDice(d8).SetType("martial").SetThreatRange(19).SetName("Longsword").SetPrice(15).SetWeight(4);

        public static readonly Weapon heavyPick = (Weapon)(new Weapon()).SetDamageDice(d6).SetType("martial").SetCriticalMultiplier(4).SetName("Heavy Pick").SetPrice(8).SetWeight(6);

        public static readonly Weapon rapier = (Weapon)(new Weapon()).SetDamageDice(d6).SetType("martial").SetThreatRange(18).SetName("Rapier").SetPrice(20).SetWeight(2);

        public static readonly Weapon falchion = (Weapon)(new Weapon()).SetDamageDice(twod4).SetType("martial").Set2H().SetThreatRange(18).SetName("Falchion").SetPrice(75).SetWeight(8);

        public static readonly Weapon glaive = (Weapon)(new Weapon()).SetDamageDice(d10).SetType("martial").Set2H().SetCriticalMultiplier(3).SetName("Glaive").SetPrice(8).SetWeight(10);

        public static readonly Weapon greataxe = (Weapon)(new Weapon()).SetDamageDice(d12).SetType("martial").Set2H().SetCriticalMultiplier(3).SetName("Greataxe").SetPrice(20).SetWeight(12);

        public static readonly Weapon greatsword = (Weapon)(new Weapon()).SetDamageDice(new Die[] { D6.GetInstance(), D6.GetInstance() }).SetType("martial").Set2H().SetThreatRange(19).SetName("Greatsword").SetPrice(50).SetWeight(8);

        public static readonly Weapon scythe = (Weapon)(new Weapon()).SetDamageDice(twod4).SetType("martial").Set2H().SetCriticalMultiplier(4).SetName("Scythe").SetPrice(18).SetWeight(10);

        public static readonly Weapon longbow = (Weapon)(new Weapon()).SetDamageDice(d8).SetType("martial").Set2H().SetCriticalMultiplier(3).SetName("Longbow").SetPrice(75).SetWeight(3);

        public static readonly Weapon shortbow = (Weapon)(new Weapon()).SetDamageDice(d6).SetType("martial").Set2H().SetCriticalMultiplier(3).SetName("Shortbow").SetPrice(30).SetWeight(2);
        #endregion

        #region Exotic
        public static readonly Weapon kama = (Weapon)(new Weapon()).SetDamageDice(d6).SetType("exotic").SetLight().SetName("Kama").SetPrice(2).SetWeight(2);

        public static readonly Weapon nunchaku = (Weapon)(new Weapon()).SetDamageDice(d6).SetType("exotic").SetLight().SetName("Nunchaku").SetPrice(2).SetWeight(2);

        public static readonly Weapon bastardSword = (Weapon)(new Weapon()).SetDamageDice(d10).SetType("exotic").SetThreatRange(19).SetName("Bastard Sword").SetPrice(35).SetWeight(6);

        public static readonly Weapon dwarvenWaraxe = (Weapon)(new Weapon()).SetDamageDice(d10).SetType("exotic").SetCriticalMultiplier(3).SetName("Dwarven Waraxe").SetPrice(30).SetWeight(8);

        #endregion
    }
}
