using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD454_FinalProject.Spells
{
    public class DivineSpell : SpellType
    {
        public bool DidFizzle(Entitys.Entity caster)
        {
            return false;
        }
    }
}
