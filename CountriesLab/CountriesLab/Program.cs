using System;
using System.Collections.Generic;
using System.IO;

namespace CountriesLab
{
    class Program
    {
        private static string filePath = "C:\\Users\\Goldy\\Documents\\Visual Studio 2015\\Projects\\CountriesLab\\CountriesLab\\countries.txt";
        private static List<string> countriesList = new List<string>();

        public static void setCountry(string countryName)
        {
            if (!File.Exists(filePath)) {
                File.Create(filePath); 
            }
            StreamWriter sw = new StreamWriter(filePath, true);
            sw.WriteLine(countryName);
            sw.Close();
        }

        public static List<string> getCountries()
        {
            StreamReader sr = new StreamReader(filePath);
            while (!sr.EndOfStream)
            {
                countriesList.Add(sr.ReadLine());
            }
            sr.Close();
            return countriesList;
        }


        static void Main(string[] args)
        {

            List<string> countries = new List<string>();
            string choice = "0";
            string keepGoing = "y";

            while (keepGoing.Equals("y"))
            {
                countries.Clear();
                countries = getCountries();

                Console.WriteLine("\n1 See the list of countries.");
                Console.WriteLine("2 Add a country.");
                Console.WriteLine("3 Exit.\n");

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        foreach(string s in countries)
                        {
                            Console.WriteLine(s);
                        }
                        break;
                    case "2":
                        Console.Write("Enter a country:");
                        setCountry(Console.ReadLine());
                        break;
                    case "3":
                        Console.WriteLine("Happy trails.");
                        keepGoing = "n";
                        break;
                    default:
                        Console.WriteLine("That is not a valid entry.");
                        break;
                }
            }
        }
    }
}
