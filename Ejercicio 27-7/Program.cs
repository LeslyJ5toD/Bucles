using System;

class Programa
{
    static void Main()
    {
        Console.Write("Introduce el número para la tabla de multiplicar: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"\nTabla de multiplicar del {numero}:");

        for (int i = 1; i <= 12; i++)
        {
            int resultado = numero * i;
            Console.WriteLine($"{numero} x {i} = {resultado}");
        }
    }
}
