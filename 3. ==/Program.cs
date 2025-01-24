using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("ededi yaz");
            a = int.Parse(Console.ReadLine());
            

            if (a > 0)
            {
                Console.WriteLine("musbetdir");
            }
            else if (a == 0)
            {
                Console.WriteLine("sifirdir");
            }
            else { 
                Console.WriteLine("menfidir"); 
            }
        }
    }
}
