using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generate_Random_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            
            
            Random rnd = new Random();
            
             int num =  rnd.Next(1,20);
            Console.WriteLine(num);
                Console.ReadKey();
            
        }
    }
}
