using BDatos.Forms;

namespace BDatos.Forms
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void ServicesBtn_Click(object sender, EventArgs e)
        {
            ServicesForm abrir = new ServicesForm();
            abrir.Show();
        }

        private void InventoryBtn_Click(object sender, EventArgs e)
        {
            InventoryForm abrir = new InventoryForm();
            abrir.Show();
        }

        private void ProductBtn_Click(object sender, EventArgs e)
        {
            ProductForm abrir = new ProductForm();
            abrir.Show();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
