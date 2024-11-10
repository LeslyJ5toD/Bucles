using System;

class Programa
{
    static void Main()
    {
        Console.Write("Introduce el número de filas para el patrón triangular: ");
        int filas = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= filas; i++) 
        {
            for (int j = 1; j <= i; j++) 
            {
                Console.Write("*");
            }
            Console.WriteLine(); 
        }
    }
}

