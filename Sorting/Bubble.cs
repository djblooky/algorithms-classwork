using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    public static class Bubble
    {

        public static int[] Sort(int[] data)
        {
            bool sorted = false;

            while (!sorted)
            {
                sorted = true;
                for(int i = 0; i < data.Length - 1; i++)
                {
                    if (data[i] < data[i-1]) //if out of order
                    {
                        //swap the values
                        var temp = data[i];
                        data[i] = data[i - 1];
                        data[i - 1] = temp;
                        sorted = false;
                    }
                }

            }
            return data;
        }

    }
}
