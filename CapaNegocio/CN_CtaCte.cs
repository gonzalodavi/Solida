using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_CtaCte
    {
        public static string Insertar(string dnicuit, DateTime fecha, string comprobante, string concepto, decimal debe, decimal haber, decimal vcheque, decimal vefect, decimal vbanco, decimal total, decimal asignado, decimal interes, string asigna,string estado)
        {
            CD_CtaCte Obj = new CD_CtaCte();
            Obj.DniCuit = dnicuit;
            Obj.Fecha = fecha;
            Obj.Comprobante = comprobante;
            Obj.Concepto = concepto;
            Obj.Debe = debe;
            Obj.Haber = haber;
            Obj.ValorCheque = vcheque;
            Obj.ValorEfectivo = vefect;
            Obj.ValorBanco = vbanco;
            Obj.Total = total;
            Obj.Asignado = asignado;
            Obj.Interes = interes;
            Obj.Asigna = asigna;
            Obj.Estado = estado;


            return Obj.Insertar(Obj);
        }

        public static string Modificar(string comprobante, string concepto, decimal vcheque, decimal vefect, decimal vbanco, decimal total, decimal asignado, string asigna)
        {
            CD_CtaCte Obje = new CD_CtaCte();
            Obje.Comprobante = comprobante;
            Obje.Concepto = concepto;
            Obje.ValorCheque = vcheque;
            Obje.ValorEfectivo = vefect;
            Obje.ValorBanco = vbanco;
            Obje.Total = total;
            Obje.Asignado = asignado;
            Obje.Asigna = asigna;

            return Obje.Modificar(Obje);
        }

        public static string AnularRegistroCtaCte(string comprobante, string concepto)
        {
            CD_CtaCte Obj = new CD_CtaCte();
            Obj.Comprobante = comprobante;
            Obj.Concepto = concepto;
            return Obj.ModificarRegistroCtaCte(Obj);
        }

        public DataTable CargaClientes()
        {
            CD_CtaCte Obj = new CD_CtaCte();
            DataTable dt = new DataTable();
            dt = Obj.CargarComboBoxCliente();
            return dt;
        }

        public static DataTable MostrarDetalleCtaCte(string dni,string fecha1, string fecha2,string asigna)
        {
            return new CD_CtaCte().MostrarDetCta(dni,fecha1,fecha2,asigna);
        }

        public static DataTable MostrarDetalleCtaCteCompleto(string dni,string asigna)
        {
            return new CD_CtaCte().MostrarDetCtaCompleto(dni,asigna);
        }

        public Decimal MostrarSaldo(string idcliente)
        {
            CD_CtaCte Obj = new CD_CtaCte();
            decimal saldo = Obj.MostrarSaldo(idcliente);
            return saldo;
        }


        // PROVEEDORES

        public static string InsertarP(string cuit, DateTime fecha, string comprobante, string concepto, decimal debe, decimal haber, decimal vcheque, decimal vefect, decimal vbanco, decimal total, decimal asignado, decimal interes, string asigna, string estado)
        {
            CD_CtaCte Obj = new CD_CtaCte();
            Obj.Cuit = cuit;
            Obj.Fecha = fecha;
            Obj.Comprobante = comprobante;
            Obj.Concepto = concepto;
            Obj.Debe = debe;
            Obj.Haber = haber;
            Obj.ValorCheque = vcheque;
            Obj.ValorEfectivo = vefect;
            Obj.ValorBanco = vbanco;
            Obj.Total = total;
            Obj.Asignado = asignado;
            Obj.Interes = interes;
            Obj.Asigna = asigna;
            Obj.Estado = estado;


            return Obj.InsertarP(Obj);
        }

        public static string AnularRegistroCtaCteP(string comprobante, string concepto)
        {
            CD_CtaCte Obj = new CD_CtaCte();
            Obj.Comprobante = comprobante;
            Obj.Concepto = concepto;
            return Obj.ModificarRegistroCtaCteP(Obj);
        }

        public DataTable CargaProveedores()
        {
            CD_CtaCte Obj = new CD_CtaCte();
            DataTable dt = new DataTable();
            dt = Obj.CargarComboBoxProveedor();
            return dt;
        }

        public static DataTable MostrarDetalleCtaCteP(string cuit, string fecha1, string fecha2)
        {
            return new CD_CtaCte().MostrarDetCtaP(cuit, fecha1, fecha2);
        }

        public static DataTable MostrarDetalleCtaCteCompletoP(string cuit)
        {
            return new CD_CtaCte().MostrarDetCtaCompletoP(cuit);
        }

        public Decimal MostrarSaldoP(string idproveedor)
        {
            CD_CtaCte Obj = new CD_CtaCte();
            decimal saldo = Obj.MostrarSaldoP(idproveedor);
            return saldo;
        }
    }
}
