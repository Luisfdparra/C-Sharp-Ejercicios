//DIAS Y SEMANAS

using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese su edad:");
        int edad = Convert.ToInt32(Console.ReadLine());

        int dias = edad * 365; // Se asume que cada año tiene 365 días
        int semanas = edad * 52; // Se asume que cada año tiene 52 semanas

        // Contar los días adicionales de los años bisiestos
        int aniosBisiestos = edad / 4; // Asumiendo que los años bisiestos son cada 4 años
        dias += aniosBisiestos; // Sumar un día por cada año bisiesto

        Console.WriteLine($"Han transcurrido aproximadamente {dias} días desde su nacimiento.");
        Console.WriteLine($"Han transcurrido aproximadamente {semanas} semanas desde su nacimiento.");
    }
}

