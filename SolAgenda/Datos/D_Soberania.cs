using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class D_Soberania
    {
        private string CadenaConexion = ConfigurationManager.ConnectionStrings["desa"].ConnectionString;

        public List<E_Soberania> ObtenerTodos()
        {
            SqlConnection conexion = new SqlConnection(CadenaConexion);
            List<E_Soberania> lista = new List<E_Soberania>();
            try
            {
                conexion.Open();
                string query = "SELECT idSoberania,soberania,responsable,cargo,telefono,correo,direccion FROM soberanias";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    E_Soberania soberania= new E_Soberania();
                    soberania.IdSoberania = Convert.ToInt32(reader["idSoberania"]);
                    soberania.Soberania = reader["soberania"].ToString();
                    soberania.Responsable = reader["responsable"].ToString();
                    soberania.Cargo = reader["cargo"].ToString();
                    soberania.Telefono = reader["telefono"].ToString();
                    soberania.Correo = reader["correo"].ToString();
                    soberania.Direccion = reader["direccion"].ToString();
                    lista.Add(soberania);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conexion.Close(); };
            return lista;
        }
    }
}
