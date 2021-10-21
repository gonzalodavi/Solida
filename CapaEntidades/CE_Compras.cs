using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class CE_Compras
    {
        public int IdCompras { get; set; }
        public string NumeroCompras { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public string Cuit { get; set; }  
    }
}
