using System;

class Programa
{
    
    static int Sumar(int num1, int num2)
    {
        return num1 + num2;
    }

    static int Multiplicar(int num1, int num2)
    {
        return num1 * num2;
    }

    static void ParOImpar(int numero)
    {
        if (numero % 2 == 0)
        {
            Console.WriteLine($"{numero} es un número par.");
        }
        else
        {
            Console.WriteLine($"{numero} es un número impar.");
        }
    }

    static double ConvertirADOP(double dolares)
    {
        double tasaCambio = 60.56; // Valor del dolar
        return dolares * tasaCambio;
    }

    static void Main()
    {

        Console.Write("Introduce el primer número para sumar y multiplicar: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce el segundo número para sumar y multiplicar: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        int suma = Sumar(numero1, numero2);
        Console.WriteLine($"\nLa suma de {numero1} y {numero2} es: {suma}");

        int multiplicacion = Multiplicar(numero1, numero2);
        Console.WriteLine($"La multiplicación de {numero1} y {numero2} es: {multiplicacion}");

        Console.Write("\nIntroduce un número para verificar si es par o impar: ");
        int numeroParImpar = Convert.ToInt32(Console.ReadLine());
        ParOImpar(numeroParImpar);

        Console.Write("\nIntroduce la cantidad en dólares para convertir a pesos dominicanos: ");
        double dolares = Convert.ToDouble(Console.ReadLine());
        double pesos = ConvertirADOP(dolares);
        Console.WriteLine($"{dolares} dólares equivalen a {pesos} pesos dominicanos.");
    }
}
