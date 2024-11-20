using BDatos.Data;
using BDatos.Models;

namespace BDatos.Forms
{
    public partial class ProductForm : Form
    {
        Connection connection;
        Products products;
        string selectedProductId = null;
        public ProductForm()
        {
            InitializeComponent();
            connection = new Connection();
            products = new Products();
            LoadDataGridView();
            DeleteBtn.Enabled = false;
            UpdateBtn.Enabled = false;
        }
        private void LoadDataGridView()
        {
            try
            {
                List<Products> productsList = connection.ReadDocumentProduct();
                ProductDataGridView.DataSource = productsList;
                ProductDataGridView.Columns["id"].HeaderText = "ID";
                ProductDataGridView.Columns["id"].Visible = false;
                ProductDataGridView.Columns["nombre"].HeaderText = "Nombre";
                ProductDataGridView.Columns["precio"].HeaderText = "Precio ($)";
                ProductDataGridView.Columns["descripcion"].HeaderText = "Descripción";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos en el DataGridView: {ex.Message}");
            }
        }
        private void CleanTxt()
        {
            selectedProductId = null;
            NombreTxt.Text = string.Empty;
            PrecioUp.Value = 0;
            DescripcionTxt.Text = string.Empty;
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NombreTxt.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío.");
                return;
            }

            if (PrecioUp.Value <= 0)
            {
                MessageBox.Show("El precio debe ser mayor que 0.");
                return;
            }

            if (string.IsNullOrWhiteSpace(DescripcionTxt.Text))
            {
                MessageBox.Show("La descripción no puede estar vacía.");
                return;
            }

            products.nombre = NombreTxt.Text;
            products.precio = PrecioUp.Value;
            products.descripcion = DescripcionTxt.Text;

            string result = connection.InsertDocumentProduct(products);

            MessageBox.Show(result);

            LoadDataGridView();
            CleanTxt();
        }

        private void ProductDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ProductDataGridView.SelectedRows.Count > 0)
            {
                selectedProductId = ProductDataGridView.SelectedRows[0].Cells["id"].Value.ToString();
                NombreTxt.Text = ProductDataGridView.SelectedRows[0].Cells["nombre"].Value.ToString();
                PrecioUp.Value = Convert.ToDecimal(ProductDataGridView.SelectedRows[0].Cells["precio"].Value);
                DescripcionTxt.Text = ProductDataGridView.SelectedRows[0].Cells["descripcion"].Value?.ToString() ?? string.Empty;

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

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedProductId))
            {
                string result = connection.DeleteDocumentProduct(selectedProductId);
                MessageBox.Show(result);
                LoadDataGridView();
                DeleteBtn.Enabled = false;
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedProductId))
            {
                MessageBox.Show("No hay un producto seleccionado para actualizar.");
                return;
            }

            if (string.IsNullOrWhiteSpace(NombreTxt.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío.");
                return;
            }

            if (PrecioUp.Value <= 0)
            {
                MessageBox.Show("El precio debe ser mayor que 0.");
                return;
            }

            if (string.IsNullOrWhiteSpace(DescripcionTxt.Text))
            {
                MessageBox.Show("La descripción no puede estar vacía.");
                return;
            }

            Products produc = new Products
            {
                id = selectedProductId,
                nombre = NombreTxt.Text,
                precio = PrecioUp.Value,
                descripcion = DescripcionTxt.Text
            };

            string result = connection.UpdateDocumentProduct(produc);
            MessageBox.Show(result);
            LoadDataGridView();
            CleanTxt();
            UpdateBtn.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServicesForm abrir = new ServicesForm();
            abrir.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InventoryForm abrir = new InventoryForm();
            abrir.Show();
            this.Close();
        }
    }
}
