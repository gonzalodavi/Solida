using System;
using System.Collections.Generic;
using System.Text;
using CapaEntidades;
using CapaDatos;
using System.Data;


namespace CapaNegocio
{
    public class CN_GenerarComprobanteCompra
    {
        public List<CE_GenerarComprobanteCompra> generarComprobantes { get; private set; }

        public void GenerarComprobantes(int idcompra)
        {
            var comprobantes = new CD_GenerarCompranteCompra();
            var resultado = comprobantes.GenerarComprobantes(idcompra);

            generarComprobantes = new List<CE_GenerarComprobanteCompra>();

            foreach (DataRow fila in resultado.Rows)
            {
                var detallescomprobantes = new CE_GenerarComprobanteCompra()
                {
                    IdCompra = Convert.ToInt32(fila[0]),
                    NumeroCompras = fila[1].ToString(),
                    Fecha = Convert.ToDateTime(fila[2]),
                    Cuit = fila[3].ToString(),
                    Empresa = fila[4].ToString(),
                    Calle = fila[5].ToString(),
                    Nro = Convert.ToInt32(fila[6]),
                    Localidad = fila[7].ToString(),
                    Provincia = fila[8].ToString(),
                    Tel = fila[9].ToString(),
                    Cantidad = Convert.ToInt32(fila[10]),
                    Producto = fila[11].ToString(),
                    Importe = Convert.ToDecimal(fila[12]),
                    Iva = Convert.ToDecimal(fila[13]),
                    Subtotal = Convert.ToDecimal(fila[14])
                };
                generarComprobantes.Add(detallescomprobantes);
            }
        }
    }
}
