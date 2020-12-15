using System;
using System.IO;
using System.Linq;

namespace Sorting
{
    public class SortingDemo
    {
        private bool playing = true;
        private string DataFile = "scores.txt";
        private int[] sortData;
        private int[] originalData;

        private void ReadDataFile()
        {
            if (File.Exists(DataFile)) //checks to see if file exists, then makes char array
            {
                string dataString = File.ReadAllText(DataFile);
                originalData = dataString.Split('\n').Select(int.Parse).ToArray();
            }
        }

        public SortingDemo()
        {
            ReadDataFile();
            sortData = (int[])originalData.Clone();
            DisplayMenu();
        }

        private void DisplayMenu()
        {
            Console.WriteLine("Please select a sort method to demo on the collection");

            while (playing)
            {
                Console.WriteLine("1. Bubble Sort");
                Console.WriteLine("2. Insertion Sort");
                Console.WriteLine("3. Selection Sort");
                Console.WriteLine("4. Heap Sort");
                Console.WriteLine("5. Quick Sort");
                Console.WriteLine("6. Merge Sort");

                Select(int.Parse(Console.ReadKey().KeyChar.ToString()));
            }
        }

        private void Select(int input)
        {
            switch (input)
            {
                case 1:
                    sortData = Bubble.Sort(sortData);
                    break;
                case 2:
                    sortData = Insertion.Sort(sortData);
                    break;
                case 3:
                    sortData = Selection.Sort(sortData);
                    break;
                case 4:
                    sortData = Heap.Sort(sortData);
                    break;
                case 5:
                    break;
                case 6:
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }

            PrintResults();
        }

        private void PrintResults()
        {
            Console.WriteLine("\n\nThe original data set was:\n ");
            foreach (var s in originalData)
                Console.Write(s + " ");

            Console.WriteLine("\n\nThe sorted data set is:\n ");
            foreach (var score in sortData)
                Console.Write(score + " ");

            Console.ReadKey();
        }
    }
}
