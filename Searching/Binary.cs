namespace Searching
{
    public static class Binary
    {
        public static object Search(int[] data, int key)
        {
            int min = 0;
            int max = data.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == data[mid])
                    return ++mid;
                else if (key < data[mid])
                    max = mid - 1;
                else
                    min = mid + 1;
            }
            return null;
        }


    }
}
