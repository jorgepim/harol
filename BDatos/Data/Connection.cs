using BDatos.Models;
using MongoDB.Driver;
using static BDatos.Models.CitasModel;

namespace BDatos.Data
{
    internal class Connection
    {
        private static string _server = "localhost";
        private static string _port = "27017";

        public static MongoClient client = new MongoClient("mongodb://" + _server + ":" + _port);

        public static IMongoDatabase database = client.GetDatabase("CarWashDB");

        public static IMongoCollection<Services> servicesCo = database.GetCollection<Services>("Servicios");
        public static IMongoCollection<InventoryMovement> inventoryCo = database.GetCollection<InventoryMovement>("MovimientoInventario");
        public static IMongoCollection<Products> productCo = database.GetCollection<Products>("Productos");
        public static IMongoCollection<Citas> citasCo = database.GetCollection<Citas>("Citas");
        public static IMongoCollection<Clientes> clientesCo = database.GetCollection<Clientes>("Clientes");


        //Insert de cada colección
        public string InsertDocumentServices(Services data)
        {
            try
            {
                servicesCo.InsertOne(data);
                return "Se almacenó exitosamente";
            }
            catch (Exception ex)
            {
                return $"Error al almacenar el documento: {ex.Message}";
            }
        }
        public string InsertDocumentProduct(Products data)
        {
            try
            {
                productCo.InsertOne(data);
                return "Se almacenó exitosamente";
            }
            catch (Exception ex)
            {
                return $"Error al almacenar el documento: {ex.Message}";
            }
        }
        public string InsertDocumentInventory(InventoryMovement data)
        {
            try
            {
                inventoryCo.InsertOne(data);
                return "Se almacenó exitosamente";
            }
            catch (Exception ex)
            {
                return $"Error al almacenar el documento: {ex.Message}";
            }
        }
        public string InsertDocumentCitas(Citas data)
        {
            try
            {
                citasCo.InsertOne(data);
                return "Cita registrada exitosamente.";
            }
            catch (Exception ex)
            {
                return $"Error al registrar la cita: {ex.Message}";
            }
        }

        //Read de cada colección
        public List<Services> ReadDocumentServices()
        {
            try
            {
                List<Services> datas = servicesCo.Find(d => true).ToList();
                return datas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer documentos: {ex.Message}");
                return new List<Services>();
            }
        }
        public List<Products> ReadDocumentProduct()
        {
            try
            {
                List<Products> datas = productCo.Find(d => true).ToList();
                return datas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer documentos: {ex.Message}");
                return new List<Products>();
            }
        }
        public List<InventoryMovement> ReadDocumentInventory()
        {
            try
            {
                List<InventoryMovement> datas = inventoryCo.Find(d => true).ToList();
                return datas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer documentos: {ex.Message}");
                return new List<InventoryMovement>();
            }
        }
        public List<Citas> ReadDocumentCitas()
        {
            try
            {
                return citasCo.Find(d => true).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer citas: {ex.Message}");
                return new List<Citas>();
            }
        }
        public List<Clientes> ReadDocumentClientes()
        {
            try
            {
                List<Clientes> clientesList = clientesCo.Find(cliente => true).ToList();
                return clientesList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer los documentos de la colección Clientes: {ex.Message}");
                return new List<Clientes>();
            }
        }


        //Delete de cada colección
        public string DeleteDocumentServices(string id)
        {
            try
            {
                DeleteResult deleteResult = servicesCo.DeleteOne(d => d.id == id);
                if (deleteResult.DeletedCount > 0)
                    return "Se eliminó correctamente";
                else
                    return "No se encontró el documento para eliminar";
            }
            catch (Exception ex)
            {
                return $"Error al eliminar el documento: {ex.Message}";
            }
        }
        public string DeleteDocumentProduct(string id)
        {
            List<InventoryMovement> associatedMovements = ReadDocumentInventory().Where(m => m.productoId != null && m.productoId == id).ToList();
            if (associatedMovements.Any())
            {
                return "No se puede eliminar el producto ya que existen movimientos de inventario asociados.";
            }
            try
            {
                DeleteResult deleteResult = productCo.DeleteOne(d => d.id == id);
                if (deleteResult.DeletedCount > 0)
                    return "Se eliminó correctamente";
                else
                    return "No se encontró el documento para eliminar";
            }
            catch (Exception ex)
            {
                return $"Error al eliminar el documento: {ex.Message}";
            }
        }
        public string DeleteDocumentsInventory(List<string> ids)
        {
            try
            {
                FilterDefinition<InventoryMovement> filter = Builders<InventoryMovement>.Filter.In(d => d.id, ids);
                DeleteResult deleteResult = inventoryCo.DeleteMany(filter);

                if (deleteResult.DeletedCount > 0)
                    return $"{deleteResult.DeletedCount} documentos se eliminaron correctamente.";
                else
                    return "No se encontraron documentos para eliminar.";
            }
            catch (Exception ex)
            {
                return $"Error al eliminar los documentos: {ex.Message}";
            }
        }
        public string DeleteDocumentCitas(string id)
        {
            try
            {
                DeleteResult deleteResult = citasCo.DeleteOne(d => d.id == id);
                if (deleteResult.DeletedCount > 0)
                    return "Cita eliminada correctamente.";
                else
                    return "No se encontró la cita para eliminar.";
            }
            catch (Exception ex)
            {
                return $"Error al eliminar la cita: {ex.Message}";
            }
        }

        //Update de cada colección
        public string UpdateDocumentServices(Services data)
        {
            try
            {
                ReplaceOneResult updateResult = servicesCo.ReplaceOne(d => d.id == data.id, data);
                if (updateResult.MatchedCount > 0)
                    return "Se actualizó correctamente";
                else
                    return "No se encontró el documento para actualizar";
            }
            catch (Exception ex)
            {
                return $"Error al actualizar el documento: {ex.Message}";
            }
        }
        public string UpdateDocumentProduct(Products data)
        {
            try
            {
                ReplaceOneResult updateResult = productCo.ReplaceOne(d => d.id == data.id, data);
                if (updateResult.MatchedCount > 0)
                    return "Se actualizó correctamente";
                else
                    return "No se encontró el documento para actualizar";
            }
            catch (Exception ex)
            {
                return $"Error al actualizar el documento: {ex.Message}";
            }
        }
        public string UpdateDocumentInventory(InventoryMovement data)
        {
            try
            {
                ReplaceOneResult updateResult = inventoryCo.ReplaceOne(d => d.id == data.id, data);
                if (updateResult.MatchedCount > 0)
                    return "Se actualizó correctamente";
                else
                    return "No se encontró el documento para actualizar";
            }
            catch (Exception ex)
            {
                return $"Error al actualizar el documento: {ex.Message}";
            }
        }
        public string UpdateDocumentCitas(Citas data)
        {
            try
            {
                ReplaceOneResult updateResult = citasCo.ReplaceOne(d => d.id == data.id, data);
                if (updateResult.MatchedCount > 0)
                    return "Cita actualizada correctamente.";
                else
                    return "No se encontró la cita para actualizar.";
            }
            catch (Exception ex)
            {
                return $"Error al actualizar la cita: {ex.Message}";
            }
        }
    }
}
