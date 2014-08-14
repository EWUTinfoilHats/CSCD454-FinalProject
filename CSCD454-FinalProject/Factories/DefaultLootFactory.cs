using System;
using System.Collections.Generic;
using CSCD454_FinalProject.Items;
using CSCD454_FinalProject.Items.Weapons;
using CSCD454_FinalProject.Dice;

namespace CSCD454_FinalProject.Factories
{
    public class DefaultLootFactory : AbstractLootFactory
    {
        private static IList<Weapon> weaponList = new Weapon[] { Weapons.club, Weapons.dagger, Weapons.lightMace, Weapons.heavyMace, Weapons.heavyCrossbow, Weapons.lightCrossbow, Weapons.handaxe, Weapons.shortSword, Weapons.battleaxe, Weapons.longsword, Weapons.heavyPick, Weapons.rapier, Weapons.falchion, Weapons.greataxe, Weapons.greatsword, Weapons.longbow, Weapons.shortbow, Weapons.kama, Weapons.kukri, Weapons.nunchaku, Weapons.bastardSword, Weapons.dwarvenWaraxe };

        private static IList<Armor> armorList = new Armor[] { Armors.paddedArmor, Armors.leatherArmor, Armors.studdedLeatherArmor, Armors.chainShirt, Armors.hideArmor, Armors.scaleMail, Armors.splintMail, Armors.chainmail, Armors.breastplate, Armors.scaleMail, Armors.bandedMail,  Armors.halfPlate, Armors.fullPlate, Armors.buckler, Armors.heavyWoodenShield, Armors.towerShield };

        private static IList<Consumable> minorConsumableList = new Consumable[] { Consumables.minorHarmingPotion, Consumables.minorHealthPotion,  Consumables.minorManaPotion };

        private static IList<Consumable> moderateConsumableList = new Consumable[] { Consumables.moderateManaPotion, Consumables.moderateHealthPotion, Consumables.moderateHarmingPotion };
        

        public IList<Item> GenerateLoot(int CR)
        {
            Die d100 = D100.GetInstance();
            IList<Item> results = new List<Item>();
            int roll = d100.Roll();
            if (roll < 50)
            {

            }
            else if (roll < 80)
            {
                Random rand = new Random();
                roll = rand.Next(1, CR + 1);
                for(int i = 0; i < roll; i++)
                {
                    AddMundane(results);
                }
            }
            else
            {
                Random rand = new Random();
                roll = rand.Next(1, Math.Max(CR / 3, 2));
                for(int i = 0; i < roll; i++)
                {
                    AddMinor(results);
                }
            }
            return results;
        }

        private void AddMundane(IList<Item> results)
        {
            Random rand = new Random();
            int result = rand.Next(1, 101);
            if (result < 34)
            {
                results.Add(new MasterworkArmor(armorList[rand.Next(armorList.Count)]));
            }
            else if (result < 67)
            {
                results.Add(new MasterworkWeapon(weaponList[rand.Next(weaponList.Count)]));
            }
            else
            {
                results.Add(minorConsumableList[rand.Next(minorConsumableList.Count)]);
            }
        }

        private void AddMinor(IList<Item> results)
        {
            Random rand = new Random();
            Die d100 = D100.GetInstance();
            int result = rand.Next(1, 45);
            if (result < 5)
            {
                result = d100.Roll();
                if (result < 81)
                {
                    results.Add(new SimpleArmorEnchantment(armorList[rand.Next(armorList.Count)], 1));
                }
                else if (result < 88)
                {
                    results.Add(new SimpleArmorEnchantment(armorList[rand.Next(armorList.Count)], 2));
                }
                else
                {
                    results.Add(new SimpleArmorEnchantment(armorList[rand.Next(armorList.Count)], 3));
                }
            }
            else if(result < 10)
            {
                result = d100.Roll();
                if (result < 71)
                {
                    results.Add(new SimpleWeaponEnchantment(weaponList[rand.Next(weaponList.Count)], 1));
                }
                else if (result < 86)
                {
                    results.Add(new SimpleWeaponEnchantment(weaponList[rand.Next(weaponList.Count)], 2));
                }
                else
                {
                    results.Add(new ElementalWeaponEnchantment(weaponList[rand.Next(weaponList.Count)]));
                }
            }
            else
            {
                results.Add(moderateConsumableList[rand.Next(moderateConsumableList.Count)]);
            }
        }
    }
}
