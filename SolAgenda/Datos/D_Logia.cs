using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class D_Logia : D_Conexion
    {
        public List<E_Logia> ObtenerTodos()
        {
            List<E_Logia> lista = new List<E_Logia>();
            try
            {
                string query = "SELECT idLogia,logia,responsable,cargo,telefono,correo,direccion FROM logias";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    E_Logia logia = new E_Logia();
                    logia.IdLogia = Convert.ToInt32(reader["idLogia"]);
                    logia.Logia = reader["logia"].ToString();
                    logia.Responsable = reader["responsable"].ToString();
                    logia.Cargo = reader["cargo"].ToString();
                    logia.Telefono = reader["telefono"].ToString();
                    logia.Correo = reader["correo"].ToString();
                    logia.Direccion = reader["direccion"].ToString();
                    lista.Add(logia);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conexion.Close(); };
            return lista;
        }

        public E_Logia ObtenerPorId(int idLogia)
        {
            E_Logia logia = new E_Logia();
            try
            {
                string query = "SELECT idLogia,logia,responsable,cargo,telefono,correo,direccion FROM logias WHERE idLogia = @idLogia";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@idLogia", idLogia);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    logia.IdLogia = Convert.ToInt32(reader["idLogia"]);
                    logia.Logia = reader["logia"].ToString();
                    logia.Responsable = reader["responsable"].ToString();
                    logia.Cargo = reader["cargo"].ToString();
                    logia.Telefono = reader["telefono"].ToString();
                    logia.Correo = reader["correo"].ToString();
                    logia.Direccion = reader["direccion"].ToString();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conexion.Close(); };
            return logia;
        }

        public void Agregar(E_Logia logia)
        {
            try
            {
                string query = "INSERT INTO logias(logia,responsable,cargo,telefono,correo,direccion) " +
                                               "VALUES(@logia,@responsable,@cargo,@telefono,@correo,@direccion)";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@logia", logia.Logia);
                comando.Parameters.AddWithValue("@responsable", logia.Responsable);
                comando.Parameters.AddWithValue("@cargo", logia.Cargo);
                comando.Parameters.AddWithValue("@telefono", logia.Telefono);
                comando.Parameters.AddWithValue("@correo", logia.Correo);
                comando.Parameters.AddWithValue("@direccion", logia.Direccion);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conexion.Close(); };
        }

        public void Editar(E_Logia logia)
        {
            try
            {
                string query = "UPDATE logias SET logia=@logia,responsable=@responsable," +
                    "cargo=@cargo,telefono=@telefono,correo=@correo,direccion=@direccion WHERE idLogia=@idLogia";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@logia", logia.Logia);
                comando.Parameters.AddWithValue("@responsable", logia.Responsable);
                comando.Parameters.AddWithValue("@cargo", logia.Cargo);
                comando.Parameters.AddWithValue("@telefono", logia.Telefono);
                comando.Parameters.AddWithValue("@correo", logia.Correo);
                comando.Parameters.AddWithValue("@direccion", logia.Direccion);
                comando.Parameters.AddWithValue("@idLogia", logia.IdLogia);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conexion.Close(); };
        }

        public void Borrar(int idLogia)
        {
            try
            {
                string query = "DELETE logias WHERE idLogia=@idLogia";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@idLogia", idLogia);
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
