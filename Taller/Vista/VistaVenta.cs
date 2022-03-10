using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller.Model;
using Taller.service;

namespace Taller.Vista
{
    internal class VistaVenta
    {

        
        public void MenuVenta(List<Producto> productos, Producto producto)
        {
            DetalleFacturaService objDetalle = new();
            List<Ventas> ventas = new();

            string opcion=Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    objDetalle.IngresarDatos(productos, producto);
                    break;
                    
            }
        }

    }
}
