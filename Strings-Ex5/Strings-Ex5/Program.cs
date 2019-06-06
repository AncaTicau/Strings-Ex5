using System;
using System.Text;

namespace Strings_Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            string info = StringReverse("This is a string");

            Console.WriteLine(info);
        }

        //Write a method that reverses a string.

        public static string StringReverse(string input)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                sb.Append(input[i]);
            }

            return sb.ToString();
        }

    }

}
