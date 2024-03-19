using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class D_GranOriente : D_Conexion
    {

        public List<E_GranOriente> ObtenerTodos()
        {
            List<E_GranOriente> lista = new List<E_GranOriente>();
            try
            {
                string query = "SELECT idGranOriente,oriente,responsable,cargo,telefono,correo,direccion FROM granOriente";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    E_GranOriente oriente = new E_GranOriente();
                    oriente.IdGranOriente = Convert.ToInt32(reader["idGranOriente"]);
                    oriente.Oriente = reader["oriente"].ToString();
                    oriente.Responsable = reader["responsable"].ToString();
                    oriente.Cargo = reader["cargo"].ToString();
                    oriente.Telefono = reader["telefono"].ToString();
                    oriente.Correo = reader["correo"].ToString();
                    oriente.Direccion = reader["direccion"].ToString();
                    lista.Add(oriente);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conexion.Close(); };
            return lista;
        }

        public E_GranOriente ObtenerPorId(int idGranOriente)
        {
            E_GranOriente oriente = new E_GranOriente();
            try
            {
                string query = "SELECT idGranOriente,oriente,responsable,cargo,telefono,correo,direccion FROM granOriente WHERE idGranOriente = @idGranOriente";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@idGranOriente", idGranOriente);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    oriente.IdGranOriente = Convert.ToInt32(reader["idGranOriente"]);
                    oriente.Oriente = reader["oriente"].ToString();
                    oriente.Responsable = reader["responsable"].ToString();
                    oriente.Cargo = reader["cargo"].ToString();
                    oriente.Telefono = reader["telefono"].ToString();
                    oriente.Correo = reader["correo"].ToString();
                    oriente.Direccion = reader["direccion"].ToString();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conexion.Close(); };
            return oriente;
        }

        public void Agregar(E_GranOriente oriente)
        {
            try
            {
                string query = "INSERT INTO granOriente(oriente,responsable,cargo,telefono,correo,direccion) " +
                                               "VALUES(@oriente,@responsable,@cargo,@telefono,@correo,@direccion)";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@oriente", oriente.Oriente);
                comando.Parameters.AddWithValue("@responsable", oriente.Responsable);
                comando.Parameters.AddWithValue("@cargo", oriente.Cargo);
                comando.Parameters.AddWithValue("@telefono", oriente.Telefono);
                comando.Parameters.AddWithValue("@correo", oriente.Correo);
                comando.Parameters.AddWithValue("@direccion", oriente.Direccion);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conexion.Close(); };
        }

        public void Editar(E_GranOriente oriente)
        {
            try
            {
                string query = "UPDATE granOriente SET oriente=@oriente,responsable=@responsable," +
                    "cargo=@cargo,telefono=@telefono,correo=@correo,direccion=@direccion WHERE idGranOriente=@idGranOriente";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@oriente", oriente.Oriente);
                comando.Parameters.AddWithValue("@responsable", oriente.Responsable);
                comando.Parameters.AddWithValue("@cargo", oriente.Cargo);
                comando.Parameters.AddWithValue("@telefono", oriente.Telefono);
                comando.Parameters.AddWithValue("@correo", oriente.Correo);
                comando.Parameters.AddWithValue("@direccion", oriente.Direccion);
                comando.Parameters.AddWithValue("@idGranOriente", oriente.IdGranOriente);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conexion.Close(); };
        }

        public void Borrar(int idGranOriente)
        {
            try
            {
                string query = "DELETE granOriente WHERE idGranOriente=@idGranOriente";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@idGranOriente", idGranOriente);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conexion.Close(); };
        }
    }
}
