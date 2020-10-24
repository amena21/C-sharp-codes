using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int i=1, b=0;
            int fact=1;
            for (i = 1; i <= num; i++ )
            {

               
              
               fact*=i;
                
            }

         
            Console.WriteLine("Factorial of " + num + " = " + fact);
         
           
            

            Console.ReadKey();
        }
    }
}
