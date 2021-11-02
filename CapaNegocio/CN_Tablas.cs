using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;


namespace CapaNegocio
{
    public class CN_Tablas
    {
        private CD_Tablas objetoCD = new CD_Tablas();

        public DataTable CargarRubros()
        {
            DataTable dt = new DataTable();
            dt = objetoCD.CargaRubros();
            return dt;
        }
        public static string ConsultaRubroExiste(string nombre)
        {
            CD_Tablas Obj = new CD_Tablas();
            string rpta = Obj.ConsultaExisteRubro(nombre);
            return rpta;
        }

        public static string ConsultaMarcaExiste(string nombre)
        {
            CD_Tablas Obj = new CD_Tablas();
            string rpta = Obj.ConsultaExisteMarca(nombre);
            return rpta;
        }

        public static string ConsultaModeloExiste(string nombre)
        {
            CD_Tablas Obj = new CD_Tablas();
            string rpta = Obj.ConsultaExisteModelo(nombre);
            return rpta;
        }
        public static string ConsultaAlicExiste(float nombre)
        {
            CD_Tablas Obj = new CD_Tablas();
            string rpta = Obj.ConsultaExisteAlic(nombre);
            return rpta;
        }

        public DataTable CargarAlicuotas()
        {
            DataTable dt = new DataTable();
            dt = objetoCD.CargaAlicuotas();
            return dt;
        }

        public DataTable CargarMarcas()
        {
            DataTable dt = new DataTable();
            dt = objetoCD.CargaMarcas();
            return dt;
        }

        public DataTable CargarModelos()
        {
            DataTable dt = new DataTable();
            dt = objetoCD.CargaModelos();
            return dt;
        }

        public void EliminarRubro(string id)
        {
            objetoCD.EliminaRubro(Convert.ToInt32(id));
        }

        public void EliminarAlicuota(string id)
        {
            objetoCD.EliminaAlicuota(Convert.ToInt32(id));
        }

        public void EliminarModelo(string id)
        {
            objetoCD.EliminaModelo(Convert.ToInt32(id));
        }

        public void EliminarMarca(string id)
        {
            objetoCD.EliminaMarca(Convert.ToInt32(id));
        }

        public void NuevoRubro(string rubro)
        {
            objetoCD.AgregaRubro(rubro);
        }

        public void NuevaAlicuota(string alic)
        {
            objetoCD.AgregaAlicuota(Convert.ToDouble(alic));
        }

        public void NuevoModelo(string modelo)
        {
            objetoCD.AgregaModelo(modelo);
        }

        public void NuevaMarca(string marca)
        {
            objetoCD.AgregaMarca(marca);
        }

        public void ModificarRubro(string rubro, string id)
        {
            objetoCD.ModificaRubro(rubro, Convert.ToInt32(id));
        }
        public void ModificarAlicuota(string alic, string id)
        {
            objetoCD.ModificaAlicuota(Convert.ToDouble(alic), Convert.ToInt32(id));
        }
        public void ModificarModelo(string modelo, string id)
        {
            objetoCD.ModificaModelo(modelo, Convert.ToInt32(id));
        }
        public void ModificarMarca(string marca, string id)
        {
            objetoCD.ModificaMarca(marca, Convert.ToInt32(id));
        }
    }
}
