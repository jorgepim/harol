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
        public string id { get; set; }

        public string Nombre { get; set; }

        public string Correo { get; set; }

        public string Telefono { get; set; }

        public int Penalizaciones { get; set; }

        public decimal CostoAcumulado { get; set; }

        public bool Bloqueado { get; set; }
    }
}
