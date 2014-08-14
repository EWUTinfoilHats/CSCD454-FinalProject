using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Dice;
using CSCD454_FinalProject.Entitys;
using CSCD454_FinalProject.Entitys.Enemies;
using CSCD454_FinalProject.Combat;

namespace CSCD454_FinalProject.EncounterGeneration
{
    class EncounterGen
    {
        private static int[] rollTable = new int[] { 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 5, 5, 5, 5, 5, 5, 6, 6, 7, 7, 8, 8, 8, 8, 8, 8, 8, 8, 9, 9, 9, 9, 10, 10, 10, 10, 10, 10, 11, 11, 12, 12, 12, 12, 13, 13, 13, 13, 14, 14, 14, 14, 15, 15, 16, 16, 16, 16, 16, 16, 17, 17, 17, 17, 17, 17, 18, 18, 18, 18, 19, 19, 19, 19, 20, 20, 21, 21, 22, 22, 23, 23, 23, 23 };
        private static int[] ChallengeRating = new int[] { 1, 1, 1, 1, 1, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, 4, 4 };
        private static int[] EnemyNumbers = new int[] { 6, 6, 6, 4, 1, 6, 1, 1, 12, 4, 4, 1, 1, 1, 1, 1, 8, 6, 6, 4, 4, 1, 1, 1 };//12 represents 2d6 and 8 represents 2d4
        private static List<string> Monster = new List<string> { "DireRat", "FireBeetle", "HumanSkeleton", "GiantCentipede", "SpiderSwarm", "HumanZombie", "Choker", "SkeletalChampion", "Ghouls", "GiantSpider", "Cockatrice", "GelatinousCube", "RustMonster", "Shadow", "Wight", "Stirge", "Darkmantle", "Troglodyte", "Bugbear", "Vargouilles", "GrayOoze", "Mimic", "Ogre" };
        private static D100 percentile = D100.GetInstance();
        private MonsterFactory monsterFactory = new MonsterFactory();
        private int roll;
        private IList<Entity> players;

        public EncounterGen(IList<Entity> playerParty)
        {
            players = playerParty;
        }

        public Encounter GenerateEncounter()
        {
            roll = percentile.Roll();
            Monster initial = monsterFactory.createMonster(Monster[rollTable[roll]]);

            IList<Monster> returnVal = new List<Monster>();
            returnVal.Add(initial);

            for (int i = 0; i < numberHelper(EnemyNumbers[rollTable[roll]]) - 1; i++)
            {
                returnVal.Add(initial.Clone());
            }
            return new Encounter(players, (IList<Entity>)returnVal);
        }


        public int GetCR(string name)
        {
            return ChallengeRating[Monster.IndexOf(name)];
        }

        private int numberHelper(int n) //All "MAGIC" numbers represent number of potential monsters in encounter
        {
            if (n > 1)
            {
                if (n == 4)
                {
                    D4 dn = D4.GetInstance();
                    return dn.Roll();
                }
                else if (n == 6)
                {
                    D6 dn = D6.GetInstance();
                    return dn.Roll();
                }
                else if (n == 8)
                {
                    D4 dn = D4.GetInstance();
                    return (dn.Roll() + dn.Roll());
                }
                else if (n == 12)
                {
                    D6 dn = D6.GetInstance();
                    return (dn.Roll() + dn.Roll());
                }
            }
            else
            {
                return 1;
            }

            return 1;
        }
    }
}
