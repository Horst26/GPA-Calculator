using System;
using System.IO;
using System.Collections.Generic;

namespace GPACalc
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Creates path to text file containing user input
            string filepath = @"/home/user/Documents/GPA.txt";

            string fulltext = File.ReadAllText(filepath);

            //Splits all of the inputs into individual values
            string[] split = fulltext.Split(' ');

            List<string> final = new List<string>();

        }
    }
}
