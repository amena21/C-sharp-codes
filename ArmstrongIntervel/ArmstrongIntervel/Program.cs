using System;

namespace ArmstrongIntervel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first intervel number!");
            int first=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the last intervel number!");
            int last = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" The armstrong numbers are ");

            for (int i=first;i<=last;i++)
            {
                int sum = 0;
                int temp=i;
                while(temp>0)
                {
                   
                    int division = temp % 10;
                    int cube = division * division * division;
                    sum += cube;
                    temp /= 10;
                }
                if (i == sum)
                {
                    Console.Write( i + " " );
                }
            }
            Console.ReadKey();
        }
    }
}
