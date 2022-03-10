using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller.Model;
using Taller.service;

namespace Taller.Vista
{
    internal class VistaProducto
    {
        public void MenuProducto(List<Producto> productos,Producto producto)
        {

            ProductoService productoServicio = new ProductoService();
            

          

            while (true)
            {

                Console.WriteLine("--------------------Menu de opciones------------------------");
                Console.WriteLine("1.Crear un producto");
                Console.WriteLine("2.Buscar un producto");
                Console.WriteLine("3.Editar un producto");
                Console.WriteLine("4.Listar un producto");
                Console.WriteLine("5.Activar o desactivar un producto");
                Console.WriteLine("6.Salir del sistema");
                Console.WriteLine("-----------------------------------------------");


                Console.WriteLine("Ingrese una opcion: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":

                        productoServicio.IngresarDatos(productos, producto);
                        break;
                    case "2":
                        productoServicio.BuscarDatos(productos, producto);
                        break;
                    case "3":
                        productoServicio.ModificarDatos(productos, producto);
                        break;
                    case "4":
                        productoServicio.ListarDatos(productos);
                        break;
                    case "5":
                        productoServicio.ActivarDesactivar(productos, producto);
                        break;
                    case "6":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Error esta opcion no existe");
                        break;


                }
            }


        }
    }
}