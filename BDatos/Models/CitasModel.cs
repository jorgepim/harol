using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BDatos.Models
{
    internal class CitasModel
    {
        public class Citas
        {
            public string id { get; set; }
            public string clienteId { get; set; }
            public List<ServicioCita> servicios { get; set; }
            public DateTime fecha { get; set; }
            public string estado { get; set; }
            public bool toleranciaAplicada { get; set; }
        }

        public class ServicioCita
        {
            public string servicioId { get; set; }
            public int espacioId { get; set; }
            public DateTime horaInicio { get; set; }
            public DateTime horaFin { get; set; }
            public Empleado empleado { get; set; }
        }

        public class Empleado
        {
            public string nombre { get; set; }
            public string telefono { get; set; }
            public string correo { get; set; }
            public Empleado(string nombre, string telefono, string correo)
            {
                this.nombre = nombre;
                this.telefono = telefono;
                this.correo = correo;
            }
        }
    }
}
