using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class N_Logia
    {
        public static List<E_Logia> ObtenerTodos()
        {
            D_Logia dao = new D_Logia();
            return dao.ObtenerTodos();
        }

        public static E_Logia ObtenerPorId(int idLogia)
        {
            D_Logia dao = new D_Logia();
            return dao.ObtenerPorId(idLogia);
        }

        public static void Agregar(E_Logia logia)
        {
            D_Logia dao = new D_Logia();
            dao.Agregar(logia);
        }

        public static void Editar(E_Logia logia)
        {
            D_Logia dao = new D_Logia();
            dao.Editar(logia);
        }

        public static void Borrar(int idLogia)
        {
            D_Logia dao = new D_Logia();
            dao.Borrar(idLogia);
        }
    }
}
