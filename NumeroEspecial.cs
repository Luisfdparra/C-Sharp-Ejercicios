//NUMERO ESPECIAL

using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número para determinar si es especial:");
        int numero = Convert.ToInt32(Console.ReadLine());

        bool especial = EsEspecial(numero);

        if (especial)
        {
            Console.WriteLine($"El número {numero} es especial.");
        }
        else
        {
            Console.WriteLine($"El número {numero} no es especial.");
        }
    }

    static bool EsEspecial(int numero)
    {

        if (numero % 5 != 0)
        {
            return false;
        }


        if (numero % 2 == 0 || numero % 3 == 0)
        {
            return false;
        }

        return true;
    }
}