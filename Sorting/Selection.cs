namespace Sorting
{
    public static class Selection
    {
        public static int[] Sort(int[] data)
        {
            for (int i = 0; i < data.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < data.Length; j++)
                {
                    if (data[j] < data[min])
                    {
                        min = j;
                    }
                }

                //swap min with first element
                int temp = data[min];
                data[min] = data[i];
                data[i] = temp;
            }

            return data;
        }

    }
}
