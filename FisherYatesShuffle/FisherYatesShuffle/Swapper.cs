namespace FisherYatesShuffle
{
    public static class Swapper
    {
        public static void SwapValuesAtIndices(this char[] objects, int i, int j)  //swap i and j
        {
            char temp = objects[i];
            objects[i] = objects[j];
            objects[j] = temp;
        }
    }
}
