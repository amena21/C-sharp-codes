using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the Hight of Triangle");
            Double Hig = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Base of Triangle");
            Double Bas = Convert.ToDouble(Console.ReadLine());
            Double Area = Convert.ToDouble(0.5 * (Hig * Bas));

            Console.WriteLine("The Are of Triangle is " + Area);
            Console.ReadKey();
        }
    }
}
