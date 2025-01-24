using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.h
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ili daxil et");
            int a = int.Parse(Console.ReadLine());

            if (a % 4 ==0 && a % 100 > 0 || a % 400 == 0)
            { Console.WriteLine("leap year"); }

            else 
                    { Console.WriteLine("is not leap year"); }


            
        }

    }
}
