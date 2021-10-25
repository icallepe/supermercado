using System;
using System.Collections.Generic;
using System.Linq;

namespace Tiendita
{
    public class ClientsManager
    {
        public Dictionary<string, int> Clients { get; set; }

        public ClientsManager()
        {
            // Nombre - Deuda
            Clients = new Dictionary<string, int>(StringComparer.InvariantCultureIgnoreCase) // Llave por minuscula o mayuscula
            {
                { "Juan", 0 },
                { "Pedro", 0 },
                { "Ana", 0 },
                { "Martha", 0 },
                { "Manuela", 0 },
                { "Miguel", 0 }
            };
        }

        public void AddDebtByName(string clientName, int debt, bool forceUpdate = false)
        {
            if (Clients.ContainsKey(clientName)) // Si el cliente existe
            {
                int currentValue = Clients.GetValueOrDefault(clientName);
                currentValue += debt;
                var valueToAdd = forceUpdate ? debt : currentValue;
                Clients[clientName] = valueToAdd;
                Console.WriteLine($"{clientName} tiene una deuda/saldo actual de: {valueToAdd}");
            }
            else
            {
                Console.WriteLine($"El cliente {clientName} no existe.");
            }
        }

        public void GetDebtByName(string clientName)
        {
            if (Clients.ContainsKey(clientName)) // Si el cliente existe
            {
                Console.WriteLine($"{clientName} tiene una deuda de: {Clients.GetValueOrDefault(clientName)}");
            }
            else
            {
                Console.WriteLine($"El cliente {clientName} no existe.");
            }
        }

    }
   

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
                { "Desodorante", 2000 },
                {"coca cola",3000 },
                {"aguardiente",40000 },
                {"cigarrillo", 6000 },
                {"arepa",1200 },
                {"quesito",3500 },
                {"tosatdas",3000 },
                {"jugpo de naranja", 5000 },
                {"canela", 500 },
            };
        }
        public int GetValueByProductName(string productName)
        {
            return Products.GetValueOrDefault(productName);
        }

        public KeyValuePair<string, int> GetProductAtIndex(int index)
        {
            return Products.ElementAt(index);
        }
    }

    public class Program
    {
        public static void Main()
        {
            Storage storage = new Storage();
            ClientsManager clientsManager = new ClientsManager();
            List<string> sellRecords = new List<string>();
            bool flag = true;
            int total = 0;

            Console.WriteLine("-- Bienvenido a la tiendita de Armando! --\n");
            Console.WriteLine("Ingrese el número de la opción deseada\n");

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
                    Console.WriteLine("-- Catálogo de precios --");
                        for (int i = 0; i < storage.Products.Count; i++)
                        {
                            var product = storage.GetProductAtIndex(i);
                            Console.WriteLine($"{product.Key}: {product.Value}");
                        }

                        break;
                    case "2":
                        Console.WriteLine("Ingrese el nombre del producto");
                        string productName = Console.ReadLine();
                        int productValue = storage.GetValueByProductName(productName);

                        if (productValue == 0)
                        {
                            Console.WriteLine($"{productName} no existe");
                        }
                        else
                        {
                            Console.WriteLine($"{productName} tiene un precio de: {productValue}");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Ingrese los productos que va a llevar separados por un espacio");
                        string[] products = Console.ReadLine().Split(" ");

                        for (int n = 0; n < products.Length; n++)
                        {
                            int value = storage.GetValueByProductName(products[n]);
                            total += value;
                            string productSold = $"- {products[n]}: {value}";
                            sellRecords.Add(productSold);
                            Console.WriteLine(productSold);
                        }
                        break;
                    case "4":
                        Console.WriteLine($"La cantidad a pagar es: {total}");
                        Console.WriteLine("A la cuenta de quién el cobro?");
                        string clientName = Console.ReadLine();
                        clientsManager.AddDebtByName(clientName, -total);
                        total = 0;
                        break;

                    case "5":
                        Console.Write($"Ingrese el nombre del cliente: ");
                        string currentClient = Console.ReadLine();
                        clientsManager.GetDebtByName(currentClient);
                        break;

                    case "6":
                        Console.Write("Ingrese el nombre de cliente a actualizar: ");
                        string currentClientName = Console.ReadLine();
                        Console.Write("Ingrese el saldo a actualizar: ");
                        string currentDebt = Console.ReadLine();
                        Console.Write("Descontar de deuda? si/no: ");
                        string forceUpdate = Console.ReadLine().ToLower();
                        bool isForceUpdate = !string.IsNullOrEmpty(forceUpdate) && forceUpdate == "no";
                        clientsManager.AddDebtByName(currentClientName, int.Parse(currentDebt), isForceUpdate);
                        break;
                    case "7":
                        Console.WriteLine("-- Productos vendidos --");
                        foreach (string sellRecord in sellRecords)
                        {
                            Console.WriteLine(sellRecord);
                        }
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

                Console.WriteLine("\nOperacion finalizada. Por favor seleccione otra opcion o termine el programa:\n");
            }
        }
    }
}
