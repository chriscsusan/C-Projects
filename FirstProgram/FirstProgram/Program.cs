using System;

namespace FirstProgram
{
    class Program
    {
        static string reverse(string input)
        {
            string output = "";
            char[] temp = input.ToCharArray();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                output += temp[i];
            }

            return output;
        }

        static void Main(string[] args)
        {
            int i = 0;
            //for(i = 0; i<=100; i++)
            //{
            //    Console.WriteLine(i);
            //}
            Console.WriteLine("Hello World");
            Console.WriteLine(reverse("Usher us into the dreaming."));

            Console.ReadLine();

        }
    }
}
