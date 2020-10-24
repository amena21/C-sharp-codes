using System;

namespace power_of_num
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base number");
            Double basenum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Power number");
            Double pownum = Convert.ToDouble(Console.ReadLine());
            Double number = Math.Pow(basenum,pownum);
            Console.WriteLine(number);
            Console.ReadKey();

        }
        
    }
}
