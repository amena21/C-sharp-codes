using System;

namespace _1011_solve
{
    class Program
    {
        static void Main(string[] args)
        {
            float R = Convert.ToSingle(Console.ReadLine());
            Math.Round(R, 2);
            double pi = 3.14159;
            double volume = 4 / 3.0 * pi * R * R * R;
            Console.WriteLine("VOLUME = {0:0.000}", volume);
            Console.ReadKey();
        }
    }
}
