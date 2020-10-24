using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Celsius_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Convert Celsius To Fahrenheit ");
            Console.WriteLine("Enter  Celsius ");
            double cel = Convert.ToDouble(Console.ReadLine());
            double fer = (cel * 9/5) + 32 ;


            Console.WriteLine( cel + " °C = " + fer + " fahrenheit");

            Console.ReadKey();
        }
    }
}
