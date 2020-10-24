using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_Two_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first variable");
            int a =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second variable");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The variables are "+ a + "  "+ b);
            int x = b;
            int y = a;
            Console.WriteLine("After swap the variables are " + x + "  " + y);
            Console.ReadKey();

        }
    }
}
