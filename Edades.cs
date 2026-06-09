internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("DATOS ACADEMICOS \n Nombre: Kevin Morataya \n Grado: IVC \n Clave: 24");

        //Crear e inicializar el arreglo
        int[] ep = new int[7];
        int cpm = 0;
        int cpmm = 0;
        int i = 0;

        //Lenar el arreglo
        for (i = 0; i < ep.Length; i++)
        {
            Console.Write("Ingrese la edad de la persona " + (i + 1) + ":  ");
            ep[i] = Convert.ToInt32(Console.ReadLine());
            if (ep[1] >= 18)
            {
                cpm++;

            }
            else cpmm++;


        }

        //Resultado
        Console.WriteLine("\n Cantidad de personas mayores de edad: " + cpm);
        Console.WriteLine("\n Cantidad de personas menores de edad: " + cpmm);
        Console.WriteLine("\n Cantidad de personas menores de edad: " + i);
    }
}
