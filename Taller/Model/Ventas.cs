using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller.Model
{
    internal class Ventas
    {
        public string IdFactura = Guid.NewGuid().ToString();
        public string Vendedor;
        public string Fecha = DateTime.Now.ToString();
        public double Valor;
    }
}
