using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class N_GranOriente
    {
        public static List<E_GranOriente> ObtenerTodos()
        {
            D_GranOriente dao = new D_GranOriente();
            return dao.ObtenerTodos();
        }

        public static E_GranOriente ObtenerPorId(int idGranOriente)
        {
            D_GranOriente dao = new D_GranOriente();
            return dao.ObtenerPorId(idGranOriente);
        }

        public static void Agregar(E_GranOriente oriente)
        {
            D_GranOriente dao = new D_GranOriente();
            dao.Agregar(oriente);
        }

        public static void Editar(E_GranOriente oriente)
        {
            D_GranOriente dao = new D_GranOriente();
            dao.Editar(oriente);
        }

        public static void Borrar(int idGranOriente)
        {
            D_GranOriente dao = new D_GranOriente();
            dao.Borrar(idGranOriente);
        }
    }
}
