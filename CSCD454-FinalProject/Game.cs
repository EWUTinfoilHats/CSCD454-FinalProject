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
        
        public Game(UserInteraction ui)
        {
            this.ui = ui;
            
        }


    }
}
