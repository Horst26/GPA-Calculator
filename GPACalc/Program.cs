using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

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
            string[] split = fulltext.Split('\n');
            List<string> inputvalues = new List<string>();

            //Adds all of the broken up strings into a list for sorting
            foreach (string input in split)
            {
                string remove = input;
                remove = Regex.Replace(remove, " ", "");
                inputvalues.Add(remove);
                Console.WriteLine(remove);
            }

            //Setting up variables for use in the switch function
            string clean = " ";
            int count = -1;
            double gpa = 0;
            foreach (string i in inputvalues)
            {
                //Checks the grade given and returns a number value
                count += 1;
                if (i.Contains("CP") ^ i.Contains("Career"))
                {
                    clean = Regex.Replace(i, "CP", "");
                    clean = Regex.Replace(clean, "Career", "");
                    switch (clean)
                    {
                        case "A":
                            gpa += 4;
                            break;
                        case "B":
                            gpa += 3;
                            break;
                        case "C":
                            gpa += 2;
                            break;
                        case "D":
                            gpa += 1;
                            break;
                        case "F":
                            gpa += 0;
                            break;
                    }
                }
                else if (i.Contains("Honors"))
                {
                    clean = Regex.Replace(i, "Honors", "");
                    switch (clean)
                    {
                        case "A":
                            gpa += 4.5;
                            break;
                        case "B":
                            gpa += 3.5;
                            break;
                        case "C":
                            gpa += 2.5;
                            break;
                        case "D":
                            gpa += 1.5;
                            break;
                        case "F":
                            gpa += 0;
                            break;
                    }
                }
                else if (i.Contains("AP"))
                {
                    clean = Regex.Replace(i, "AP", "");
                    switch (clean)
                    {
                        case "A":
                            gpa += 5;
                            break;
                        case "B":
                            gpa += 4;
                            break;
                        case "C":
                            gpa += 3;
                            break;
                        case "D":
                            gpa += 2;
                            break;
                        case "F":
                            gpa += 0;
                            break;
                    }
                }
                else if (i.Contains("AP+"))
                {
                    clean = Regex.Replace(i, "AP+", "");
                    switch (clean)
                    {
                        case "A":
                            gpa += 5.5;
                            break;
                        case "B":
                            gpa += 4.5;
                            break;
                        case "C":
                            gpa += 3.5;
                            break;
                        case "D":
                            gpa += 2.5;
                            break;
                        case "F":
                            gpa += 0;
                            break;
                    }
                }
            }
            //Printing all of the values added together 
            //and divided by the number of times the function runs
            Console.WriteLine(gpa / count);
        }
    }
}