using System;

namespace Tiendita_de_Armando
{
    class Program
    {
        static void MainMenu()
        {
            string[] productos = { "Leche", "Pan", "Huevo", "Gaseosa", "Cafe", "Miel", "Aceite", "Jabon", "Galleta", "Cereal", "Avena", "Clorox", "Ambientador", "Cerveza", "Desodorante" };
            int[] precios = { 2000, 2500, 200, 4500, 2200, 6000, 3000, 8000, 2000, 800, 7500, 5000, 9000, 6500, 1800, 3500 };
            bool flag = true;
            int valorCompra = 0;
            string[] clientes = { "Juan", "Pedro", "Ana", "Martha", "Manuela", "Miguel", };
            int deudaJuan = 0;


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

            while (flag)
            {
                string myOptions;
                myOptions = Console.ReadLine();
                switch (myOptions)
                {
                    case "1":
                        Console.WriteLine("Catálogo de precios");
                        for (int i = 0; i < productos.Length; i++)
                        {
                            Console.WriteLine(productos[i] + " " + precios[i]);
                        }
                        break;
                    case "2":
                        Console.WriteLine("Ingrese el nombre del producto");
                        string nameP = Console.ReadLine();
                        for (int n = 0; n < productos.Length; n++)
                        {
                            if (productos[n].Equals(nameP))
                            {
                                Console.WriteLine(productos[n] + " tiene un precio de: " + precios[n]);
                            }
                        }
                        break;
                        
                    case "3":
                        Console.WriteLine("Ingrese los productos que va a llevar");
                        string nameQ = Console.ReadLine();
                        for (int n = 0; n < productos.Length; n++)
                        {
                            if (productos[n].Equals(nameQ))
                            {
                                Console.WriteLine("agregado");
                                valorCompra += precios[n];
                            }
                        }

                        break;

                    case "4":
                     Console.WriteLine("La cantidad a pagar es: " + valorCompra);
                        Console.WriteLine("A la cuenta de quién el cobro?");
                        string nameR = Console.ReadLine();
                        for (int n = 0; n < clientes.Length; n++)
                        {
                            if (clientes[n].Equals(nameR))
                            {
                                Console.WriteLine("añadido a la cuenta de: " + nameR);
                                deudaJuan += valorCompra;
                            }
                        }
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
