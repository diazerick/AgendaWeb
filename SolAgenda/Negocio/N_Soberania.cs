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
    }
}
