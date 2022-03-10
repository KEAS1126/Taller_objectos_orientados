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
            
            List<Producto> productos = new();
            Producto producto = new();
            VistaCliente menuC = new();
            VistaProducto menuP = new();
            VistaVenta menuV = new();
            ///DEBE PODERSE CAMBIAR DE MÓDULO

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
                        menuC.MenuCliente();
                        break;
                    case "2":
                        menuP.MenuProducto(productos,producto);
                        break;

                    case "3":
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