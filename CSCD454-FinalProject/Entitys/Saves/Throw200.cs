using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD454_FinalProject.Entitys
{
    public class Throw200 : Throws, DefenseStrategy
    {
        public int[] getThrows(int level)
        {
            return new int[] { this.Two[level], this.Zero[level], this.Zero[level] };
        }
    }
}
