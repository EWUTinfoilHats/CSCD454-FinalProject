

namespace CSCD454_FinalProject.Dice
{
    class D6 : Die
    {
        private static D6 instance = new D6();

        public override int Roll()
        {
            return random.Next(1, 7);
        }

        public static D6 GetInstance()
        {
            return instance;
        }

        public override string ToString()
        {
            return "D6";
        }
    }
}
