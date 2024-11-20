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
        public CitaForm()
        {
            InitializeComponent();
            empleados = new List<CitasModel.Empleado>();
            empleados.Add(new CitasModel.Empleado("Ruben","1234-5678", "MañanaNClaaes@unica.edu.sv"));
            empleados.Add(new CitasModel.Empleado("Guillermo","1234-5618", "MañanaNClaaes@unica.edu.sv"));
            empleados.Add(new CitasModel.Empleado("Manuel","1334-5678", "MañanaNClaaes@unica.edu.sv"));
            empleados.Add(new CitasModel.Empleado("Caleb","16334-5678", "MañanaNClaaes@unica.edu.sv"));
        }
        public void LoadCombos()
        {
            connection = new Connection();
            ClienteBox.DataSource = connection.ReadDocumentClientes();
            ClienteBox.DisplayMember = "Nombre";
            ClienteBox.ValueMember = "id";

            EstadoBox.Items.Clear();
            EstadoBox.Items.Add("Pendiente");
            EstadoBox.Items.Add("En Proceso");
            EstadoBox.Items.Add("Completado");

            EmpleadoBox.DataSource = empleados;
            EmpleadoBox.DisplayMember="nombre";

            
        }
    }
}
