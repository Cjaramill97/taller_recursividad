using System;

namespace calculate_the_sum
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num1 = 5;
            int cont = Totalnumber(num1);
            Console.WriteLine("Total is: " + cont);
        }
        public static int Totalnumber(int num1)
        {
            int cont;
            if (num1 == 0)
            {
                return 0;
            }
            else
            {
                cont = num1 + Totalnumber(num1 - 1);
            }
            return cont;
        }
    }
}
