using System;

class Contraseña
{
    static void Main()
    {
        string contraseñaCorrecta = "Lesly"; 
        int intentosMaximos = 3; 
        int intentos = 0;


        while (intentos < intentosMaximos)
        {
            Console.Write("Introduce la contraseña: ");
            string contraseñaIngresada = Console.ReadLine();
            Console.WriteLine();

            if (contraseñaIngresada == "") 
            {
                Console.WriteLine("Error: La contraseña no puede estar vacía.");
                intentos++; 
            }
            else if (contraseñaIngresada == contraseñaCorrecta)
            {
                Console.WriteLine("Contraseña correcta. ¡Acceso concedido!");
                return;
            }
            else
            {
                intentos++;
                Console.WriteLine("Contraseña incorrecta. Intentos restantes: "
                                  + (intentosMaximos - intentos));
            }
        }

        Console.WriteLine("Ha agotado el número de intentos.Sistema bloqueado");
    }
}
