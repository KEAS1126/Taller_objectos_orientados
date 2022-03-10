using System;
using System.Collections.Generic;
using System.Linq;
using Taller.Model;
using Taller.Service;
using Taller.Vista;

namespace Taller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Producto producto = new();
            List<Producto> productos = new();

            while (true)
            {
                Console.WriteLine("Marque la opcion para ingresar al menu deseado");
                Console.WriteLine("Opcion 1: Menu cliente");
                Console.WriteLine("Opcion 2: Menu Producto");
                Console.WriteLine("Opcion 3: Salir");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        VistaCliente menuC = new();
                        menuC.MenuCliente();
                        break;
                    case "2":
                        VistaProducto menuP = new();
                        menuP.MenuProducto(productos,producto);
                        break;

                    case "3":
                        VistaVenta menuV = new();
                        menuV.MenuVenta(productos, producto);
                        break;

                    case "4":
                        Console.WriteLine("Gracias por ingresar sapa hijueputa negra asquerosa");
                        Environment.Exit(0);
                        break;


                    default:
                        break;
                }

            }

        }



    }
}