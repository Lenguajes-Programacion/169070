using System;

namespace Practica1
{
    class Programnombre
    {
        static void Main()
        {
            string Nombre = "Yafar";

            Console.WriteLine("¿Cual es tu nombre?");
            Nombre = Console.ReadLine();
            if (Nombre == "Yafar")
            {
                Console.WriteLine("Hola " + Nombre);

            }
            else
            {
                Console.WriteLine("Usuario no permitido " + Nombre);

            }
            Console.ReadKey();
        }
    }
}