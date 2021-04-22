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
            string[] split = fulltext.Split(' ');

            List<string> inputvalues = new List<string>();

            //Adds all of the broken up strings into a list for sorting
            foreach (string input in split)
            {
                string remove = input;
                remove = Regex.Replace(remove, @"\n", " ");
                inputvalues.Add(remove);
            }

            //Setting up processes for use of switch function
            string clean = " ";
            foreach (string i in inputvalues)
            {
                //Checks the grade given and returns a number value
                if (i.Contains("CP") ^ i.Contains("Career"))
                {
                    clean = Regex.Replace(i, "CP", "");
                    clean = Regex.Replace(clean, "Career", "");
                    switch (clean)
                    {
                        case "A ":
                            Console.WriteLine("Case 1");
                            break;
                        case "B ":
                            Console.WriteLine("Case 2");
                            break;
                        case "C ":
                            Console.WriteLine("Case 3");
                            break;
                        case "D ":
                            Console.WriteLine("Case 4");
                            break;
                        case "F ":
                            Console.WriteLine("Case 5");
                            break;
                        default:
                            break;
                    }
                }
                else if (i.Contains("Honors"))
                {
                    clean = Regex.Replace(i, "Honors", "");
                    switch (clean)
                    {
                        case "A ":
                            Console.WriteLine("Case 1");
                            break;
                        case "B ":
                            Console.WriteLine("Case 2");
                            break;
                        case "C ":
                            Console.WriteLine("Case 3");
                            break;
                        case "D ":
                            Console.WriteLine("Case 4");
                            break;
                        case "F ":
                            Console.WriteLine("Case 5");
                            break;
                        default:
                            break;
                    }
                }
                else if (i.Contains("AP"))
                {
                    clean = Regex.Replace(i, "AP", "");
                    switch (clean)
                    {
                        case "A ":
                            Console.WriteLine("Case 1");
                            break;
                        case "B ":
                            Console.WriteLine("Case 2");
                            break;
                        case "C ":
                            Console.WriteLine("Case 3");
                            break;
                        case "D ":
                            Console.WriteLine("Case 4");
                            break;
                        case "F ":
                            Console.WriteLine("Case 5");
                            break;
                        default:
                            break;
                    }
                }
                else if (i.Contains("AP+"))
                {
                    clean = Regex.Replace(i, "AP+", "");
                    switch (clean)
                    {
                        case "A ":
                            Console.WriteLine("Case 1");
                            break;
                        case "B ":
                            Console.WriteLine("Case 2");
                            break;
                        case "C ":
                            Console.WriteLine("Case 3");
                            break;
                        case "D ":
                            Console.WriteLine("Case 4");
                            break;
                        case "F ":
                            Console.WriteLine("Case 5");
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}