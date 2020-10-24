using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larges_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The First Number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The second Number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The third Number");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Show The largest Number");

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine(a +" is the largest Number");
                }
                else
                {
                    Console.WriteLine(c + " is The largest Number");
                }
            }
            else
            {
                Console.WriteLine(b + " is The largest Number");
            }
            Console.ReadKey();

        }
    }
}
