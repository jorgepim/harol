using MongoDB.Bson.Serialization.Attributes;
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
            [BsonId]
            [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
            public string id { get; set; }

            [BsonElement("clienteId")]
            [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
            public string clienteId { get; set; }

            [BsonElement("servicios")]
            public List<ServicioCita> servicios { get; set; }

            [BsonElement("fecha")]
            public DateTime fecha { get; set; }

            [BsonElement("estado")]
            public string estado { get; set; }

            [BsonElement("toleranciaAplicada")]
            public bool toleranciaAplicada { get; set; }
        }

        public class ServicioCita
        {
            [BsonElement("servicioId")]
            [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
            public string servicioId { get; set; }

            [BsonElement("espacioId")]
            public int espacioId { get; set; }

            [BsonElement("horaInicio")]
            public DateTime horaInicio { get; set; }

            [BsonElement("horaFin")]
            public DateTime horaFin { get; set; }

            [BsonElement("empleado")]
            public Empleado empleado { get; set; }
        }

        public class Empleado
        {
            [BsonElement("nombre")]
            public string nombre { get; set; }

            [BsonElement("telefono")]
            public string telefono { get; set; }

            [BsonElement("correo")]
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
