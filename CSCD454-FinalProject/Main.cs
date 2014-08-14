using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD454_FinalProject
{
    public class TextUI
    {
        public static void Main(string[] args)
        {
            bool playAgain = false;
            do
            {
                Game game = new Game(new UI.TUserInteraction());
                game.Play();
                Console.Write("Would you like to play again? (y/n): ");
                char result = (char)Console.Read();
                if (result == 'y' || result == 'Y')
                    playAgain = true;
            } while (playAgain);
        }
    }
}
