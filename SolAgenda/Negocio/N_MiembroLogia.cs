using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class N_MiembroLogia
    {
        public static List<E_MiembroLogia> ObtenerTodos()
        {
            D_MiembroLogia dao = new D_MiembroLogia();
            return dao.ObtenerTodos();
        }

        public static E_MiembroLogia ObtenerPorId(int idMiembro)
        {
            D_MiembroLogia dao = new D_MiembroLogia();
            return dao.ObtenerPorId(idMiembro);
        }

        public static void Agregar(E_MiembroLogia miembro)
        {
            D_MiembroLogia dao = new D_MiembroLogia();
            dao.Agregar(miembro);
        }

        public static void Editar(E_MiembroLogia miembro)
        {
            D_MiembroLogia dao = new D_MiembroLogia();
            dao.Editar(miembro);
        }

        public static void Borrar(int idMiembro)
        {
            D_MiembroLogia dao = new D_MiembroLogia();
            dao.Borrar(idMiembro);
        }
    }
}
