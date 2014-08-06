using System;


namespace CSCD454_FinalProject.Dice
{
    public abstract class Die
    {
        protected static Random random = new Random();

        public abstract int Roll();
    }
}
