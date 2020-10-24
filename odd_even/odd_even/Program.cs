using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odd_even
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number ");
            int num = Convert.ToInt32(Console.ReadLine());
            int div = num % 2;
            if (div == 0)
            {

                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");  
            }    
            Console.ReadKey();
        }
    }
}
