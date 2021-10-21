using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class CE_DetalleCompras
    {
        public int Cantidad { get; set; }
        public int Producto { get; set; }
        public decimal Importe { get; set; }
        public decimal Iva { get; set; }
        public decimal SubTotal { get; set; }
        public int IdCompras { get; set; }

    }
}
