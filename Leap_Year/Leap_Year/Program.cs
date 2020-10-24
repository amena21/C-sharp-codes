using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leap_Year
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int year =Convert.ToInt32(Console.ReadLine());
            int div = year % 4;
            int div1 = year % 100;
            int div2 = year % 400;

            if (div == 0)
            {
                if (div1 == 0)
                {
                    if (div2 == 0)
                    {
                        Console.WriteLine("This is leap year");
                    }
                    else
                    {
                        Console.WriteLine("This is not leap year");
                    }
                }else {
                    Console.WriteLine("This is not leap year");
                }
            }else{
                Console.WriteLine("This is not leap year");
            }
            Console.ReadKey();
        }
    }
}
