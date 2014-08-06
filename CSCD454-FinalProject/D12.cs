using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD454_FinalProject.Dice
{
    class D12 : Die
    {
        private static D12 instance = new D12();

        public override int Roll()
        {
            return random.Next(1, 13);
        }

        public static D12 GetInstance()
        {
            return instance;
        }
    }
}
