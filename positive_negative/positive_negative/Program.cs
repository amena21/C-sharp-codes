using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace positive_negative
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            double num = Convert.ToDouble(Console.ReadLine());
            if(num > 0 ){
                Console.WriteLine("The number is Positive");
            }
            else if(num == 0)
            {
               Console.WriteLine("The number is Zero");
            }
            else 
            {
                Console.WriteLine("The number is Negative");
            }
            Console.ReadKey();
        }
    }
}
