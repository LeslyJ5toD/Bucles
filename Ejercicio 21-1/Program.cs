using System;

class Programa
{
    static void Main()
    {
        Console.WriteLine("Introduce la cantidad de números que desee: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        int positivos = 0;
        int negativos = 0;
        int pares = 0;
        int impares = 0;

        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine($"Introduce el número {i + 1}: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            // Positivos y Negativos
            if (numero > 0)
            {
                positivos++;
            }
            else if (numero < 0)
            {
                negativos++;
            }

            // Pares e Impares
            if (numero % 2 == 0)
            {
                pares++;
            }
            else
            {
                impares++;
            }
        }

        Console.WriteLine($"\nResultados");
        Console.WriteLine($"Positivos: {positivos}");
        Console.WriteLine($"Negativos: {negativos}");
        Console.WriteLine($"Pares: {pares}");
        Console.WriteLine($"Impares: {impares}");
    }
}

