internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(" Kevin Morataya \n IVC \n 24");
        int f = 3;
        int c = 5;
        int i = 0; int j = 0;
        int[,] matriz = new int[3, 5];

        for (i = 0; i < f; i++)
        {
            for (j = 0; j < c; j++)
            {
                Console.WriteLine("Ingrese el número que quieres guardar en la Fila: " + i + ", Columna: " + j + " = ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
        for (i = 0; i < f; i++)

        {
            for (j = 0; j < c; j++)

            {
                Console.WriteLine("Fila: " + i + ", Columna: " + j + " = " + matriz[i, j]);

            }



        }


    }
}
