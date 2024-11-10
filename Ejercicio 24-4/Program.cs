using System;

class Programa
{
    static void Main()
    {
        int suma = 0;

        for (int i = 1; i <= 100; i++)
        {
            suma += i;
        }

        Console.WriteLine($"La suma de los primeros 100 números naturales es: {suma}");
    }
}
