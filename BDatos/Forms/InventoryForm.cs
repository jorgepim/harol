using BDatos.Data;
using BDatos.Models;

namespace BDatos.Forms
{
    public partial class InventoryForm : Form
    {
        Connection connection;
        InventoryMovement inventory;
        string selectedInventoryId = null;
        private List<string> selectedInventoryIds = new List<string>();

        public InventoryForm()
        {
            InitializeComponent();
            connection = new Connection();
            inventory = new InventoryMovement();
            LoadDataGridView("");
            StartCombos();
            DeleteBtn.Enabled = false;
            UpdateBtn.Enabled = false;
            InventoryDataGridView.MultiSelect = false;
        }

        private void StartCombos()
        {
            List<Products> productList = connection.ReadDocumentProduct();
            ProductoCB.DataSource = productList;
            ProductoCB.DisplayMember = "nombre";
            ProductoCB.ValueMember = "id";
            TipoMoCB.Items.Clear();
            TipoMoCB.Items.Add("Entrada");
            TipoMoCB.Items.Add("Salida");
        }
        private void CleanTxt()
        {
            selectedInventoryId = null;
            ProductoCB.SelectedIndex = 0;
            CantidadUp.Value = 0;
            NombreTxt.Text = string.Empty;
            telefonoMask.Text = string.Empty;
            TipoMoCB.SelectedIndex = 0;
            FechaPicker.Value = DateTime.Now;
            FiltrarTxt.Text = string.Empty;
        }

        private void LoadDataGridView(string searchText)
        {
            try
            {
                List<InventoryMovement> inventoryList = connection.ReadDocumentInventory();

                List<Products> productList = connection.ReadDocumentProduct();

                var filteredList = inventoryList
                .Select(item => new
                {
                    item.id,
                    ProductoNombre = productList.FirstOrDefault(p => p.id == item.productoId)?.nombre ?? "Producto no encontrado",
                    item.tipoMovimiento,
                    item.cantidad,
                    item.fecha,
                    ProveedorNombre = item.proveedor?.Nombre,
                    ProveedorTelefono = item.proveedor?.Telefono
                })
                .Where(displayItem => displayItem.ProductoNombre.ToLower().Contains(searchText))
                .ToList();

                InventoryDataGridView.DataSource = filteredList;
                InventoryDataGridView.Columns["id"].HeaderText = "ID";
                InventoryDataGridView.Columns["id"].Visible = false;
                InventoryDataGridView.Columns["ProductoNombre"].HeaderText = "Producto";
                InventoryDataGridView.Columns["tipoMovimiento"].HeaderText = "Tipo de Movimiento";
                InventoryDataGridView.Columns["cantidad"].HeaderText = "Cantidad";
                InventoryDataGridView.Columns["fecha"].HeaderText = "Fecha";
                InventoryDataGridView.Columns["ProveedorNombre"].HeaderText = "Proveedor";
                InventoryDataGridView.Columns["ProveedorTelefono"].HeaderText = "Teléfono";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos en el DataGridView: {ex.Message}");
            }
        }

        private void InventoryDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            selectedInventoryIds.Clear();

            if (InventoryDataGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in InventoryDataGridView.SelectedRows)
                {
                    string inventoryId = row.Cells["id"].Value.ToString();
                    if (!selectedInventoryIds.Contains(inventoryId))
                    {
                        selectedInventoryIds.Add(inventoryId);
                    }
                }

                var selectedRow = InventoryDataGridView.SelectedRows[0];
                selectedInventoryId = selectedRow.Cells["id"].Value.ToString();
                string selectedProductId = selectedRow.Cells["ProductoNombre"].Value.ToString();
                ProductoCB.SelectedIndex = ProductoCB.FindStringExact(selectedProductId);
                string selectedTipoMovimiento = selectedRow.Cells["tipoMovimiento"].Value.ToString();
                TipoMoCB.SelectedIndex = TipoMoCB.FindStringExact(selectedTipoMovimiento);
                CantidadUp.Value = Convert.ToInt32(selectedRow.Cells["cantidad"].Value);
                NombreTxt.Text = selectedRow.Cells["ProveedorNombre"].Value.ToString();
                telefonoMask.Text = selectedRow.Cells["ProveedorTelefono"].Value.ToString();
                FechaPicker.Value = Convert.ToDateTime(selectedRow.Cells["fecha"].Value);
                DeleteBtn.Enabled = true;
                UpdateBtn.Enabled = true;
                InsertBtn.Enabled = false;
            }
            else
            {
                CleanTxt();
                DeleteBtn.Enabled = false;
                UpdateBtn.Enabled = false;
                InsertBtn.Enabled = true;
            }
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;
            }
            InventoryMovement inventory = new InventoryMovement();
            inventory.productoId = ProductoCB.SelectedValue.ToString();
            inventory.tipoMovimiento = TipoMoCB.SelectedItem.ToString();
            inventory.proveedor.Nombre = NombreTxt.Text;
            inventory.proveedor.Telefono = telefonoMask.Text;
            inventory.cantidad = int.Parse(CantidadUp.Value.ToString());
            inventory.fecha = FechaPicker.Value;
            string result = connection.InsertDocumentInventory(inventory);
            MessageBox.Show(result);

            LoadDataGridView("");
            CleanTxt();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;
            }
            InventoryMovement inventory = new InventoryMovement();
            inventory.id = selectedInventoryId;
            inventory.productoId = ProductoCB.SelectedValue.ToString();
            inventory.tipoMovimiento = TipoMoCB.SelectedItem.ToString();
            inventory.proveedor.Nombre = NombreTxt.Text;
            inventory.proveedor.Telefono = telefonoMask.Text;
            inventory.cantidad = int.Parse(CantidadUp.Value.ToString());
            inventory.fecha = FechaPicker.Value;
            string result = connection.UpdateDocumentInventory(inventory);
            MessageBox.Show(result);

            LoadDataGridView("");
            CleanTxt();

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (selectedInventoryIds == null || selectedInventoryIds.Count == 0)
            {
                MessageBox.Show("Seleccione uno o más elementos para eliminar.");
                return;
            }
            string result = connection.DeleteDocumentsInventory(selectedInventoryIds);
            MessageBox.Show(result);
            LoadDataGridView("");
            DeleteBtn.Enabled = false;
        }

        private void FilterBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FiltrarTxt.Text))
            {
                InventoryDataGridView.MultiSelect = false;
                LoadDataGridView("");
            }
            else
            {
                InventoryDataGridView.MultiSelect = true;
                LoadDataGridView(FiltrarTxt.Text.Trim());
            }
        }
        private bool ValidateFields()
        {
            if (ProductoCB.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un producto.");
                return false;
            }
            if (TipoMoCB.SelectedItem == null)
            {
                MessageBox.Show("Seleccione el tipo de movimiento (Entrada o Salida).");
                return false;
            }
            if (string.IsNullOrWhiteSpace(NombreTxt.Text))
            {
                MessageBox.Show("Ingrese el nombre del proveedor.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(telefonoMask.Text))
            {
                MessageBox.Show("Ingrese el teléfono del proveedor.");
                return false;
            }
            if (CantidadUp.Value <= 0)
            {
                MessageBox.Show("Ingrese una cantidad mayor a 0.");
                return false;
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductForm abrir = new ProductForm();
            abrir.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ServicesForm abrir = new ServicesForm();
            abrir.Show();
            this.Close();
        }
    }
}
