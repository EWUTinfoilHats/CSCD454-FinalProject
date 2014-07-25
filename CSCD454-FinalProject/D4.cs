
namespace CSCD454_FinalProject.Dice
{
    public class D4 : Die
    {
        private static D4 instance = new D4();

        public override int Roll()
        {
            return random.Next(1, 5);
        }

        public static D4 GetInstance()
        {
            return instance;
        }
    }
}
