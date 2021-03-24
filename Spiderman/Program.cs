using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


   public class Ejemplo
   {
       public static long fact(int n)
       {
           if (n==1)
               return 1;
               return n * fact (n-1); //Spiderman no salto a b1, se genera la recursividad
       }

        public static void Main()
        {
            int num;
            Console.WriteLine("Introduzca el número de edificio al que salto Spiderman: ");
            num = Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine("Estas son las formas que Spiderman puede saltar al edificio: {0}", fact(num));
            Console.ReadKey();
        }
   }


