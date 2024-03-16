using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class N_Soberania
    {
        public static List<E_Soberania> ObtenerTodos()
        {
            D_Soberania dao = new D_Soberania();
            return dao.ObtenerTodos();
        }

        public static E_Soberania ObtenerPorId(int idSoberania)
        {
            D_Soberania dao = new D_Soberania();
            return dao.ObtenerPorId(idSoberania);
        }

        public static void Agregar(E_Soberania soberania)
        {
            D_Soberania dao = new D_Soberania();
            dao.Agregar(soberania);
        }

        public static void Editar(E_Soberania soberania)
        {
            D_Soberania dao = new D_Soberania();
            dao.Editar(soberania);
        }

        public static void Borrar(int idSoberania)
        {
            D_Soberania dao = new D_Soberania();
            dao.Borrar(idSoberania);
        }
    }
}
