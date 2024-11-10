using System;

class Programa
{
    static void Main()
    {
        int suma = 0;
        int cantidad = 100;

        for (int i = 1; i <= cantidad; i++)
        {
            suma += i;
        }

        double promedio = (double)suma / cantidad;

        Console.WriteLine($"El promedio de los primeros 100 números naturales es: {promedio}");
    }
}
