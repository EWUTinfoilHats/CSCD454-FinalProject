using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD454_FinalProject.Dice
{
    class D100 : Die
    {
        private static D100 instance = new D100();

        public override int Roll()
        {
            return random.Next(1, 101);
        }

        public static D100 GetInstance()
        {
            return instance;
        }

        public override string ToString()
        {
            return "D100";
        }
    }
}
