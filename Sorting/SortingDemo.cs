using System;
using System.IO;
using System.Linq;

namespace Sorting
{
    public class SortingDemo
    {
        private bool playing = true;
        private string DataFile = "scores.txt";
        private int[] originalScores = { 1, 2, 3 }; //default test vals
        private int[] sortedScores;

        private void ReadDataFile()
        {
            if (File.Exists(DataFile)) //checks to see if file exists, then makes char array
            {
                string dataString = File.ReadAllText(DataFile);
                originalScores = dataString.Split('\n').Select(int.Parse).ToArray();
            }
        }

        public SortingDemo()
        {
            ReadDataFile();
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

        private void Select(int selection)
        {
            switch (selection)
            {
                case 1:
                    sortedScores = Bubble.Sort(originalScores);
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                default:
                    break;
            }

            PrintResults();
        }

        private void PrintResults()
        {
            Console.WriteLine("The original data set was: ");
            foreach (var score in originalScores)
                Console.WriteLine(score + ", ");

            Console.WriteLine("The sorted data set is: ");
            foreach (var score in sortedScores)
                Console.WriteLine(score + ", ");

            Console.ReadKey();
        }
    }
}
