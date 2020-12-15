namespace Sorting
{
    public static class Heap
    {
        public static int[] Sort(int[] data)
        {
            int n = data.Length;

            //turn the array into a heap
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                MakeHeap(data, n, i);
            }

            for (int i = n - 1; i >= 0; i--)
            {
                int temp = data[0];
                data[0] = data[i];
                data[i] = temp;
                MakeHeap(data, i, 0);
            }

            return data;
        }

        private static void MakeHeap(int[] data, int n, int i)
        {
            int max = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && data[left] > data[max])
                max = left;

            if (right < n && data[right] > data[max])
                max = right;

            if (max != i)
            {
                int temp = data[i];
                data[i] = data[max];
                data[max] = temp;
                MakeHeap(data, n, max);
            }
        }
    }
}
