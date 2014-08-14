using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Entitys;
using CSCD454_FinalProject.Entitys.Commands;

namespace CSCD454_FinalProject.UI
{
    public interface UserInteraction
    {
        int GetInt();
        int GetIntInRange(int min, int max);
        string GetString();
        void PushStringLine(string s);
        void PushString(string s);
        void DisplayHook();
        void GetTarget(CombatGroup targets);
        Entity GetTarget(IList<Entity> targets);
        EntityCombatCommand GetAction(Entity issuer);
    }
}
