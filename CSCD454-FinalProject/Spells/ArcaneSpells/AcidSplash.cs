using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD454_FinalProject.Spells.ArcaneSpells
{
    public class AcidSplash : OffensiveSTSpell
    {
        public AcidSplash() : base("Acid Splash", 0, new ArcaneSpell())
        {
            DamageDice = new Dice.Die[] { Dice.D3.GetInstance() };
        }
    }
}
