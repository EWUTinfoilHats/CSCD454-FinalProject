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
        string GetString();
        void PushString(string s);
        void DisplayHook();
        Entity GetTarget(IList<Entity> targets);
        EntityCommand GetAction(Entity issuer);
    }
}
