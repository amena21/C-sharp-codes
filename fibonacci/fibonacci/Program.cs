using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int i=1;
            for (i = 0; i <= num;i++)
            {
               

                Console.Write(i);

            }

            Console.ReadKey();
        
        }
    }
}
