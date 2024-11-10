using System;

namespace Ejercicio23bucle
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                int suma = 0;
                int numero;


                Console.WriteLine("Ingrese números enteros para ser sumados. El programa se detendrá si ingresa el numero 0.");
                Console.WriteLine();

                do
                {
                    Console.Write("Introduce un número: ");
                    numero = Convert.ToInt32(Console.ReadLine());
                    suma += numero;
                }
                while (numero != 0);

                Console.WriteLine("\nLa sumatoria de los números ingresados es:" + suma);

            }
        }

    }
}
