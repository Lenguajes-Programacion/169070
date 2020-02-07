using System;

namespace practica2
{
    class Program
    {
           //proyecto calculadora
           //se espera recibir los argumentos valor1 (int) valor2 (string)
           //valor3 (int)
           //responder resultado en (int)
        static void Main(string[] args)
        {
            switch (args [1])
                {
                case "+":
                    Console.WriteLine ("es una suma");
                    break;

                    case "-":
                    Console.WriteLine ("es una resta");
                    break;

                    case "*":
                    Console.WriteLine ("es una multiplicacion");
                    break;

                    case "/":
                    Console.WriteLine ("es una divison");
                    break;

                default:
                    Console.WriteLine ("los argumentos no cuentan con un operador valido:" + args[1]);
                    break;
            }
        }
    }
}
