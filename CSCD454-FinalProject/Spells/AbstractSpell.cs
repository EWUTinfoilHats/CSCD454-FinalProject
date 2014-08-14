using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD454_FinalProject.Spells
{
    public abstract class AbstractSpell : ISpell
    {
        protected int maxLevel = 0;
        public AbstractSpell(string name, int level, SpellType type)
        {
            Name = name;
            Level = level;
            Type = type;
            ManaCost = 5 + level * 5;
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

        public virtual int GetLevel(Entitys.Entity caster)
        {
            return 1;
        }

        public abstract void CastAt(CombatGroup targets, Entitys.Entity Caster);

        public virtual string Description
        {
            get;
        }
    }
}
