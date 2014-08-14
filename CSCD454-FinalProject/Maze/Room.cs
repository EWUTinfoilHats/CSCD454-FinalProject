using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Combat;
using CSCD454_FinalProject.Entitys;
using CSCD454_FinalProject.EncounterGeneration;
using CSCD454_FinalProject.Items;

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

        private Boolean hasEncounter
        {
            get;
            set;
        }

        private Boolean _visited = false;
        private Boolean Visited
        {
            get
            {
                return _visited;
            }
            set
            {
                _visited = value;
            }
        }


        public IList<Item> onEnter(IList<Entity> party)
        {
            if (this.hasEncounter && !Visited)
            {
                Visited = true;
                EncounterGen generator = new EncounterGen(party);
                encounter = generator.GenerateEncounter();
                return encounter.Fight();
            }
            else
            {
                Visited = true;
                return new Item[0];
            }
        }
    }
}
