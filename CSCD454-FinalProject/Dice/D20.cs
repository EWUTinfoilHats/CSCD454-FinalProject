using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD454_FinalProject.Dice
{
    public class D20 : Die
    {
        private static D20 instance = new D20();

        public override int Roll()
        {
            return random.Next(1, 21);
        }

        public static D20 GetInstance()
        {
            return instance;
        }

        public override string ToString()
        {
            return "D20";
        }
    }
}
