using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD454_FinalProject.Entitys.Commands
{
    public class AttackCommand : EntityCommand
    {
        public AttackCommand(Entity issuer) : base(issuer)
        {

        }

        public override void Do(CombatGroup targets)
        {
            issuer.Attack(targets.Target);
        }
    }
}
