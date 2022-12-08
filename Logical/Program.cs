using System;
using System.Text;

namespace Logical
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.CheckDivisisibilty();
            Console.WriteLine(Reverse("reverse"));
            Console.WriteLine("Hello World!");
        }
        public static void CheckDivisisibilty()
        {
            for (int i = 1; i < 100; i++)
            {
                if(i % 3 == 0 && i %5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if(i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if( i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
            }
        }
        public static string Reverse(string val)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = val.Length-1; i >=0; i--)
            {
                sb.Append(val[i]);
            }
            return sb.ToString();
        }
    }
}
