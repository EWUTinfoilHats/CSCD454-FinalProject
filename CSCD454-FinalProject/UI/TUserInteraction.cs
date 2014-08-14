using CSCD454_FinalProject.Combat.Commands;
using CSCD454_FinalProject.Entitys;
using CSCD454_FinalProject.Entitys.Commands;
using System;
using System.Collections.Generic;

namespace CSCD454_FinalProject.UI
{
    public class TUserInteraction : UserInteraction
    {

        public int GetInt()
        {
            int value;
            string line = Console.ReadLine();
            while(!Int32.TryParse(line, out value))
            {
                Console.Write("Please enter a valid integer number: ");
                line = Console.ReadLine();
            }
            return value;
        }

        public string GetString()
        {
            return Console.ReadLine();
        }

        public virtual void PushString(string s)
        {
            Console.WriteLine(s);
        }

        public virtual void DisplayHook()
        {
            
        }

        public virtual void GetTarget(CombatGroup targets)
        {
            int i = 1;
            Console.WriteLine("\nPlayer Party:");
            foreach(var e in targets.Players)
            {
                Console.WriteLine(i++ + ": " + e.Description);
            }

            Console.WriteLine("\nMonsters:");
            foreach(var e in targets.Monsters)
            {
                Console.WriteLine(i++ + ": " + e.Description);
            }
            Console.Write("Please enter the number corresponsing to your target: ");
            int selection = GetIntInRange(1, i-1);
            while (targets[selection].IsDead())
            {
                Console.Write("Please ensure your target is alive. ");
                selection = GetIntInRange(1, i-1);
            }
            targets.SetTarget(targets[selection]);
        }

        public virtual EntityCommand GetAction(Entity issuer)
        {
            Console.WriteLine("1: Attack");
            Console.WriteLine("2: Cast Spell");
            Console.WriteLine("3: Consumables");
            Console.Write("Please enter a number matching your choice: ");
            int selection = GetIntInRange(1, 3);
            switch(selection)
            {
                case 1:
                    return new AttackCommand(issuer);

                case 2:
                    int i = 1;
                    foreach (var spell in issuer.SpellList)
                    {
                        Console.WriteLine(i++ + ": " + spell.Description);
                    }
                    Console.WriteLine("0: Go back to action selection.");
                    Console.Write("Please enter a number matching your choice: ");
                    int choice = GetIntInRange(0, i - 1);
                    if (choice == 0)
                        return GetAction(issuer);
                    return new CastSpellCommand(issuer, issuer.SpellList[choice]);

                case 3:
                    i = 1;
                    foreach (var cons in issuer.Consumables)
                    {
                        Console.WriteLine(i++ + ": " + cons.Description);
                    }
                    Console.WriteLine("0: Go back to action selection.");
                    Console.Write("Please enter a number matching your choice: ");
                    choice = GetIntInRange(0, i - 1);
                    if (choice == 0)
                        return GetAction(issuer);
                    return new UseItemCommand(issuer, issuer.Consumables[choice]);

                default:
                    return new AttackCommand(issuer);
            }
        }

        /// <summary>
        /// Range is inclusive
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public virtual int GetIntInRange(int min, int max)
        {
            int selection = GetInt();
            while (selection < min || selection > max)
            {
                Console.Write("Please ensure your number is in the allowable range. ");
                selection = GetInt();
            }
            return selection;
        }
    }
}
