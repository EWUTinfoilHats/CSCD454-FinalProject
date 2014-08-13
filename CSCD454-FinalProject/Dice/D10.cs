using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD454_FinalProject.Dice
{
    public class D10 : Die
    {
        private static D10 instance = new D10();

        public override int Roll()
        {
            return random.Next(1, 11);
        }

        public static D10 GetInstance()
        {
            return instance;
        }

        public override string ToString()
        {
            return "D10";
        }
    }
}
