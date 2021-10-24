using System;

namespace Tiendita_de_Armando
{
    class Program
    {
        static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Bienvenido a la tiendita de Armando!");
            Console.WriteLine("");
            Console.WriteLine("Ingrese el número de la opción deseada");
            Console.WriteLine("Opción 1. Buscar producto");
            Console.WriteLine("Opción 2. Sumar productos");
            Console.WriteLine("Opción 3. Pagar cuenta");
            Console.WriteLine("Opción 4. Consultar cuenta cliente");
            Console.WriteLine("Opción 5. Actualizar cuenta cliente");
            Console.WriteLine("Opción 6. Informe de ventas");
            Console.WriteLine("Opción 7. Cuentas por pagar");
            Console.WriteLine("Opción 8. Salir");

            string myOptions;
            myOptions = Console.ReadLine();
                switch (myOptions)
            {
                case "1":
                    Search();
                    break;
                case "2":
                    Summ();
                    break;
                case "3":
                    Pay();
                    break;
                case "4":
                    Consultar();
                    break;
                case "5":
                    Actualizar();
                    break;
                case "6":
                    Informe();
                    break;
                case "7":
                    Deudas();
                    break;
                case "8":
                    Salir();
                    break;
            }
            MainMenu();
        }
       static void Search()
        {
            Console.WriteLine("a");
            Console.ReadLine();
        }
        static void Summ()
        {
            Console.WriteLine("a");
            Console.ReadLine();
        }
        static void Pay()
        {
            Console.WriteLine("a");
            Console.ReadLine();
        }
        static void Consultar()
        {
            Console.WriteLine("a");
            Console.ReadLine();
        }
        static void Actualizar()
        {
            Console.WriteLine("a");
            Console.ReadLine();
        }
        static void Informe()
        {
            Console.WriteLine("a");
            Console.ReadLine();
        }

        static void Deudas()
        {
            Console.WriteLine("a");
            Console.ReadLine();
        }
        static void Salir()
        {
            Console.WriteLine("a");
            Console.ReadLine();
            Environment.Exit(1);
        }
    }
}
