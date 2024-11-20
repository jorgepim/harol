using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BDatos.Models
{
    internal class InventoryMovement
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }

        [BsonElement("productoId")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string productoId { get; set; }

        [BsonElement("tipoMovimiento")]
        public string tipoMovimiento { get; set; }  

        [BsonElement("cantidad")]
        public int cantidad { get; set; }

        [BsonElement("proveedor")]
        public Proveedor proveedor { get; set; } = new Proveedor();

        [BsonElement("fecha")]
        public DateTime fecha { get; set; } = DateTime.Now;
    }
    public class Proveedor
    {
        [BsonElement("nombre")]
        public string Nombre { get; set; }

        [BsonElement("telefono")]
        public string Telefono { get; set; }
    }

}
