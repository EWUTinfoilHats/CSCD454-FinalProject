using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Entitys;
using CSCD454_FinalProject.Items;
using CSCD454_FinalProject.UI;

namespace CSCD454_FinalProject.Maze
{
    class MazeTraversal
    {
        public int row { get; protected set; }
        public int col { get; protected set; }

        public Boolean moveUp { get; protected set; }
        public Boolean moveDown { get; protected set; }
        public Boolean moveLeft { get; protected set; }
        public Boolean moveRight { get; protected set; }

        DungeonMaze dungeon;
        IList<Entity> party;


        public MazeTraversal(IList<Entity> party)
        {
            dungeon = new DungeonMaze();
            dungeon.generate();
            row = 0;
            col = 0;
            moveChecks();
            this.party = party;
        }

        public int[] getLocation()
        {
            return new int[2] { row, col};
        }

        public bool AtEnd()
        {
            return row == dungeon.rows - 1 && col == dungeon.cols - 1;
        }

        public IList<Item> move(String direction)
        {
            switch (direction.ToLower())
            {
                case "up":
                    if (moveUp)
                        row--;

                    break;

                case "down":
                    if (moveDown)
                        row++;

                    break;

                case "left":
                    if (moveLeft)
                        col--;

                    break;

                case "right":
                    if (moveRight)
                        col++;

                    break;

                default:
                    break;
            }

            moveChecks();
            return moved();
        }
        
        private IList<Item> moved()
        {
            return dungeon.maze[row, col].onEnter(this.party);
        }

        private void moveChecks()
        {
            moveUp = true;
            moveDown = true;
            moveRight = true;
            moveLeft = true;

            if (row == 0)
                moveUp = false;
            

            if (row == dungeon.rows - 1)
                moveDown = false;

            if (col == 0)
                moveLeft = false;

            if (col == dungeon.cols - 1)
                moveRight = false;
        }

        /// <summary>
        /// This is a bad method that breaks all sorts of rules
        /// </summary>
        /// <param name="ui"></param>
        public void DisplayMaze(UserInteraction ui)
        {
            for (int y = 0; y < dungeon.rows; y++)
            {
                StringBuilder line = new StringBuilder();
                for (int x = 0; x < dungeon.cols; x++)
                {
                    if (y == row && x == col)
                    {
                        line.Append('P');
                    }
                    else if (dungeon.RoomVisited(y, x))
                    {
                        line.Append('O');
                    }
                    else
                    {
                        line.Append('x');
                    }
                }
                ui.PushStringLine(line.ToString());
            }
        }
    }
}
