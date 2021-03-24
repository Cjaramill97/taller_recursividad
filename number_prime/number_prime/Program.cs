using System;

namespace numerosPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
            //número a evaluar
            int n = 5;
            //variable auxiliar para guardar el resultado de la evaluacion
            Boolean esPrimo = true;

            //se divide el numero n entre todos los numeros anteriores
            for (int i = 2; i < n; i++)
            {
                //si el modulo de la division es 0 entonces el numero no es primo
                //se marca la variable esPrimo como false y se termina el for
                if (n % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            }
            // si la variable esPrimo es true entonces es un numero primo
            if (esPrimo)
            {
                Console.WriteLine("Es primo");
            }
        }
    }
}


