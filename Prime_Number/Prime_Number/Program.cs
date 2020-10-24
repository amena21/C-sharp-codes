using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 1st number");
            int num = Convert.ToInt32(Console.ReadLine());
         
            int auto = 0;
           
                for (int i =2; i <= num/2; i++)
                {
                    if (num % i == 0)
                    {

                        Console.WriteLine(num + " is not prime number");
                        auto = 1;
                        break;
                    }
                   
                }
             if(auto == 0)
                    {
                        Console.WriteLine(num + " is a prime number");
                    }
          
            Console.ReadKey();
        }
    }
}
