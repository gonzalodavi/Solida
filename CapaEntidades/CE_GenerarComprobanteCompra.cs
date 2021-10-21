using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class CE_GenerarComprobanteCompra
    {
			public int IdCompra { get; set; }
            public string NumeroCompras { get; set; }
            public DateTime Fecha { get; set; }
            public string Cuit { get; set; }
            public string Empresa { get; set; }
            public string Calle { get; set; }
            public int Nro { get; set; }
            public string Localidad { get; set; }
            public string Provincia { get; set; }
            public string Tel { get; set; }
            public int Cantidad { get; set; }
            public string Producto { get; set; }
            public decimal Importe { get; set; }
            public decimal Iva { get; set; }
            public decimal Subtotal { get; set; }
    }
}
