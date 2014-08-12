using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD454_FinalProject.Items
{
    public class Consumables
    {
        public static readonly Consumable minorHealthPotion = (Consumable)(new HealthPotion(1)).SetName("Minor Health Potion").SetPrice(50).SetWeight(1);

        public static readonly Consumable moderateHealthPotion = (Consumable)(new HealthPotion(2)).SetName("Moderate Health Potion").SetPrice(100).SetWeight(1);

        public static readonly Consumable majorHealthPotion = (Consumable)(new HealthPotion(3)).SetName("Major Health Potion").SetPrice(150).SetWeight(1);

        public static readonly Consumable minorManaPotion = (Consumable)(new ManaPotion(1)).SetName("Minor Mana Potion").SetPrice(50).SetWeight(1);

        public static readonly Consumable moderateManaPotion = (Consumable)(new ManaPotion(2)).SetName("Moderate Mana Potion").SetPrice(100).SetWeight(1);

        public static readonly Consumable majorManaPotion = (Consumable)(new ManaPotion(3)).SetName("Major Mana Potion").SetPrice(150).SetWeight(1);

        public static readonly Consumable minorHarmingPotion = (Consumable)(new HarmingPotion(1)).SetName("Minor Harming Potion").SetPrice(50).SetWeight(1);

        public static readonly Consumable moderateHarmingPotion = (Consumable)(new HarmingPotion(2)).SetName("Moderate Harming Potion").SetPrice(100).SetWeight(1);

        public static readonly Consumable majorHarmingPotion = (Consumable)(new HarmingPotion(3)).SetName("Major Harming Potion").SetPrice(150).SetWeight(1);
    }
}
