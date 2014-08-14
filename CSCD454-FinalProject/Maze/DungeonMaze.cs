using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Dice;
using CSCD454_FinalProject.Combat;

namespace CSCD454_FinalProject.Maze
{
    class DungeonMaze
    {
        public Room[,] maze
        {
            get;
            protected set;
        }

        public int rows{ get; protected set; }

        public int cols { get; protected set; }

        protected void generate()
        {
            makeMaze();
            fillMaze();
        }

        private Boolean addEncounter()
        {
            int roll = D100.GetInstance().Roll();
            if (roll >= 70)
            {
                return true;
            }

            return false;
        }

        private Room addRoom()
        {
            if (spawn)
            {
                return new Room(true);
            }
            else
            {
                if (addEncounter())
                {
                    return new Room(true);
                }

                return new Room(false);
            }
        }

        private void fillMaze()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    maze[i, j] = addRoom();
                    
                }
            }
        }

        private void makeMaze()
        {
            Random rand = new Random();
            rows = rand.Next(5, 21);
            cols = rand.Next(5, 21);
            maze = new Room[rows, cols];
        }

//Cheat flags=====================================
        private Boolean _spawn = false;
        public Boolean spawn
        {
            get
            {
                return _spawn;
            }
            set
            {
                _spawn = value;
            }
        }
    }
}
