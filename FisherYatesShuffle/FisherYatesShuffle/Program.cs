using System;
using System.IO;

namespace FisherYatesShuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            string DataFile = "data.txt";
            char [] stringOfCharacters = {'A','B','C'}; //default test vals

            if (File.Exists(DataFile)) //checks to see if file exists, then makes char array
            {
                stringOfCharacters = File.ReadAllText(DataFile).ToCharArray();
            }

            Shuffle.DoShuffle(stringOfCharacters); //call shuffle

            //display shuffled results
            foreach(char letter in stringOfCharacters)
                Console.Write(letter);

            Console.ReadLine();
        }
    }
}
