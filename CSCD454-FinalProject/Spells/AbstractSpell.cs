using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD454_FinalProject.Spells
{
    public abstract class AbstractSpell : ISpell
    {
        public AbstractSpell(string name, int manaCost, int level, SpellType type)
        {

        }

        public int Duration
        {
            get { throw new NotImplementedException(); }
        }

        public int Level
        {
            get;
            private set;
        }

        public int ManaCost
        {
            get;
            private set;
        }

        public string Name
        {
            get;
            private set;
        }

        public SpellType Type
        {
            get;
            private set;
        }

        public abstract void CastAt(CombatGroup targets, Entitys.Entity Caster);
    }
}
