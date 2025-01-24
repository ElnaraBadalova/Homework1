using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.ages
{
    internal class Program
    {
        static void Main(string[] args)

        { 
            Console.WriteLine("enter age");
        
            int a = int.Parse(Console.ReadLine());
            

            if (a > 0 && a <= 12)
            {
                Console.WriteLine("child");
            }
            else if (a > 0 && a <= 19 )
            {
                Console.WriteLine("teenager");

            }

           
            else if (a > 19 && a< 150)

                { Console.WriteLine("adult"); }

            else
                    { Console.WriteLine("incorrect age");
            }
        }
    }
}
