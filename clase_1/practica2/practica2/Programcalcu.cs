using System;
namespace calculadora1
{
    class Program
    {
        static void Main(string[] args)
        {
            string operador, operador2;
            string respuesta;
            int suma, resta, multi, digito1, digito2, digito3, suma2, resta2, multi2;
            int res = 0;
            double res2 = 0;

            do { 
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
            double divi = ((double)digito1 / (double)digito2);


            switch (operador)
            {
                case "+":
                    Console.WriteLine("tu operacion es una suma y el resultado es: " + suma);
                    res = suma;
                    break;

                case "-":
                    Console.WriteLine("tu operacion es una restay el resultado es: " + resta);
                    res = resta;
                    break;

                case "*":
                    Console.WriteLine("tu operacion es una multiplicacion y el resultado es: " + multi);
                    res = multi;
                    break;

                case "/":
                    Console.WriteLine("tu operacion es una divison y el resultado es: " + divi);
                    res2 = divi;

                    break;

                default:
                    Console.WriteLine("los argumentos no cuentan con un operador valido:" + operador);
                    break;
            }

            Console.WriteLine("¿quieres utilizar el resultado para otra operacion? si/no");

            respuesta = Console.ReadLine();

            switch (respuesta)
            {
                case "si":
                    Console.WriteLine("que deseas hacer?");
                    Console.WriteLine("suma-------------- +");
                    Console.WriteLine("resta------------- -");
                    Console.WriteLine("multiplicacion---- *");
                    Console.WriteLine("division---------- /");
                    operador2 = Console.ReadLine();
                    Console.WriteLine("introduce el tercer digito");
                    digito3 = Int32.Parse(Console.ReadLine());


                    switch (operador2)
                    {
                        case "+":
                            suma2 = res + digito3;
                            Console.WriteLine("tu operacion es una suma y el resultado es: " + suma2);
                            break;

                        case "-":
                            resta2 = res - digito3;
                            Console.WriteLine("tu operacion es una restay el resultado es: " + resta2);
                            break;

                        case "*":
                            multi2 = res * digito3;
                            Console.WriteLine("tu operacion es una multiplicacion y el resultado es: " + multi2);
                            break;

                        case "/":
                            double divi2 = ((double)res2 / (double)digito3);
                            Console.WriteLine("tu operacion es una divison y el resultado es: " + divi2);
                            break;

                        default:
                            Console.WriteLine("los argumentos no cuentan con un operador valido:" + operador);
                            break;

                    }
                    break;

                case "no":
                    Console.WriteLine("Gracias vuelva pronto");
                    break;

                default:
                    Console.WriteLine("escribe bien plis" + operador);
                    break;
            }
            } while (respuesta != "no");
            Console.ReadLine();
        }
    }
}