namespace BDatos.Forms
{
    partial class InventoryForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryForm));
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            telefonoMask = new MaskedTextBox();
            NombreTxt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            InventoryDataGridView = new DataGridView();
            InsertBtn = new Button();
            UpdateBtn = new Button();
            DeleteBtn = new Button();
            FilterBtn = new Button();
            ProductoCB = new ComboBox();
            TipoMoCB = new ComboBox();
            FechaPicker = new DateTimePicker();
            CantidadUp = new NumericUpDown();
            FiltrarTxt = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            label7 = new Label();
            panel3 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            button3 = new Button();
            panel6 = new Panel();
            panel7 = new Panel();
            button2 = new Button();
            panel4 = new Panel();
            panel5 = new Panel();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InventoryDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CantidadUp).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(571, 123);
            label1.Name = "label1";
            label1.Size = new Size(145, 38);
            label1.TabIndex = 0;
            label1.Text = "Producto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(571, 220);
            label2.Name = "label2";
            label2.Size = new Size(142, 38);
            label2.TabIndex = 1;
            label2.Text = "Cantidad:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(telefonoMask);
            groupBox1.Controls.Add(NombreTxt);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(573, 315);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(414, 255);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Proveedor";
            // 
            // telefonoMask
            // 
            telefonoMask.ForeColor = Color.CadetBlue;
            telefonoMask.Location = new Point(151, 180);
            telefonoMask.Margin = new Padding(3, 4, 3, 4);
            telefonoMask.Mask = "0000-0000";
            telefonoMask.Name = "telefonoMask";
            telefonoMask.Size = new Size(244, 43);
            telefonoMask.TabIndex = 11;
            // 
            // NombreTxt
            // 
            NombreTxt.ForeColor = Color.CadetBlue;
            NombreTxt.Location = new Point(151, 81);
            NombreTxt.Margin = new Padding(3, 4, 3, 4);
            NombreTxt.Name = "NombreTxt";
            NombreTxt.Size = new Size(244, 43);
            NombreTxt.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 188);
            label4.Name = "label4";
            label4.Size = new Size(138, 38);
            label4.TabIndex = 1;
            label4.Text = "Teléfono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 89);
            label3.Name = "label3";
            label3.Size = new Size(133, 38);
            label3.TabIndex = 0;
            label3.Text = "Nombre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(571, 619);
            label5.Name = "label5";
            label5.Size = new Size(252, 38);
            label5.TabIndex = 3;
            label5.Text = "Tipo Movimiento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(573, 717);
            label6.Name = "label6";
            label6.Size = new Size(100, 38);
            label6.TabIndex = 4;
            label6.Text = "Fecha:";
            // 
            // InventoryDataGridView
            // 
            InventoryDataGridView.AllowUserToAddRows = false;
            InventoryDataGridView.AllowUserToDeleteRows = false;
            InventoryDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            InventoryDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            InventoryDataGridView.BackgroundColor = Color.Ivory;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Ivory;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.CadetBlue;
            dataGridViewCellStyle1.Padding = new Padding(0, 2, 0, 2);
            dataGridViewCellStyle1.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            InventoryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            InventoryDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Ivory;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.CadetBlue;
            dataGridViewCellStyle2.Padding = new Padding(0, 0, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            InventoryDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            InventoryDataGridView.Location = new Point(1022, 251);
            InventoryDataGridView.Margin = new Padding(3, 4, 3, 4);
            InventoryDataGridView.Name = "InventoryDataGridView";
            InventoryDataGridView.ReadOnly = true;
            InventoryDataGridView.RowHeadersWidth = 51;
            InventoryDataGridView.Size = new Size(839, 484);
            InventoryDataGridView.TabIndex = 5;
            InventoryDataGridView.SelectionChanged += InventoryDataGridView_SelectionChanged;
            // 
            // InsertBtn
            // 
            InsertBtn.BackColor = Color.DarkSlateGray;
            InsertBtn.FlatAppearance.BorderColor = Color.Ivory;
            InsertBtn.FlatAppearance.BorderSize = 5;
            InsertBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            InsertBtn.ForeColor = Color.White;
            InsertBtn.Location = new Point(1022, 780);
            InsertBtn.Margin = new Padding(3, 4, 3, 4);
            InsertBtn.Name = "InsertBtn";
            InsertBtn.Size = new Size(187, 55);
            InsertBtn.TabIndex = 6;
            InsertBtn.Text = "Insertar";
            InsertBtn.UseVisualStyleBackColor = false;
            InsertBtn.Click += InsertBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.Ivory;
            UpdateBtn.FlatAppearance.BorderColor = Color.Ivory;
            UpdateBtn.FlatAppearance.BorderSize = 5;
            UpdateBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            UpdateBtn.ForeColor = Color.CadetBlue;
            UpdateBtn.Location = new Point(1463, 772);
            UpdateBtn.Margin = new Padding(3, 4, 3, 4);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(187, 55);
            UpdateBtn.TabIndex = 7;
            UpdateBtn.Text = "Modificar";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Tomato;
            DeleteBtn.FlatAppearance.BorderColor = Color.Ivory;
            DeleteBtn.FlatAppearance.BorderSize = 5;
            DeleteBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(1673, 772);
            DeleteBtn.Margin = new Padding(3, 4, 3, 4);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(187, 55);
            DeleteBtn.TabIndex = 8;
            DeleteBtn.Text = "Eliminar";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // FilterBtn
            // 
            FilterBtn.FlatAppearance.BorderColor = Color.Ivory;
            FilterBtn.FlatAppearance.BorderSize = 5;
            FilterBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            FilterBtn.ForeColor = Color.CadetBlue;
            FilterBtn.Location = new Point(1673, 124);
            FilterBtn.Margin = new Padding(3, 4, 3, 4);
            FilterBtn.Name = "FilterBtn";
            FilterBtn.Size = new Size(187, 59);
            FilterBtn.TabIndex = 9;
            FilterBtn.Text = "Filtrar";
            FilterBtn.UseVisualStyleBackColor = true;
            FilterBtn.Click += FilterBtn_Click;
            // 
            // ProductoCB
            // 
            ProductoCB.Font = new Font("Segoe UI", 15.75F);
            ProductoCB.ForeColor = Color.CadetBlue;
            ProductoCB.FormattingEnabled = true;
            ProductoCB.Location = new Point(710, 125);
            ProductoCB.Margin = new Padding(3, 4, 3, 4);
            ProductoCB.Name = "ProductoCB";
            ProductoCB.Size = new Size(276, 44);
            ProductoCB.TabIndex = 10;
            // 
            // TipoMoCB
            // 
            TipoMoCB.Font = new Font("Segoe UI", 15.75F);
            TipoMoCB.ForeColor = Color.CadetBlue;
            TipoMoCB.FormattingEnabled = true;
            TipoMoCB.Location = new Point(813, 619);
            TipoMoCB.Margin = new Padding(3, 4, 3, 4);
            TipoMoCB.Name = "TipoMoCB";
            TipoMoCB.Size = new Size(155, 44);
            TipoMoCB.TabIndex = 11;
            // 
            // FechaPicker
            // 
            FechaPicker.CalendarForeColor = Color.CadetBlue;
            FechaPicker.CalendarTitleBackColor = Color.CadetBlue;
            FechaPicker.Font = new Font("Segoe UI", 15.75F);
            FechaPicker.Location = new Point(571, 780);
            FechaPicker.Margin = new Padding(3, 4, 3, 4);
            FechaPicker.Name = "FechaPicker";
            FechaPicker.Size = new Size(414, 42);
            FechaPicker.TabIndex = 12;
            // 
            // CantidadUp
            // 
            CantidadUp.Font = new Font("Segoe UI", 15.75F);
            CantidadUp.ForeColor = Color.CadetBlue;
            CantidadUp.Location = new Point(711, 213);
            CantidadUp.Margin = new Padding(3, 4, 3, 4);
            CantidadUp.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            CantidadUp.Name = "CantidadUp";
            CantidadUp.Size = new Size(275, 42);
            CantidadUp.TabIndex = 13;
            // 
            // FiltrarTxt
            // 
            FiltrarTxt.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FiltrarTxt.ForeColor = Color.CadetBlue;
            FiltrarTxt.Location = new Point(1222, 125);
            FiltrarTxt.Margin = new Padding(3, 4, 3, 4);
            FiltrarTxt.Name = "FiltrarTxt";
            FiltrarTxt.Size = new Size(428, 52);
            FiltrarTxt.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(15, 27);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(507, 417);
            panel1.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Ivory;
            panel2.BackgroundImage = Properties.Resources.logoGreen;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Controls.Add(label7);
            panel2.Location = new Point(11, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(485, 393);
            panel2.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.CadetBlue;
            label7.Location = new Point(46, 323);
            label7.Name = "label7";
            label7.Size = new Size(409, 50);
            label7.TabIndex = 17;
            label7.Text = "Registro de Inventario";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(15, 452);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(507, 520);
            panel3.TabIndex = 16;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Ivory;
            panel8.Controls.Add(panel9);
            panel8.Controls.Add(button3);
            panel8.Location = new Point(11, 355);
            panel8.Name = "panel8";
            panel8.Size = new Size(485, 145);
            panel8.TabIndex = 22;
            // 
            // panel9
            // 
            panel9.BackgroundImage = Properties.Resources.service;
            panel9.BackgroundImageLayout = ImageLayout.Zoom;
            panel9.Location = new Point(18, 15);
            panel9.Name = "panel9";
            panel9.Size = new Size(93, 115);
            panel9.TabIndex = 17;
            // 
            // button3
            // 
            button3.BackColor = Color.Ivory;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.FlatAppearance.BorderColor = Color.CadetBlue;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button3.ForeColor = Color.CadetBlue;
            button3.Location = new Point(118, 15);
            button3.Name = "button3";
            button3.Size = new Size(352, 115);
            button3.TabIndex = 0;
            button3.Text = "Servicios";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Ivory;
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(button2);
            panel6.Location = new Point(11, 188);
            panel6.Name = "panel6";
            panel6.Size = new Size(485, 147);
            panel6.TabIndex = 21;
            // 
            // panel7
            // 
            panel7.BackgroundImage = Properties.Resources.products;
            panel7.BackgroundImageLayout = ImageLayout.Zoom;
            panel7.Location = new Point(18, 16);
            panel7.Name = "panel7";
            panel7.Size = new Size(93, 115);
            panel7.TabIndex = 17;
            // 
            // button2
            // 
            button2.BackColor = Color.Ivory;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatAppearance.BorderColor = Color.CadetBlue;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button2.ForeColor = Color.CadetBlue;
            button2.Location = new Point(118, 16);
            button2.Name = "button2";
            button2.Size = new Size(352, 115);
            button2.TabIndex = 0;
            button2.Text = "Productos";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Ivory;
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(button1);
            panel4.Location = new Point(11, 21);
            panel4.Name = "panel4";
            panel4.Size = new Size(485, 143);
            panel4.TabIndex = 20;
            // 
            // panel5
            // 
            panel5.BackgroundImage = Properties.Resources.home2;
            panel5.BackgroundImageLayout = ImageLayout.Zoom;
            panel5.Location = new Point(18, 15);
            panel5.Name = "panel5";
            panel5.Size = new Size(93, 115);
            panel5.TabIndex = 17;
            // 
            // button1
            // 
            button1.BackColor = Color.Ivory;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderColor = Color.CadetBlue;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button1.ForeColor = Color.CadetBlue;
            button1.Location = new Point(118, 15);
            button1.Name = "button1";
            button1.Size = new Size(352, 115);
            button1.TabIndex = 0;
            button1.Text = "Inicio";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1898, 1001);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(FiltrarTxt);
            Controls.Add(CantidadUp);
            Controls.Add(FechaPicker);
            Controls.Add(TipoMoCB);
            Controls.Add(ProductoCB);
            Controls.Add(FilterBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(InsertBtn);
            Controls.Add(InventoryDataGridView);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1916, 1048);
            MinimumSize = new Size(1751, 1015);
            Name = "InventoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventario";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)InventoryDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)CantidadUp).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private DataGridView InventoryDataGridView;
        private Button InsertBtn;
        private TextBox NombreTxt;
        private Button UpdateBtn;
        private Button DeleteBtn;
        private Button FilterBtn;
        private ComboBox ProductoCB;
        private ComboBox TipoMoCB;
        private DateTimePicker FechaPicker;
        private MaskedTextBox telefonoMask;
        private NumericUpDown CantidadUp;
        private TextBox FiltrarTxt;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel8;
        private Panel panel9;
        private Button button3;
        private Panel panel6;
        private Panel panel7;
        private Button button2;
        private Panel panel4;
        private Panel panel5;
        private Button button1;
        private Label label7;
    }
}