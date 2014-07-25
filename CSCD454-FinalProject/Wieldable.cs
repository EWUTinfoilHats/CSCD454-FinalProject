using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD454_FinalProject.Items
{
    public interface Wieldable
    {
        //does nothing currently use reflection to find actual type
        Wieldable GetBaseWieldable();
    }
}
