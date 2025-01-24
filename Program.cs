using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_world
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, world");
            double a = 5;
            double b = 7;
            Console.WriteLine(a+b);
            
            Console.Write("1.eded a=");
            a = double.Parse(Console.ReadLine());
            Console.Write("2.eded b=");
            b = double.Parse(Console.ReadLine());
            Console.Write("a+b=");
            Console.WriteLine(a + b);



            
           
        }
    }
}
