﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller.Model
{
    internal class DetalleFactura
    {
        public string nit= Guid.NewGuid().ToString();
        public string Precio;
        public string Cantidad;
    }
}