using System;

namespace FirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number!");
            int fNum =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Check the armstrong number");
            int newNum = fNum;
            int sum = 0;
            while(newNum>0)
            {
                int Ndiv = newNum % 10;
                int cube = Ndiv * Ndiv * Ndiv;
                sum += cube;
                newNum/=10;

            }
            if (sum == fNum)
            {
                Console.WriteLine(fNum + " is a armstrong number");
            }
            else
            {
                Console.WriteLine(fNum + " is not armstrong number");
            }
            Console.ReadKey();
        }
    }
}
