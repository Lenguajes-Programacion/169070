using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Programnombre nombre = new Programnombre();
        Programcalcu calcu = new Programcalcu();
        int Opcion;
        Console.WriteLine("Que programa desea abrir?" , System.Environment.NewLine);
        Console.WriteLine("1-Comprobacion nombre" , System.Environment.NewLine,"2-Calculadora", System.Environment.NewLine, "3-Salir");
        Opcion = Int32.Parse(Console.ReadLine());
        do
        {
            switch (Opcion)
            {
                case 1:
                    nombre.Programnombre();
                    break;
                case 2:
                    calcu.Programcalcu();
                    break;
                default:
                    Console.WriteLine("Selecciona una opcion valida");
                    break;
            }

        } while (Opcion != 3);
    }
}
