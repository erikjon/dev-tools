using System;

namespace devutils
{
    public class PseudoRandomNumberGenerator
    {
        static Random random;

        static PseudoRandomNumberGenerator()
        {
            random = new Random((int)DateTime.UtcNow.Ticks / 2048);
        }

        public static int Next()
        {
            return random.Next();
        }

        public static int Next(int maxValue)
        {
            return random.Next(maxValue);
        }

        public static int Next(int minValue, int maxValue)
        {
            return random.Next(minValue, maxValue);
        }
    }
}
