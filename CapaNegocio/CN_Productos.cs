using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaNegocio
{
    public class CN_Productos
    {
        private CD_Productos objetoCD = new CD_Productos();

        public DataTable MostrarProducto()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarProductos();
            return tabla;
        }

        public DataTable CargaComboBoxRubro()
        {
            DataTable dt = new DataTable();
            dt = objetoCD.CargarComboBoxRubros();
            return dt;
        }

        public DataTable CargaComboBoxAlicuota()
        {
            DataTable dt = new DataTable();
            dt = objetoCD.CargarComboBoxAlic();
            return dt;
        }

        public DataTable CargaComboBoxMarca()
        {
            DataTable dt = new DataTable();
            dt = objetoCD.CargarComboBoxMarca();
            return dt;
        }
        public DataTable CargaComboBoxModelo()
        {
            DataTable dt = new DataTable();
            dt = objetoCD.CargarComboBoxModelo();
            return dt;
        }
        public DataTable BuscarProductos(string codbar)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.BuscarProd(codbar);
            return tabla;
        }

        public DataTable BuscarProductosNom(string nombre)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.BuscarProdnom(nombre);
            return tabla;
        }


        public void AgregarProducto(string descrip, string codBar, int  rubro, int alic, string costo, string venta, string stock, string stockmin, int modelo, int marca)
        {
            objetoCD.AgregaProducto(descrip, codBar, rubro, alic, Convert.ToDecimal(costo), Convert.ToDecimal(venta), Convert.ToInt32(stock), Convert.ToInt32(stockmin), modelo, marca);
        }

        public void ModificarProducto(string id,string descrip, string codBar, int rubro, int alic, string costo, string venta, string stock, string stockmin, int modelo, int marca)
        {
            objetoCD.ModificaProducto(Convert.ToInt32(id),descrip, codBar, rubro, alic, Convert.ToDecimal(costo), Convert.ToDecimal(venta), Convert.ToInt32(stock), Convert.ToInt32(stockmin), modelo, marca);
        }

        public void EliminarProducto(string id)
        {
            objetoCD.EliminaProducto(Convert.ToInt32(id));
        }

        public static string ConsultaProductoExisteEnCompra(int id)
        {
            CD_Productos Obj = new CD_Productos();
            string rpta = Obj.ConsultaExisteProductoEnCompra(id);
            return rpta;
        }

        public static string ConsultaProductoExisteEnRemito(int id)
        {
            CD_Productos Obj = new CD_Productos();
            string rpta = Obj.ConsultaExisteProductoEnRemito(id);
            return rpta;
        }

        public static string ConsultaProductoExisteEnVta(int id)
        {
            CD_Productos Obj = new CD_Productos();
            string rpta = Obj.ConsultaExisteProductoEnVta(id);
            return rpta;
        }
    }
}
