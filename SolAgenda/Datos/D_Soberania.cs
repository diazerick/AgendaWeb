using Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class D_Soberania : D_Conexion
    {
        public List<E_Soberania> ObtenerTodos()
        {
            List<E_Soberania> lista = new List<E_Soberania>();
            try
            {
                string query = "SELECT idSoberania,soberania,responsable,cargo,telefono,correo,direccion FROM soberanias";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    E_Soberania soberania = new E_Soberania();
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

        public E_Soberania ObtenerPorId(int idSoberania)
        {
            E_Soberania soberania = new E_Soberania();
            try
            {
                string query = "SELECT idSoberania,soberania,responsable,cargo,telefono,correo,direccion FROM soberanias WHERE idSoberania = @idSoberania";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@idSoberania", idSoberania);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    soberania.IdSoberania = Convert.ToInt32(reader["idSoberania"]);
                    soberania.Soberania = reader["soberania"].ToString();
                    soberania.Responsable = reader["responsable"].ToString();
                    soberania.Cargo = reader["cargo"].ToString();
                    soberania.Telefono = reader["telefono"].ToString();
                    soberania.Correo = reader["correo"].ToString();
                    soberania.Direccion = reader["direccion"].ToString();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conexion.Close(); };
            return soberania;
        }

        public void Agregar(E_Soberania soberania)
        {
            try
            {
                string query = "INSERT INTO soberanias(soberania,responsable,cargo,telefono,correo,direccion) " +
                                               "VALUES(@soberania,@responsable,@cargo,@telefono,@correo,@direccion)";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@soberania", soberania.Soberania);
                comando.Parameters.AddWithValue("@responsable", soberania.Responsable);
                comando.Parameters.AddWithValue("@cargo", soberania.Cargo);
                comando.Parameters.AddWithValue("@telefono", soberania.Telefono);
                comando.Parameters.AddWithValue("@correo", soberania.Correo);
                comando.Parameters.AddWithValue("@direccion", soberania.Direccion);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conexion.Close(); };
        }

        public void Editar(E_Soberania soberania)
        {
            try
            {
                string query = "UPDATE soberanias SET soberania=@soberania,responsable=@responsable," +
                    "cargo=@cargo,telefono=@telefono,correo=@correo,direccion=@direccion WHERE idSoberania=@idSoberania";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@soberania", soberania.Soberania);
                comando.Parameters.AddWithValue("@responsable", soberania.Responsable);
                comando.Parameters.AddWithValue("@cargo", soberania.Cargo);
                comando.Parameters.AddWithValue("@telefono", soberania.Telefono);
                comando.Parameters.AddWithValue("@correo", soberania.Correo);
                comando.Parameters.AddWithValue("@direccion", soberania.Direccion);
                comando.Parameters.AddWithValue("@idSoberania", soberania.IdSoberania);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conexion.Close(); };
        }

        public void Borrar(int idSoberania)
        {
            try
            {
                string query = "DELETE soberanias WHERE idSoberania=@idSoberania";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@idSoberania", idSoberania);
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
