using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = new int[15];
        bool tieneRepetido = false;

        
        for (int i = 0; i < 15; i++)
        {
            Console.Write("Ingrese el numero {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        
        for (int i = 0; i < 14; i++)
        {
            for (int j = i + 1; j < 15; j++)
            {
                if (numeros[i] == numeros[j])
                {
                    tieneRepetido = true;
                    break; 
                }
            }
            if (tieneRepetido) break;
        }

        
        if (tieneRepetido)
        {
            Console.WriteLine("\nExiste al menos un numero repetido.");
        }
        else
        {
            Console.WriteLine("\nNo hay numeros repetidos.");
        }
    }
}
