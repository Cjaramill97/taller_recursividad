using System;

namespace alculate_the_sum_of_numbers
{
    public class Program
            {

        public static void Main(String [] args)
        {
          int  num = 12345;
            int total = sumaDigitos( num);
            Console.WriteLine("total" + total);
        }
         public static  int sumaDigitos(int num)
            {
            if (num == 0)
            {
                return 0;
            }
            else;
            return num % 10 + sumaDigitos(num / 10);
            }
       
        }
    }

