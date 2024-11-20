namespace BDatos.Forms
{
    partial class CitaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            CitasData = new DataGridView();
            ServiciosAgreData = new DataGridView();
            InsertBtn = new Button();
            UpdateBtn = new Button();
            DeleteBtn = new Button();
            AgregarBtn = new Button();
            QuitarBtn = new Button();
            FechaPicker = new DateTimePicker();
            ClienteBox = new ComboBox();
            ServicioBox = new ComboBox();
            EstadoBox = new ComboBox();
            ToleranciaCheck = new CheckBox();
            label5 = new Label();
            EmpleadoBox = new ComboBox();
            ServData = new DataGridView();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)CitasData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ServiciosAgreData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ServData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 60);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 278);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 1;
            label2.Text = "Fecha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 324);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "Estado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 102);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 3;
            label4.Text = "Servicios:";
            // 
            // CitasData
            // 
            CitasData.AllowUserToAddRows = false;
            CitasData.AllowUserToDeleteRows = false;
            CitasData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CitasData.Location = new Point(401, 74);
            CitasData.Name = "CitasData";
            CitasData.ReadOnly = true;
            CitasData.Size = new Size(437, 284);
            CitasData.TabIndex = 5;
            // 
            // ServiciosAgreData
            // 
            ServiciosAgreData.AllowUserToAddRows = false;
            ServiciosAgreData.AllowUserToDeleteRows = false;
            ServiciosAgreData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ServiciosAgreData.Location = new Point(63, 174);
            ServiciosAgreData.Name = "ServiciosAgreData";
            ServiciosAgreData.ReadOnly = true;
            ServiciosAgreData.Size = new Size(183, 91);
            ServiciosAgreData.TabIndex = 6;
            // 
            // InsertBtn
            // 
            InsertBtn.Location = new Point(182, 464);
            InsertBtn.Name = "InsertBtn";
            InsertBtn.Size = new Size(75, 23);
            InsertBtn.TabIndex = 7;
            InsertBtn.Text = "Insertar";
            InsertBtn.UseVisualStyleBackColor = true;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Location = new Point(381, 460);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(75, 23);
            UpdateBtn.TabIndex = 8;
            UpdateBtn.Text = "Modificar";
            UpdateBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(558, 457);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(75, 23);
            DeleteBtn.TabIndex = 9;
            DeleteBtn.Text = "Eliminar";
            DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // AgregarBtn
            // 
            AgregarBtn.Location = new Point(66, 147);
            AgregarBtn.Name = "AgregarBtn";
            AgregarBtn.Size = new Size(75, 23);
            AgregarBtn.TabIndex = 10;
            AgregarBtn.Text = "Agregar";
            AgregarBtn.UseVisualStyleBackColor = true;
            // 
            // QuitarBtn
            // 
            QuitarBtn.Location = new Point(156, 150);
            QuitarBtn.Name = "QuitarBtn";
            QuitarBtn.Size = new Size(75, 23);
            QuitarBtn.TabIndex = 11;
            QuitarBtn.Text = "Quitar";
            QuitarBtn.UseVisualStyleBackColor = true;
            // 
            // FechaPicker
            // 
            FechaPicker.Location = new Point(110, 272);
            FechaPicker.Name = "FechaPicker";
            FechaPicker.Size = new Size(209, 23);
            FechaPicker.TabIndex = 12;
            // 
            // ClienteBox
            // 
            ClienteBox.FormattingEnabled = true;
            ClienteBox.Location = new Point(130, 58);
            ClienteBox.Name = "ClienteBox";
            ClienteBox.Size = new Size(189, 23);
            ClienteBox.TabIndex = 13;
            // 
            // ServicioBox
            // 
            ServicioBox.FormattingEnabled = true;
            ServicioBox.Location = new Point(125, 102);
            ServicioBox.Name = "ServicioBox";
            ServicioBox.Size = new Size(194, 23);
            ServicioBox.TabIndex = 14;
            // 
            // EstadoBox
            // 
            EstadoBox.FormattingEnabled = true;
            EstadoBox.Location = new Point(114, 324);
            EstadoBox.Name = "EstadoBox";
            EstadoBox.Size = new Size(162, 23);
            EstadoBox.TabIndex = 15;
            // 
            // ToleranciaCheck
            // 
            ToleranciaCheck.AutoSize = true;
            ToleranciaCheck.Location = new Point(66, 406);
            ToleranciaCheck.Name = "ToleranciaCheck";
            ToleranciaCheck.Size = new Size(79, 19);
            ToleranciaCheck.TabIndex = 16;
            ToleranciaCheck.Text = "Tolerancia";
            ToleranciaCheck.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 368);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 17;
            label5.Text = "Empleado;";
            // 
            // EmpleadoBox
            // 
            EmpleadoBox.FormattingEnabled = true;
            EmpleadoBox.Location = new Point(135, 365);
            EmpleadoBox.Name = "EmpleadoBox";
            EmpleadoBox.Size = new Size(121, 23);
            EmpleadoBox.TabIndex = 18;
            // 
            // ServData
            // 
            ServData.AllowUserToAddRows = false;
            ServData.AllowUserToDeleteRows = false;
            ServData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ServData.Location = new Point(934, 74);
            ServData.Name = "ServData";
            ServData.ReadOnly = true;
            ServData.Size = new Size(395, 284);
            ServData.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(523, 36);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 20;
            label6.Text = "Citas:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1075, 37);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 21;
            label7.Text = "Detalle:";
            // 
            // CitaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1573, 539);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(ServData);
            Controls.Add(EmpleadoBox);
            Controls.Add(label5);
            Controls.Add(ToleranciaCheck);
            Controls.Add(EstadoBox);
            Controls.Add(ServicioBox);
            Controls.Add(ClienteBox);
            Controls.Add(FechaPicker);
            Controls.Add(QuitarBtn);
            Controls.Add(AgregarBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(InsertBtn);
            Controls.Add(ServiciosAgreData);
            Controls.Add(CitasData);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CitaForm";
            Text = "CitaForm";
            ((System.ComponentModel.ISupportInitialize)CitasData).EndInit();
            ((System.ComponentModel.ISupportInitialize)ServiciosAgreData).EndInit();
            ((System.ComponentModel.ISupportInitialize)ServData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView CitasData;
        private DataGridView ServiciosAgreData;
        private Button InsertBtn;
        private Button UpdateBtn;
        private Button DeleteBtn;
        private Button AgregarBtn;
        private Button QuitarBtn;
        private DateTimePicker FechaPicker;
        private ComboBox ClienteBox;
        private ComboBox ServicioBox;
        private ComboBox EstadoBox;
        private CheckBox ToleranciaCheck;
        private Label label5;
        private ComboBox EmpleadoBox;
        private DataGridView ServData;
        private Label label6;
        private Label label7;
    }
}