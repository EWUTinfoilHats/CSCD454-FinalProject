using CSCD454_FinalProject.Entitys.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Entitys;
using CSCD454_FinalProject.Spells;

namespace CSCD454_FinalProject.Combat.Commands
{
    public class CastSpellCommand : EntityCombatCommand
    {
        private ISpell spell;
        public CastSpellCommand(Entity issuer, ISpell spell) : base(issuer)
        {
            this.spell = spell;
        }

        public override void Do(CombatGroup targets)
        {
            spell.CastAt(targets, issuer);
        }
    }
}
