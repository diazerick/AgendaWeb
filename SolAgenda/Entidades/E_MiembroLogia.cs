using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_MiembroLogia
    {
        public int IdMiembro { get; set; }
        public int IdLogia { get; set; }
        public string Nombre { get; set; }
        public string Logia { get; set; }
        public string Cargo { get; set; }
        public string Rito { get; set; }
        public string Grado { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Ocupacion { get; set; }
        public string Direccion { get; set; }
        public string Municipio { get; set; }
        public string Ciudad { get; set; }
        public string Nacionalidad { get; set; }

        public int Edad
        {
            get
            {
                DateTime fechaActual = DateTime.Now;
                int aux = fechaActual.Year - FechaNacimiento.Year;

                // Ajustar la edad si aún no se ha cumplido el aniversario de nacimiento en el año actual
                if (fechaActual < FechaNacimiento.AddYears(aux))
                {
                    aux--;
                }

                return aux;
            }
        }
    }
}
