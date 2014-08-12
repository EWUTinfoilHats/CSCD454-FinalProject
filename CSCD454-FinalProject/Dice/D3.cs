using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD454_FinalProject.Dice
{
    class D3 : Die
    {
        private static D3 instance = new D3();

        public override int Roll()
        {
            return random.Next(1, 4);
        }

        public static D3 GetInstance()
        {
            return instance;
        }

        public override string ToString()
        {
            return "D3";
        }
    }
}
