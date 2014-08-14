using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSCD454_FinalProject.Dice;
using CSCD454_FinalProject.Items.Weapons;
using CSCD454_FinalProject.Items;
using CSCD454_FinalProject.Spells;
using CSCD454_FinalProject.Entitys;

namespace Tests
{
    [TestClass]
    public class FinalProjectTests
    {
        [TestMethod]
        public void TestDiceRoll()
        {
            Die d20 = D20.GetInstance();
            bool failed = false;
            for(int i = 0; i < 100; i++)
            {
                int roll = d20.Roll();
                if(roll < 1 || roll > 20)
                {
                    failed = true;
                    break;
                }
            }
            Assert.IsFalse(failed, "Dice rolled out of bounds. should be always within [1-20]");
        }

        [TestMethod]
        public void TestWeaponDamage()
        {
            Weapon longSword = Weapons.longsword;

            bool failed = false;
            for(int i = 0; i < 100; i++)
            {
                int damage = longSword.GetDamageRoll(10, false);
                if(damage < 1 || damage > 8)
                {
                    failed = true;
                    break;
                }
            }
            Assert.IsFalse(failed, "Weapon damage outside of range");
        }

        [TestMethod]
        public void TestWeaponCrits()
        {
            Weapon longsword = Weapons.longsword;

            bool failed = false;
            for(int i = 0; i < 100; i++)
            {
                int damage = longsword.GetCriticalDamageRoll(10, false);
                if(damage < 2 || damage > 16)
                {
                    failed = true;
                    break;
                }
            }
            Assert.IsFalse(failed, "Weapon crit outside of range");

            Weapon heavyPick = Weapons.heavyPick;
            failed = false;
            for(int i = 0; i < 100; i++)
            {
                int damage = heavyPick.GetCriticalDamageRoll(10, false);
                if(damage < 4 || damage > 24)
                {
                    failed = true;
                    break;
                }
            }
            Assert.IsFalse(failed, "Weapon crit outside of range");
        }

        [TestMethod]
        public void TestSpells()
        {
            TestSpell test = new TestSpell();
            Entity caster = new Wizard(new int[] { 10, 10, 10, 10, 10, 10 });
            caster.SetArmor(Armors.halfPlate);
            caster.SetOffHand(Armors.towerShield);
            ArcaneSpell testArcane = new ArcaneSpell();
            DivineSpell testDivine = new DivineSpell();
            bool fizzled = false;
            for(int i = 0; i < 100; i++)
            {
                if(testArcane.DidFizzle(caster))
                {
                    fizzled = true;
                    break;
                }
            }
            Assert.IsTrue(fizzled, "Arcane spells should fizzle");

            fizzled = false;
            for (int i = 0; i < 100; i++)
            {
                if (testDivine.DidFizzle(caster))
                {
                    fizzled = true;
                    break;
                }
            }
            Assert.IsFalse(fizzled, "Divine spells should not fizzle");
        }
    }

    class TestSpell : OffensiveSTSpell
    {
        public TestSpell() : base("Test Spell", 0, 1, new ArcaneSpell())
        {
            DamageDice = new Die[] { D6.GetInstance() };
            DamageBonus = 1;
        }
    }
}
