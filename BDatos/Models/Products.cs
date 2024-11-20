using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BDatos.Models
{
    internal class Products
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }

        [BsonElement("nombre")]
        public string? nombre { get; set; }

        [BsonElement("precio")]
        public decimal precio { get; set; }

        [BsonElement("descripcion")]
        public string? descripcion { get; set; }
    }
}
