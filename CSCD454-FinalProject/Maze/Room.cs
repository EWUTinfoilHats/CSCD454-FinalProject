using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Combat;
using CSCD454_FinalProject.Entitys;

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

        public Room(Boolean encounter)
        {
            this.hasEncounter = encounter;
        }

        public Boolean hasEncounter
        {
            get;
            protected set;
        }

        public void onEnter(IList<Player> party)
        {
            if (this.hasEncounter)
            {
                //trigger combat
            }
            else
            {
                return;
            }
        }
    }
}
