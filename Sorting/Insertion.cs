using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    public static class Insertion
    {

        public static int[] Sort(int[] data)
        {
            for (int i = 0; i < data.Length - 1; i++)
            {

                for (int j = i+1; j > 0; j--)
                {
                    if (data[j] < data[j-1])
                    {
                        var temp = data[j];
                        data[j] = data[j - 1];
                        data[j - 1] = temp;
                    }
                    else break;
                }
            }

            return data;
        }
    }
}
