using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BDatos.Models
{
    internal class Services
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }
        [BsonElement("nombre")]
        public string nombre { get; set; }
        [BsonElement("precio")]
        public decimal precio { get; set; }
        [BsonElement("descripcion")]
        public string descripcion { get; set; }
        [BsonElement("duracion")]
        public int duracion { get; set; }
        [BsonElement("tolerancia")]
        public int tolerancia { get; set; }
    }
}
