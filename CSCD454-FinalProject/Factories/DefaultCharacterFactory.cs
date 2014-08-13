﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Entitys;
using CSCD454_FinalProject.UI;
using CSCD454_FinalProject.Items.Weapons;
using CSCD454_FinalProject.Items;

namespace CSCD454_FinalProject.Factories
{
    public class DefaultCharacterFactory : AbstractCharacterFactory
    {
        public Player CreateCharacter(string Class, UserInteraction ui)
        {
            Class = Class.ToLower();
            Player newChar;
            switch(Class)
            {
                case "barbarian":
                    newChar = new Barbarian(new int[] { 15, 15, 15, 10, 9, 10 });
                    newChar.SetArmor(Armors.chainShirt);
                    newChar.SetMainHand(Weapons.battleaxe);
                    break;

                case "bard":
                    newChar = new Bard(new int[] { 10, 15, 15, 10, 9, 15 });
                    newChar.SetArmor(Armors.leatherArmor);
                    newChar.SetMainHand(Weapons.rapier);
                    break;

                case "cleric":
                    newChar = new Cleric(new int[] { 15, 10, 15, 15, 9, 10 });
                    newChar.SetArmor(Armors.breastplate);
                    newChar.SetMainHand(Weapons.heavyMace);
                    newChar.SetOffHand(Armors.heavyWoodenShield);
                    break;

                case "druid":
                    newChar = new Druid(new int[] { 15, 10, 15, 15, 9, 10 });
                    newChar.SetArmor(Armors.hideArmor);
                    newChar.SetMainHand(Weapons.club);
                    newChar.SetOffHand(Armors.heavyWoodenShield);
                    break;

                case "fighter":
                    newChar = new Fighter(new int[] { 15, 15, 15, 10, 9, 10 });
                    newChar.SetArmor(Armors.breastplate);
                    newChar.SetMainHand(Weapons.longsword);
                    newChar.SetOffHand(Armors.heavyWoodenShield);
                    break;

                case "monk":
                    newChar = new Fighter(new int[] { 10, 15, 15, 10, 15, 9 });
                    newChar.SetMainHand(Weapons.quarterstaff);
                    break;

                case "paladin":
                    newChar = new Paladin(new int[] { 15, 10, 15, 9, 15, 10 });
                    newChar.SetArmor(Armors.breastplate);
                    newChar.SetMainHand(Weapons.longsword);
                    newChar.SetOffHand(Armors.heavyWoodenShield);
                    break;

                case "ranger":
                    newChar = new Ranger(new int[] { 10, 15, 15, 9, 15, 10 });
                    newChar.SetArmor(Armors.leatherArmor);
                    newChar.SetMainHand(Weapons.longbow);
                    break;

                case "rogue":
                    newChar = new Rogue(new int[] { 10, 15, 15, 15, 9, 10 });
                    newChar.SetArmor(Armors.leatherArmor);
                    newChar.SetMainHand(Weapons.rapier);
                    newChar.SetOffHand(Weapons.shortSword);
                    break;

                case "sorcerer":
                    newChar = new Sorcerer(new int[] { 10, 15, 15, 10, 9, 15 });
                    newChar.SetMainHand(Weapons.lightCrossbow);
                    break;

                case "wizard":
                    newChar = new Wizard(new int[] { 10, 15, 15, 15, 9, 10 });
                    newChar.SetMainHand(Weapons.lightCrossbow);
                    break;

                default:
                    newChar =  new Barbarian(new int[] { 10, 10, 10, 10, 10, 10 });
                    break;
            }
            newChar.SetUI(ui);
            return newChar;
        }
    }
}
