using System;
namespace practicauno
{
    class Program
    {
        //variable de la clase
        static string nombre = "bryan";
        static void Main(string[] args)
        {
            //respondemos el primer argumento
            //condicion se debe cumplir todas las sentencias si utilizamos &&
            //condicion se debe de cumplir cualquier da las dos sentencias
            //tipos de comparacion: > < == >= <=
            if (args[0].Length > 0 && args[0] == nombre)
            {
                Console.WriteLine($"Hello { args[0]}");
            }
            else
            {
                Console.WriteLine("usuario no permitido");
            }
            Console.ReadKey();
        }
    }
}
