using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD454_FinalProject.Spells
{
    public interface SpellType
    {
        bool DidFizzle(Entitys.Entity caster);
    }
}
