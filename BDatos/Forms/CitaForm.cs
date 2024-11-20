using BDatos.Data;
using BDatos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDatos.Forms
{
    public partial class CitaForm : Form
    {
        Connection connection;
        CitasModel.Citas cita;
        List<CitasModel.Empleado> empleados;
        List<CitasModel.ServicioCita> serviciosData;
        string selectedCitaId = null;
        public CitaForm()
        {
            InitializeComponent();
            serviciosData = new List<CitasModel.ServicioCita>();
            empleados = new List<CitasModel.Empleado>();
            empleados.Add(new CitasModel.Empleado("Ruben", "1234-5678", "MañanaNClaaes@unica.edu.sv"));
            empleados.Add(new CitasModel.Empleado("Guillermo", "1234-5618", "MañanaNClaaes@unica.edu.sv"));
            empleados.Add(new CitasModel.Empleado("Manuel", "1334-5678", "MañanaNClaaes@unica.edu.sv"));
            empleados.Add(new CitasModel.Empleado("Caleb", "16334-5678", "MañanaNClaaes@unica.edu.sv"));
            LoadCombos();
            LoadDataViews();
        }
        public void LoadCombos()
        {
            connection = new Connection();
            ClienteBox.DataSource = connection.ReadDocumentClientes();
            ClienteBox.DisplayMember = "Nombre";
            ClienteBox.ValueMember = "id";

            ServicioBox.DataSource = connection.ReadDocumentServices();
            ServicioBox.DisplayMember = "nombre";
            ServicioBox.ValueMember = "id";

            EstadoBox.Items.Add("Pendiente");
            EstadoBox.Items.Add("En Proceso");
            EstadoBox.Items.Add("Completado");

            EmpleadoBox.DataSource = empleados;
            EmpleadoBox.DisplayMember = "nombre";
        }
        public void LoadDataViews()
        {
            connection = new Connection();
            var citasData = connection.GetCitas().Select(c => new CitasView
            {
                Id = c.Id,
                ClienteNombre = connection.GetClienteNombreById(c.ClienteNombre),
                Fecha = c.Fecha,
                Estado = c.Estado,
                ToleranciaAplicada = c.ToleranciaAplicada
            }).ToList();
            CitasData.DataSource = citasData;
            CitasData.Columns["id"].Visible = false;
            CitasData.Columns["ClienteNombre"].HeaderText = "Cliente";
            CitasData.Columns["ToleranciaAplicada"].HeaderText = "Tolerancia";
            CitasData.CurrentCell = null;
            ResetForm();

        }

        private void CitasData_SelectionChanged(object sender, EventArgs e)
        {
            connection = new Connection();

            if (CitasData.CurrentRow == null)
            {
                ResetForm();
                return;
            }
            if (CitasData.CurrentRow != null)
            {


                connection = new Connection();

                // Obtener el ID de la cita seleccionada
                selectedCitaId = CitasData.CurrentRow.Cells["Id"].Value?.ToString();
                if (string.IsNullOrEmpty(selectedCitaId))
                {
                    ResetForm();
                    return;
                }

                // Obtener la cita seleccionada
                var cita = connection.GetCitaById(selectedCitaId);
                if (cita == null)
                {
                    ResetForm();
                    return;
                }

                // Llenar el formulario
                ClienteBox.SelectedValue = cita.clienteId;
                EstadoBox.SelectedItem = cita.estado;
                FechaPicker.Value = cita.fecha;
                ToleranciaCheck.Checked = cita.toleranciaAplicada;

                CitasModel.Citas citaInfo = connection.GetCitaById(selectedCitaId);
                serviciosData.Clear();
                serviciosData = citaInfo.servicios;
                var servicios = connection.GetServiciosByCitaId(selectedCitaId);
                // Aquí asignamos los servicios al DataGridView ServiciosAgreData
                var serviciosView = serviciosData.Select(s => new ServicioSimpleView
                {
                    ServicioNombre = connection.GetServicioNombreById(s.servicioId) // Esta línea debería usar los datos de ServicioView
                }).ToList();

                ServiciosAgreData.DataSource = null; // Limpiar el DataGridView
                ServiciosAgreData.DataSource = serviciosView;

                ServData.DataSource = servicios;
                ServData.Columns["ServicioNombre"].HeaderText = "Servicio";
                ServData.Columns["HoraInicio"].HeaderText = "Inicio";
                ServData.Columns["HoraFin"].HeaderText = "Fin";
                ServData.Columns["EmpleadoNombre"].HeaderText = "Nombre Empleado";
                ServData.Columns["EmpleadoTelefono"].HeaderText = "Teléfono";
                ServData.Columns["EmpleadoCorreo"].HeaderText = "Correo";
                InsertBtn.Enabled = false;
            }
        }
        private void ResetForm()
        {
            selectedCitaId = null;
            ClienteBox.SelectedIndex = -1;
            EstadoBox.SelectedIndex = -1;
            FechaPicker.Value = DateTime.Now;
            ToleranciaCheck.Checked = false;
            serviciosData.Clear();

            ServiciosAgreData.DataSource = null;
            InsertBtn.Enabled = true;
        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {

            var empleadoData = empleados.Where(e => e.nombre == EmpleadoBox.Text.ToString()).FirstOrDefault();

            if (empleadoData == null)
            {
                MessageBox.Show("Empleado no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CitasModel.ServicioCita datos = new CitasModel.ServicioCita()
            {
                servicioId = ServicioBox.SelectedValue.ToString(),
                espacioId = (int)EspacioUp.Value,
                horaInicio = FechaPicker.Value,
                horaFin = FechaPicker.Value.AddMinutes(30),
                empleado = empleadoData
            };

            serviciosData.Add(datos);
            var serviciosView = serviciosData.Select(s => new ServicioSimpleView
            {
                ServicioNombre = connection.GetServicioNombreById(s.servicioId)
            }).ToList();

            ServiciosAgreData.DataSource = null;
            ServiciosAgreData.DataSource = serviciosView;

        }

        private void QuitarBtn_Click(object sender, EventArgs e)
        {
            if (ServiciosAgreData.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione un servicio para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Obtener el índice seleccionado
            int rowIndex = ServiciosAgreData.CurrentRow.Index;

            // Eliminar el servicio correspondiente de la lista original
            if (rowIndex >= 0 && rowIndex < serviciosData.Count)
            {
                serviciosData.RemoveAt(rowIndex);

                // Actualizar la vista
                var serviciosView = serviciosData.Select(s => new ServicioSimpleView
                {
                    ServicioNombre = ServicioBox.Items.Cast<dynamic>().FirstOrDefault(i => i.id == s.servicioId)?.nombre ?? "Desconocido"
                }).ToList();

                ServiciosAgreData.DataSource = null; // Limpia el DataGridView
                ServiciosAgreData.DataSource = serviciosView; // Llena con los datos actualizados
            }
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            connection = new Connection();
            CitasModel.Citas citas = new CitasModel.Citas()
            {
                clienteId = ClienteBox.SelectedValue.ToString(),
                servicios = serviciosData,
                fecha = FechaPicker.Value,
                estado = EstadoBox.Text.ToString(),
                toleranciaAplicada = ToleranciaCheck.Checked
            };
            connection.InsertDocumentCitas(citas);
            LoadDataViews();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            connection = new Connection();
            CitasModel.Citas citas = new CitasModel.Citas()
            {
                id = selectedCitaId,
                clienteId = ClienteBox.SelectedValue.ToString(),
                servicios = serviciosData,
                fecha = FechaPicker.Value,
                estado = EstadoBox.SelectedItem.ToString(),
                toleranciaAplicada = ToleranciaCheck.Checked
            };
            connection.UpdateDocumentCitas(citas);
            LoadDataViews();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            connection = new Connection();
            connection.DeleteDocumentCitas(selectedCitaId);
            LoadDataViews();
        }

        private void LimpiarBtn_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
    public class ServicioView
    {
        public string ServicioNombre { get; set; }
        public int EspacioId { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFin { get; set; }
        public string EmpleadoNombre { get; set; }
        public string EmpleadoTelefono { get; set; }
        public string EmpleadoCorreo { get; set; }
    }

    public class CitasView
    {
        public string Id { get; set; }
        public string ClienteNombre { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public bool ToleranciaAplicada { get; set; }
    }
    public class ServicioSimpleView
    {
        public string ServicioNombre { get; set; }
    }

}
