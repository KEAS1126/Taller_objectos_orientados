using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller.service;

namespace Taller.Vista
{
    internal class VistaVenta
    {

        
        public void MenuVenta()
        {
            DetalleFacturaService objDetalle = new();

            string opcion=Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    objDetalle.IngresarDatos();
                    break;
                    
            }
        }

    }
}
