using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public abstract class D_Conexion
    {
        public SqlConnection conexion;
        private string CadenaConexion = ConfigurationManager.ConnectionStrings["desa"].ConnectionString;
        public D_Conexion()
        {
            try
            {
                conexion = new SqlConnection(CadenaConexion);
                conexion.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
