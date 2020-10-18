using System;

namespace FisherYatesShuffle
{
    public static class Shuffle
    {
        private static Random rand = new Random();

        public static void DoShuffle(this char[] objects)
        {
            for (int i = objects.Length - 1; i > 0; i--)
            {
                int j = GetRandomNumberBetweenZeroAnd(i);
                objects.SwapValuesAtIndices(i, j);
            }
        }

        private static int GetRandomNumberBetweenZeroAnd(int i)
        {
            return rand.Next(i + 1);
        }

    }
}
