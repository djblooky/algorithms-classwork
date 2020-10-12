using System;

namespace FisherYatesShuffle
{
    public static class Shuffle
    {
        private static Random rand = new Random();

        public static void DoShuffle(this object[] objects)
        {
            for (int i = objects.Length - 1; i > 0; i--)
            {
                Swap(objects, i, GetRandomNumber(i));
            }
        }

        private static void Swap(object[] objects, int i, int j)  //swap i and j
        {
            object temp = objects[i];
            objects[i] = objects[j];
            objects[j] = temp;
        }

        private static int GetRandomNumber(int i)
        {
            return rand.Next(i + 1);
        }

    }
}
