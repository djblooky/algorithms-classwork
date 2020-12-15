namespace Sorting
{
    public static class Quick
    {
        public static int[] Sort(int[] data, int low, int high)
        {
            if (low < high)
            {
                int partIndex = partition(data, low, high);

                //recusrsive sort
                Sort(data, low, partIndex - 1);
                Sort(data, partIndex + 1, high);
            }

            return data;
        }

        private static int partition(int[] data, int low, int high)
        {
            int pivot = data[high];
            int i = (low - 1);

            for (int j = low; j < high; j++)
            {
                if (data[j] < pivot)
                {
                    i++;

                    // swap elements
                    int temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                }
            }

            // swap data[i+1] and pivot
            int temp1 = data[i + 1];
            data[i + 1] = data[high];
            data[high] = temp1;

            return i + 1;
        }

    }
}
