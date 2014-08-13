using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD454_FinalProject.Dice
{
    public class D8 : Die
    {
        private static D8 instance = new D8();

        public override int Roll()
        {
            return random.Next(1, 9);
        }

        public static D8 GetInstance()
        {
            return instance;
        }

        public override string ToString()
        {
            return "D8";
        }
    }
}
