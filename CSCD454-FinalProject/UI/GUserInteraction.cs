using CSCD454_FinalProject.Entitys;
using CSCD454_FinalProject.Entitys.Commands;
using System;
using System.Collections.Generic;

namespace CSCD454_FinalProject.UI
{
    public class GUserInteraction : UserInteraction
    {

        public int GetInt()
        {
            throw new NotImplementedException();
        }

        public string GetString()
        {
            throw new NotImplementedException();
        }

        public virtual void PushString(string s)
        {
            throw new NotImplementedException();
        }

        public virtual void DisplayHook()
        {
            throw new NotImplementedException();
        }

        public virtual Entity GetTarget(IList<Entity> targets)
        {
            throw new NotImplementedException();
        }

        public virtual EntityCommand GetAction(Entity issuer)
        {
            throw new NotImplementedException();
        }
    }
}
