using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDatos.Models
{
    internal class Clientes
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }

        [BsonElement("nombre")]
        public string Nombre { get; set; }

        [BsonElement("correo")]
        public string Correo { get; set; }

        [BsonElement("telefono")]
        public string Telefono { get; set; }

        [BsonElement("penalizaciones")]
        public int Penalizaciones { get; set; }

        [BsonElement("costoAcumulado")]
        public decimal CostoAcumulado { get; set; }

        [BsonElement("bloqueado")]
        public bool Bloqueado { get; set; }
    }
}
