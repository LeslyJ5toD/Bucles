using System;

namespace Ejercicio23bucle
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            {
                int sumatoria = 0; 
                int numero; 


                Console.WriteLine("Ingresa números enteros. El programa se detendrá si la sumatoria es mayor o igual a 100.");
                Console.WriteLine();

                while (sumatoria < 100)
                {
                    Console.Write("Introduce un número: ");
                    numero = Convert.ToInt32(Console.ReadLine()); 

                    sumatoria + = numero; // Acumula la suma

                    Console.WriteLine("Sumatoria actual: " + sumatoria); 
                }

                Console.WriteLine("La sumatoria es mayor o igual a 100. Programa terminado.");
            }
        }

    }
}

