using System;
using System.IO;
using System.Linq;

namespace Searching
{
    public class SearchingDemo
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

        public SearchingDemo()
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
                Console.WriteLine("1. Linear Search");
                Console.WriteLine("2. Binary Search");
                Console.WriteLine("3. Interpolation Search");

                Select(int.Parse(Console.ReadKey().KeyChar.ToString()));
            }
        }

        private void Select(int input)
        {
            switch (input)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
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
