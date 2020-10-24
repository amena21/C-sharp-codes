using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_interval
{
    class Program
    {
        static void Main(string[] args)
        {  

           int i,j ;
            Console.WriteLine("Enter the starting number");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the ending number");
            int end = Convert.ToInt32(Console.ReadLine());
            for (i = first; i <= end; i++ )
            {
                int auto = 0;

                for (j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        auto = 1;
                        break;
                    }
                }
                if (auto == 0)
                {
                    Console.WriteLine(i);
                  
                }

            }
            
            Console.ReadKey();

        }
    }
}
