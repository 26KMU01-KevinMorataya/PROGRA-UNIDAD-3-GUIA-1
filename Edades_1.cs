using System;

class Program
{
    static void Main(string[] args)
    {
        int[] edades = new int[7];
        int contador = 0;

        
        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine("Ingrese la edad de la persona {i + 1}: ");
            edades[i] = int.Parse(Console.ReadLine());
        }

        
        for (int i = 0; i < 7; i++)
        {
            if (edades[i] >= 18)
            {
                contador++;
            }
        }

        Console.WriteLine("\nLa cantidad de personas mayores de edad es: {contador}");
    }
}
