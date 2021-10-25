using System;
using System.Collections.Generic;


namespace Tiendita
{
   

    public class Storage
    {
        public Dictionary<string, int> Products { get; set; }

        public Storage()
        {
            Products = new Dictionary<string, int>(StringComparer.InvariantCultureIgnoreCase) // Llave por minuscula o mayuscula
            {
                { "Leche", 2000 },
                { "Pan", 2500 },
                { "Huevo", 200 },
                { "Gaseosa", 4500 },
                { "Cafe", 2200 },
                { "Miel", 6000 },
                { "Aceite", 3000 },
                { "Jabon", 8000 },
                { "Galleta", 2000 },
                { "Cereal", 2000 },
                { "Avena", 2500 },
                { "Clorox", 8000 },
                { "Ambientador", 9000 },
                { "Cerveza", 4000 },
                { "Desodorante", 2000 }
            };
        }
    }

    public class Program
    {
        public static void Main()
        {
            Storage storage = new Storage();
            bool flag = true;
            int total = 0;

            Console.WriteLine("Bienvenido a la tiendita de Armando!");
            Console.WriteLine("Ingrese el número de la opción deseada");

            while (flag)
            {
                Console.WriteLine("Opción 1. Catálogo");
                Console.WriteLine("Opción 2. Buscar producto");
                Console.WriteLine("Opción 3. Sumar productos");
                Console.WriteLine("Opción 4. Pagar cuenta");
                Console.WriteLine("Opción 5. Consultar cuenta cliente");
                Console.WriteLine("Opción 6. Actualizar cuenta cliente");
                Console.WriteLine("Opción 7. Informe de ventas");
                Console.WriteLine("Opción 8. Cuentas por pagar");
                Console.WriteLine("Opción 9. Salir");

                string myOptions;
                myOptions = Console.ReadLine();
                switch (myOptions)
                {
                    case "1":

                        break;
                    case "2":
                        
                        break;
                    case "3":
                        
                        break;
                    case "4":

                        break;
                    case "5":
                        
                        break;
                    case "6":
                   
                        break;
                    case "7":
                        
                        break;
                    case "8":

                        break;
                    case "9":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("El número ingresado no se encuentra dentro de las opciones");
                        break;
                }

                Console.WriteLine("Operacion finalizada. Por favor seleccione otra opcion o termine el programa:");
            }
        }
    }
}
