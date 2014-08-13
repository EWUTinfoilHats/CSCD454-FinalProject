using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD454_FinalProject.Dice
{
    public class D0 : Die
    {
        private static D0 instance = new D0();

        public override int Roll()
        {
            return 0;
        }

        public static D0 GetInstance()
        {
            return instance;
        }

        public override string ToString()
        {
            return "D0";
        }
    }
}
