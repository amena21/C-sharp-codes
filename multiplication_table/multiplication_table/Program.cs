using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication_table
{
    class Program
    {
        static void Main(string[] args)
        {  
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int i=1, b=0;
            int multi = 0;
            Console.WriteLine("Multiplication Table of " + num + " is ");
          
            for (i=1;i<=10;i++)
            {
               multi = num*i;
               
               Console.WriteLine(num + " * " + i + " = " + multi);
               
                
            }
                 
           Console.ReadKey();
        
        }
    }
}
