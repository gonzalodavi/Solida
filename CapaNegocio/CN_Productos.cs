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

        public DataTable MostrarProductoRubros(int idrubro)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarProductosRubros(idrubro);
            return tabla;
        }

        public static int CantidadProductos()
        {
            CD_Productos Obj = new CD_Productos();            
            return Obj.CantidadProducto(); ;
        }

        public static int CantidadRubros()
        {
            CD_Productos Obj = new CD_Productos();
            return Obj.CantidadRubros();
        }

        public static string ConsultaSiExisteProducto(string nombre, int marca, int unid)
        {
            CD_Productos Obj = new CD_Productos();
            string rpta = Obj.ConsultaSiExisteProducto(nombre, marca, unid);
            return rpta;
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

        public DataTable CargarComboBoxUnidades()
        {
            DataTable dt = new DataTable();
            dt = objetoCD.CargarComboBoxUnidMed();
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

        public DataTable BuscarProductosxRubro(string codbar,int rubro)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.BuscarProdxRubro(codbar,rubro);
            return tabla;
        }

        public DataTable BuscarProductosNomxRubro(string nombre,int rubro)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.BuscarProdnomxRubro(nombre,rubro);
            return tabla;
        }


        public void AgregarProducto(string descrip, string codBar, int  rubro, int alic, string costo, string venta, string stock, string stockmin, int modelo, int marca,int unidMed)
        {
            objetoCD.AgregaProducto(descrip, codBar, rubro, alic, Convert.ToDecimal(costo), Convert.ToDecimal(venta), Convert.ToDecimal(stock), Convert.ToDecimal(stockmin), modelo, marca, unidMed);
        }

        public void ModificarProducto(string id,string descrip, string codBar, int rubro, int alic, string costo, string venta, string stock, string stockmin, int modelo, int marca, int unidMed)
        {
            objetoCD.ModificaProducto(Convert.ToInt32(id),descrip, codBar, rubro, alic, Convert.ToDecimal(costo), Convert.ToDecimal(venta), Convert.ToDecimal(stock), Convert.ToDecimal(stockmin), modelo, marca, unidMed);
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
