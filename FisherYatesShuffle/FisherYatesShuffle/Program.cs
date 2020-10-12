using System;

namespace FisherYatesShuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            //create example array
            string[] letters = { "B", "A", "C" };

            Shuffle.DoShuffle(letters); //call shuffle

            //display shuffled results
            foreach(string letter in letters)
                Console.Write(letter + " ");

            Console.ReadLine();
        }
    }
}
