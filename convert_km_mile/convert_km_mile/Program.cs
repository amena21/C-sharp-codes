using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convert_km_mile
{
    class Program
    {
        static void Main(string[] args)
        {
            double one_km = 0.62137119;
            Console.WriteLine("Convert kilometers to miles ");
            Console.WriteLine("Enter the kilometer");
            double km =Convert.ToDouble(Console.ReadLine());
            double mile = one_km * km;
            Console.WriteLine(km + " km is = " + mile + " mile");
            Console.ReadKey();

        }
    }
}
