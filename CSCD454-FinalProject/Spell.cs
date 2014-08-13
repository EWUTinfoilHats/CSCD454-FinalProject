using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Entitys;

namespace CSCD454_FinalProject.Spells
{
    public interface Spell
    {
        int Duration
        {
            get;
        }

        int Level
        {
            get;
        }

        int ManaCost
        {
            get;
        }

        string Name
        {
            get;
        }

        void CastAt(CombatGroup targets);
    }
}
