using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.compare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            double a= double.Parse(Console.ReadLine());
            double b= double.Parse(Console.ReadLine());

            if (a > b)
            { Console.WriteLine("1-ci boyukdur"); }

            else if (a < b)
            { Console.WriteLine("2-ci boyukdur"); }

            else
            {
                Console.WriteLine("beraberdir");
            }
        }
    }
}
