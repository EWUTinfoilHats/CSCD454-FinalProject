using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD454_FinalProject.Entitys
{
    class Throw020 : Throws, DefenseStrategy
    {
        public int[] getThrows(int level)
        {
            return new int[] { this.Zero[level], this.Two[level], this.Zero[level] };
        }
    }
}
