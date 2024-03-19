using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class D_MiembroLogia : D_Conexion
    {
        public List<E_MiembroLogia> ObtenerTodos()
        {
            List<E_MiembroLogia> lista = new List<E_MiembroLogia>();
            try
            {
                string query = "SELECT m.idMiembro,m.idLogia,l.logia, m.nombre, m.cargo,m.rito,m.grado,m.telefono,m.correo,m.fechaNacimiento," +
                            "m.ocupacion, m.direccion, m.municipio, m.ciudad, m.nacionalidad FROM miembrosLogia m INNER JOIN logias l ON m.idLogia = l.idLogia";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    E_MiembroLogia miembro = new E_MiembroLogia();
                    miembro.IdMiembro = Convert.ToInt32(reader["idMiembro"]);
                    miembro.IdLogia = Convert.ToInt32(reader["idLogia"]);
                    miembro.Logia = reader["logia"].ToString();
                    miembro.Nombre = reader["nombre"].ToString();
                    miembro.Cargo = reader["cargo"].ToString();
                    miembro.Rito = reader["rito"].ToString();
                    miembro.Grado = reader["grado"].ToString();
                    miembro.Telefono = reader["telefono"].ToString();
                    miembro.Correo = reader["correo"].ToString();
                    miembro.FechaNacimiento = Convert.ToDateTime(reader["fechaNacimiento"]);
                    miembro.Ocupacion = reader["ocupacion"].ToString();
                    miembro.Direccion = reader["direccion"].ToString();
                    miembro.Municipio = reader["municipio"].ToString();
                    miembro.Ciudad = reader["ciudad"].ToString();
                    miembro.Nacionalidad = reader["nacionalidad"].ToString();
                    lista.Add(miembro);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conexion.Close(); };
            return lista;
        }

        public E_MiembroLogia ObtenerPorId(int idMiembro)
        {
            E_MiembroLogia miembro = new E_MiembroLogia();
            try
            {
                string query = "SELECT m.idMiembro,m.idLogia,l.logia, m.nombre, m.cargo,m.rito,m.grado,m.telefono,m.correo,m.fechaNacimiento," +
                            "m.ocupacion, m.direccion, m.municipio, m.ciudad, m.nacionalidad FROM miembrosLogia m INNER JOIN logias l ON m.idLogia = l.idLogia " +
                            "WHERE m.idMiembro = @idMiembro";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@idMiembro", idMiembro);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    miembro.IdMiembro = Convert.ToInt32(reader["idMiembro"]);
                    miembro.IdLogia = Convert.ToInt32(reader["idLogia"]);
                    miembro.Logia = reader["logia"].ToString();
                    miembro.Nombre = reader["nombre"].ToString();
                    miembro.Cargo = reader["cargo"].ToString();
                    miembro.Rito = reader["rito"].ToString();
                    miembro.Grado = reader["grado"].ToString();
                    miembro.Telefono = reader["telefono"].ToString();
                    miembro.Correo = reader["correo"].ToString();
                    miembro.FechaNacimiento = Convert.ToDateTime(reader["fechaNacimiento"]);
                    miembro.Ocupacion = reader["ocupacion"].ToString();
                    miembro.Direccion = reader["direccion"].ToString();
                    miembro.Municipio = reader["municipio"].ToString();
                    miembro.Ciudad = reader["ciudad"].ToString();
                    miembro.Nacionalidad = reader["nacionalidad"].ToString();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conexion.Close(); };
            return miembro;
        }

        public void Agregar(E_MiembroLogia miembro)
        {
            try
            {
                string query = "INSERT INTO miembrosLogia(idLogia,nombre,cargo,rito,grado,telefono,correo,fechaNacimiento,ocupacion,direccion,municipio,ciudad,nacionalidad) " +
                                               "VALUES(@idLogia,@nombre,@cargo,@rito,@grado,@telefono,@correo,@fechaNacimiento,@ocupacion,@direccion,@municipio,@ciudad,@nacionalidad)";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@idLogia", miembro.IdLogia);
                comando.Parameters.AddWithValue("@nombre", miembro.Nombre);
                comando.Parameters.AddWithValue("@cargo", miembro.Cargo);
                comando.Parameters.AddWithValue("@rito", miembro.Rito);
                comando.Parameters.AddWithValue("@grado", miembro.Grado);
                comando.Parameters.AddWithValue("@telefono", miembro.Telefono);
                comando.Parameters.AddWithValue("@correo", miembro.Correo);
                comando.Parameters.AddWithValue("@fechaNacimiento", miembro.FechaNacimiento);
                comando.Parameters.AddWithValue("@ocupacion", miembro.Ocupacion);
                comando.Parameters.AddWithValue("@direccion", miembro.Direccion);
                comando.Parameters.AddWithValue("@municipio", miembro.Municipio);
                comando.Parameters.AddWithValue("@ciudad", miembro.Ciudad);
                comando.Parameters.AddWithValue("@nacionalidad", miembro.Nacionalidad);
                
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conexion.Close(); };
        }

        public void Editar(E_MiembroLogia miembro)
        {
            try
            {
                string query = "UPDATE miembrosLogia SET idLogia=@idLogia,nombre=@nombre,cargo=@cargo,rito=@rito,grado=@grado," +
                    "telefono=@telefono,correo=@correo,fechaNacimiento=@fechaNacimiento,ocupacion=@ocupacion,direccion=@direccion," +
                    "municipio=@municipio,ciudad=@ciudad,nacionalidad=@nacionalidad WHERE idMiembro=@idMiembro";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@idLogia", miembro.IdLogia);
                comando.Parameters.AddWithValue("@nombre", miembro.Nombre);
                comando.Parameters.AddWithValue("@cargo", miembro.Cargo);
                comando.Parameters.AddWithValue("@rito", miembro.Rito);
                comando.Parameters.AddWithValue("@grado", miembro.Grado);
                comando.Parameters.AddWithValue("@telefono", miembro.Telefono);
                comando.Parameters.AddWithValue("@correo", miembro.Correo);
                comando.Parameters.AddWithValue("@fechaNacimiento", miembro.FechaNacimiento);
                comando.Parameters.AddWithValue("@ocupacion", miembro.Ocupacion);
                comando.Parameters.AddWithValue("@direccion", miembro.Direccion);
                comando.Parameters.AddWithValue("@municipio", miembro.Municipio);
                comando.Parameters.AddWithValue("@ciudad", miembro.Ciudad);
                comando.Parameters.AddWithValue("@nacionalidad", miembro.Nacionalidad);
                comando.Parameters.AddWithValue("@idMiembro", miembro.IdMiembro);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conexion.Close(); };
        }

        public void Borrar(int idMiembro)
        {
            try
            {
                string query = "DELETE miembrosLogia WHERE idMiembro=@idMiembro";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@idMiembro", idMiembro);
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
