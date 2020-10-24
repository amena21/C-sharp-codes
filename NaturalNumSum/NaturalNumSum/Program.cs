using System;

namespace NaturalNumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number!");
            int num = Convert.ToInt32(Console.ReadLine());
            int i;
            int sum = 0;
            for (i = 1; i <= num; i++)
            {
               
                sum += i;
               
            }
            Console.WriteLine(" Sum of "+ num + " is "+sum);
            Console.ReadKey();

        }
    }
}
