using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Entitys;

namespace CSCD454_FinalProject.Spells
{
    public abstract class Spell
    {
        public int Duration
        {
            get;
            protected set;
        }

        public int Level
        {
            get;
            protected set;
        }

        public int ManaCost
        {
            get;
            protected set;
        }

        public string Name
        {
            get;
            protected set;
        }

        public abstract void CastAt(Entity target);
        public abstract void CastAt(IList<Entity> targets);
    }
}
