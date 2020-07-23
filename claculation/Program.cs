using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            int num = Convert.ToInt32(Console.ReadLine());
            double sqr = Math.Sqrt(num);
            Console.WriteLine("The Square Root of" + " " + num + " is" + " " + sqr);
            Console.ReadKey();
        }
    }
}
            
