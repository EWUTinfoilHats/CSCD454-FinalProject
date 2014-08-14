using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.UI;
using CSCD454_FinalProject.Entitys;
using CSCD454_FinalProject.Factories;
using CSCD454_FinalProject.Maze;


namespace CSCD454_FinalProject
{
    public class Game
    {
        private UserInteraction ui;
        private DungeonMaze maze;
        private IList<Player> playerParty;
        
        public Game(UserInteraction ui)
        {
            this.ui = ui;
            AbstractCharacterFactory charFactory = new DefaultCharacterFactory();
            playerParty = new List<Player>();
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine(@"The list of classes that are in the game are:
Barbarian
Bard
Cleric
Druid
Fighter
Monk
Paladin
Ranger
Rogue
Sorcer
Wizard");
                Console.Write("Please enter the name of the class you would like to add to your party: ");
                string ans = Console.ReadLine().Split()[0].Trim();
                playerParty.Add(charFactory.CreateCharacter(ans, ui));
            }
            maze = new DungeonMaze();
            //Invoke maze generation once it is in
        }

        public void Play()
        {
            
        }

    }
}
