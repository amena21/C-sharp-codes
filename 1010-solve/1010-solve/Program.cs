using System;

namespace _1010_solve
{
    class Program
    {
        static void Main(string[] args)
        {        
 
            String code = Console.ReadLine();
            String code1 = Console.ReadLine();
            String[] value1 = code.Split(' ');
            int p_code = Convert.ToInt32(value1[0]);
            int unit = Convert.ToInt32(value1[1]);
            float price = Convert.ToSingle(value1[2]);
            String[] value2 = code1.Split(' ');
            int p_code1 = Convert.ToInt32(value2[0]);
            int unit1 = Convert.ToInt32(value2[1]);
            float price1 = Convert.ToSingle(value2[2]);         
            double product = unit * price;
            double product1 = unit1 * price1;
            double total = product + product1;

            Console.WriteLine("VALOR A PAGAR: R$ {0:0.00}", total);
            Console.ReadKey();

        }
    }
}
