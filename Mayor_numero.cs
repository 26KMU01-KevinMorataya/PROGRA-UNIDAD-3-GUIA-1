using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = new int[8];

       
        for (int i = 0; i < 8; i++)
        {
            Console.Write("Ingrese el numero entero {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        
        int mayor = numeros[0];
        int posicion = 0;

        
        for (int i = 1; i < 8; i++)
        {
            if (numeros[i] > mayor)
            {
                mayor = numeros[i];
                posicion = i;
            }
        }

        Console.WriteLine("\nEl numero mayor del arreglo es: {mayor}");
        
        Console.WriteLine("Se encuentra en la posicion: {posicion + 1}");
    }
}
