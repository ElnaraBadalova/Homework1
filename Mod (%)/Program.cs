using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod____
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            
            Console.WriteLine("ededi daxil et");
            a= int.Parse(Console.ReadLine());
            if (a % 2 == 0 )
            {
                Console.WriteLine("cut eded");

            }
            else { Console.WriteLine("cut eded deyil"); }

        }
    }
}
