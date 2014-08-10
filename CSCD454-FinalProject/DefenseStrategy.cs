using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD454_FinalProject.Entitys
{
    interface DefenseStrategy
    {
        int[] getThrows(int level);
    }
}
