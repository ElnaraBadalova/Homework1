using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.h
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a,b,c uzunluqlarini daxil et");
            double a = double.Parse(Console.ReadLine());
            double b= double.Parse(Console.ReadLine());
            double c= double.Parse(Console.ReadLine());

            if  (a+b >c && a+c>b && b+c>a)
            { Console.WriteLine("ucbucaq"); }
            else
            { Console.WriteLine("ucbucaq deyil"); }
        }
    }
}
