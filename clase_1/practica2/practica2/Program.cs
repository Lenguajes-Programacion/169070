using System;
namespace calculadora1
{
    class Program
    {
        static void Main(string[] args)
        {
            string operador;
            int suma, resta, multi, divi, digito1, digito2;
            Console.WriteLine("Realiza una operacion", System.Environment.NewLine, "ingresa el primer digito");
            Console.WriteLine("escribe el primer digito");
            digito1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("escribe un operador");
            operador = Console.ReadLine();
            Console.WriteLine("escribe el segundo digito");
            digito2 = Int32.Parse(Console.ReadLine());

            suma = digito1 + digito2;
            resta = digito1 - digito2;
           multi = digito1 * digito2;
            divi = digito1 / digito2;


            switch (operador)
            {
                case "+" :
                    Console.WriteLine("tu operacion es una suma y el resultado es: " + suma);
                    break;

                case "-":
                    Console.WriteLine("tu operacion es una restay el resultado es: " + resta);
                    break;

                case "*":
                    Console.WriteLine("tu operacion es una multiplicacion y el resultado es: " + multi);
                    break;

                case "/":
                    Console.WriteLine("tu operacion es una divison y el resultado es: " + divi);
                    break;

                default:
                    Console.WriteLine("los argumentos no cuentan con un operador valido:" + operador);
                    break;


            }
            Console.ReadLine();
        }
    }
}
