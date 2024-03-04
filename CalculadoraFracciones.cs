//CAlCULADORA DE FRACCIONES

using System;

class CalculadoraFracciones
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculadora de Fracciones");
        Console.WriteLine("-------------------------");

    
        Console.Write("Ingrese la primera fracción (numerador/denominador): ");
        string fraccion1 = Console.ReadLine();
        Console.Write("Ingrese el segundo operador (+, -, *, /): ");
        char operador = Convert.ToChar(Console.ReadLine());
        Console.Write("Ingrese la segunda fracción (numerador/denominador): ");
        string fraccion2 = Console.ReadLine();


        string[] partesFraccion1 = fraccion1.Split('/');
        string[] partesFraccion2 = fraccion2.Split('/');
        
        if(partesFraccion1.Length != 2 || partesFraccion2.Length != 2) 
        {
            Console.WriteLine("Formato de fracción incorrecto. Debe ser numerador/denominador.");
            return;
        }

        int numerador1 = Convert.ToInt32(partesFraccion1[0]);
        int denominador1 = Convert.ToInt32(partesFraccion1[1]);
        int numerador2 = Convert.ToInt32(partesFraccion2[0]);
        int denominador2 = Convert.ToInt32(partesFraccion2[1]);

        
        switch (operador)
        {
            case '+':
                SumarFracciones(numerador1, denominador1, numerador2, denominador2);
                break;
            case '-':
                RestarFracciones(numerador1, denominador1, numerador2, denominador2);
                break;
            case '*':
                MultiplicarFracciones(numerador1, denominador1, numerador2, denominador2);
                break;
            case '/':
                DividirFracciones(numerador1, denominador1, numerador2, denominador2);
                break;
            default:
                Console.WriteLine("Operador no válido.");
                break;
        }
    }

    static void SumarFracciones(int numerador1, int denominador1, int numerador2, int denominador2)
    {
        int numeradorResultado = numerador1 * denominador2 + numerador2 * denominador1;
        int denominadorResultado = denominador1 * denominador2;
        Console.WriteLine($"El resultado de la suma es: {numeradorResultado}/{denominadorResultado}");
    }

    static void RestarFracciones(int numerador1, int denominador1, int numerador2, int denominador2)
    {
        int numeradorResultado = numerador1 * denominador2 - numerador2 * denominador1;
        int denominadorResultado = denominador1 * denominador2;
        Console.WriteLine($"El resultado de la resta es: {numeradorResultado}/{denominadorResultado}");
    }

    static void MultiplicarFracciones(int numerador1, int denominador1, int numerador2, int denominador2)
    {
        int numeradorResultado = numerador1 * numerador2;
        int denominadorResultado = denominador1 * denominador2;
        Console.WriteLine($"El resultado de la multiplicación es: {numeradorResultado}/{denominadorResultado}");
    }

    static void DividirFracciones(int numerador1, int denominador1, int numerador2, int denominador2)
    {
        if (numerador2 == 0)
        {
            Console.WriteLine("Error: No se puede dividir entre cero.");
            return;
        }
        int numeradorResultado = numerador1 * denominador2;
        int denominadorResultado = denominador1 * numerador2;
        Console.WriteLine($"El resultado de la división es: {numeradorResultado}/{denominadorResultado}");
    }
}



