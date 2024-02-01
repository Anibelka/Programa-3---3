using System;

class CDigitos
{
    static void Main(string[] args)
    {
        int numero = Numero("Ingrese un número positivo: ");

        if (numero >= 1 && numero <= 9)
        {
            Console.WriteLine("El número tiene un dígito.");
        }
        else if (numero >= 10 && numero <= 99)
        {
            Console.WriteLine("El número tiene dos dígitos.");
        }
        else
        {
            Console.WriteLine("El número no es válido.");
        }
    }

    static int Numero(string mensaje)
    {
        int num;
        bool esValido;

        do
        {
            Console.WriteLine(mensaje);
            esValido = int.TryParse(Console.ReadLine(), out num);

            if (!esValido)
            {
                Console.WriteLine("\n" + "El valor ingresado no es válido." + "\n" + "Por favor, ingrese un número." + "\n");
            }
        } while (!esValido);

        return num;
    }
}