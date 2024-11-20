using BDatos.Data;
using BDatos.Models;

namespace BDatos.Forms
{
    public partial class ServicesForm : Form
    {
        Connection connection;
        Services services;
        string selectedServiceId = null;
        public ServicesForm()
        {
            InitializeComponent();
            connection = new Connection();
            services = new Services();
            LoadDataGridView();
            DeleteBtn.Enabled = false;
            UpdateBtn.Enabled = false;
        }

        private void CleanTxt()
        {
            selectedServiceId = null;
            NameTxtBox.Text = string.Empty;
            PriceUpDown.Value = 0;
            DescriptionTxtBox.Text = string.Empty;
            DurationUpDown.Value = 0;
            ToleranceUpDown.Value = 0;
        }

        private void LoadDataGridView()
        {
            try
            {
                List<Services> servicesList = connection.ReadDocumentServices();
                servicesDataGridView.DataSource = servicesList;
                servicesDataGridView.Columns["id"].HeaderText = "ID";
                servicesDataGridView.Columns["id"].Visible = false;
                servicesDataGridView.Columns["nombre"].HeaderText = "Nombre";
                servicesDataGridView.Columns["precio"].HeaderText = "Precio ($)";
                servicesDataGridView.Columns["descripcion"].HeaderText = "Descripción";
                servicesDataGridView.Columns["duracion"].HeaderText = "Duración (min)";
                servicesDataGridView.Columns["tolerancia"].HeaderText = "Tolerancia (min)";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos en el DataGridView: {ex.Message}");
            }
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTxtBox.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío.");
                return;
            }

            if (PriceUpDown.Value <= 0)
            {
                MessageBox.Show("El precio debe ser mayor que 0.");
                return;
            }

            if (string.IsNullOrWhiteSpace(DescriptionTxtBox.Text))
            {
                MessageBox.Show("La descripción no puede estar vacía.");
                return;
            }

            if (DurationUpDown.Value <= 0 || DurationUpDown.Value > 240)
            {
                MessageBox.Show("La duración debe estar entre 1 y 240 minutos.");
                return;
            }

            if (ToleranceUpDown.Value < 0 || ToleranceUpDown.Value > 30)
            {
                MessageBox.Show("La tolerancia debe estar entre 0 y 30 minutos.");
                return;
            }

            services.nombre = NameTxtBox.Text;
            services.precio = Decimal.Parse(PriceUpDown.Value.ToString());
            services.descripcion = DescriptionTxtBox.Text;
            services.duracion = int.Parse(DurationUpDown.Value.ToString());
            services.tolerancia = int.Parse(ToleranceUpDown.Value.ToString());

            string result = connection.InsertDocumentServices(services);
            MessageBox.Show(result);
            LoadDataGridView();
            CleanTxt();
        }

        private void servicesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (servicesDataGridView.SelectedRows.Count > 0)
            {
                selectedServiceId = servicesDataGridView.SelectedRows[0].Cells["id"].Value.ToString();
                NameTxtBox.Text = servicesDataGridView.SelectedRows[0].Cells["nombre"].Value.ToString();
                PriceUpDown.Value = Convert.ToDecimal(servicesDataGridView.SelectedRows[0].Cells["precio"].Value);
                DescriptionTxtBox.Text = servicesDataGridView.SelectedRows[0].Cells["descripcion"].Value.ToString();
                DurationUpDown.Value = Convert.ToInt32(servicesDataGridView.SelectedRows[0].Cells["duracion"].Value);
                ToleranceUpDown.Value = Convert.ToInt32(servicesDataGridView.SelectedRows[0].Cells["tolerancia"].Value);

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
            if (!string.IsNullOrEmpty(selectedServiceId))
            {
                string result = connection.DeleteDocumentServices(selectedServiceId);
                MessageBox.Show(result);
                LoadDataGridView();
                DeleteBtn.Enabled = false;
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedServiceId))
            {
                MessageBox.Show("No hay un servicio seleccionado para actualizar.");
                return;
            }

            if (string.IsNullOrWhiteSpace(NameTxtBox.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío.");
                return;
            }

            if (PriceUpDown.Value <= 0)
            {
                MessageBox.Show("El precio debe ser mayor que 0.");
                return;
            }

            if (string.IsNullOrWhiteSpace(DescriptionTxtBox.Text))
            {
                MessageBox.Show("La descripción no puede estar vacía.");
                return;
            }

            if (DurationUpDown.Value <= 0 || DurationUpDown.Value > 240)
            {
                MessageBox.Show("La duración debe estar entre 1 y 240 minutos.");
                return;
            }

            if (ToleranceUpDown.Value < 0 || ToleranceUpDown.Value > 30)
            {
                MessageBox.Show("La tolerancia debe estar entre 0 y 30 minutos.");
                return;
            }

            services = new Services
            {
                id = selectedServiceId,
                nombre = NameTxtBox.Text,
                precio = PriceUpDown.Value,
                descripcion = DescriptionTxtBox.Text,
                duracion = (int)DurationUpDown.Value,
                tolerancia = (int)ToleranceUpDown.Value
            };

            string result = connection.UpdateDocumentServices(services);
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
            ProductForm abrir = new ProductForm();
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
