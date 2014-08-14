using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Combat;

namespace CSCD454_FinalProject.Maze
{
    class Room
    {
        public Encounter encounter
        {
            get
            {
                return encounter;
            }
            protected set
            {
                encounter = value;
            }
        }

        public Boolean hasEncounter
        {
            get;
            protected set;
        }
    }
}
