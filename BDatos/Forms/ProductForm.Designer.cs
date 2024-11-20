namespace BDatos.Forms
{
    partial class ProductForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            DescripcionTxt = new TextBox();
            NombreTxt = new TextBox();
            PrecioUp = new NumericUpDown();
            ProductDataGridView = new DataGridView();
            InsertBtn = new Button();
            UpdateBtn = new Button();
            DeleteBtn = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label6 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)PrecioUp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductDataGridView).BeginInit();
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
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.CadetBlue;
            label1.Location = new Point(552, 64);
            label1.Name = "label1";
            label1.Size = new Size(130, 37);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label2.ForeColor = Color.CadetBlue;
            label2.Location = new Point(552, 207);
            label2.Name = "label2";
            label2.Size = new Size(105, 37);
            label2.TabIndex = 1;
            label2.Text = "Precio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label3.ForeColor = Color.CadetBlue;
            label3.Location = new Point(1149, 60);
            label3.Name = "label3";
            label3.Size = new Size(174, 37);
            label3.TabIndex = 2;
            label3.Text = "Descripción:";
            // 
            // DescripcionTxt
            // 
            DescripcionTxt.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            DescripcionTxt.ForeColor = Color.CadetBlue;
            DescripcionTxt.Location = new Point(1342, 60);
            DescripcionTxt.Margin = new Padding(3, 4, 3, 4);
            DescripcionTxt.Multiline = true;
            DescripcionTxt.Name = "DescripcionTxt";
            DescripcionTxt.Size = new Size(471, 185);
            DescripcionTxt.TabIndex = 3;
            // 
            // NombreTxt
            // 
            NombreTxt.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            NombreTxt.ForeColor = Color.CadetBlue;
            NombreTxt.Location = new Point(733, 64);
            NombreTxt.Margin = new Padding(3, 4, 3, 4);
            NombreTxt.Name = "NombreTxt";
            NombreTxt.Size = new Size(289, 42);
            NombreTxt.TabIndex = 4;
            // 
            // PrecioUp
            // 
            PrecioUp.DecimalPlaces = 2;
            PrecioUp.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            PrecioUp.ForeColor = Color.CadetBlue;
            PrecioUp.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            PrecioUp.Location = new Point(733, 200);
            PrecioUp.Margin = new Padding(3, 4, 3, 4);
            PrecioUp.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            PrecioUp.Name = "PrecioUp";
            PrecioUp.Size = new Size(289, 42);
            PrecioUp.TabIndex = 5;
            // 
            // ProductDataGridView
            // 
            ProductDataGridView.AllowUserToAddRows = false;
            ProductDataGridView.AllowUserToDeleteRows = false;
            ProductDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ProductDataGridView.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Ivory;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.CadetBlue;
            dataGridViewCellStyle1.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.Ivory;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ProductDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ProductDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Ivory;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.CadetBlue;
            dataGridViewCellStyle2.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Ivory;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            ProductDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            ProductDataGridView.Location = new Point(552, 367);
            ProductDataGridView.Margin = new Padding(3, 4, 3, 4);
            ProductDataGridView.MultiSelect = false;
            ProductDataGridView.Name = "ProductDataGridView";
            ProductDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Ivory;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.CadetBlue;
            dataGridViewCellStyle3.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.Ivory;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            ProductDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            ProductDataGridView.RowHeadersWidth = 51;
            ProductDataGridView.Size = new Size(1262, 445);
            ProductDataGridView.TabIndex = 6;
            ProductDataGridView.SelectionChanged += ProductDataGridView_SelectionChanged;
            // 
            // InsertBtn
            // 
            InsertBtn.BackColor = Color.CadetBlue;
            InsertBtn.FlatAppearance.BorderColor = Color.CadetBlue;
            InsertBtn.FlatAppearance.BorderSize = 5;
            InsertBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            InsertBtn.ForeColor = Color.White;
            InsertBtn.Location = new Point(1655, 285);
            InsertBtn.Margin = new Padding(3, 4, 3, 4);
            InsertBtn.Name = "InsertBtn";
            InsertBtn.Size = new Size(159, 56);
            InsertBtn.TabIndex = 7;
            InsertBtn.Text = "Insertar";
            InsertBtn.UseVisualStyleBackColor = false;
            InsertBtn.Click += InsertBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.Ivory;
            UpdateBtn.FlatAppearance.BorderColor = Color.CadetBlue;
            UpdateBtn.FlatAppearance.BorderSize = 5;
            UpdateBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            UpdateBtn.ForeColor = Color.CadetBlue;
            UpdateBtn.Location = new Point(552, 840);
            UpdateBtn.Margin = new Padding(3, 4, 3, 4);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(159, 56);
            UpdateBtn.TabIndex = 8;
            UpdateBtn.Text = "Modificar";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Tomato;
            DeleteBtn.FlatAppearance.BorderColor = Color.CadetBlue;
            DeleteBtn.FlatAppearance.BorderSize = 5;
            DeleteBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(733, 840);
            DeleteBtn.Margin = new Padding(3, 4, 3, 4);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(159, 56);
            DeleteBtn.TabIndex = 9;
            DeleteBtn.Text = "Eliminar";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(14, 9);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(502, 408);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = Color.CadetBlue;
            panel2.BackgroundImage = Properties.Resources.logoWhite;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Controls.Add(label6);
            panel2.Location = new Point(8, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(485, 393);
            panel2.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(69, 312);
            label6.Name = "label6";
            label6.Size = new Size(407, 50);
            label6.TabIndex = 0;
            label6.Text = "Registro de Productos";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(14, 425);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(502, 504);
            panel3.TabIndex = 11;
            // 
            // panel8
            // 
            panel8.BackColor = Color.CadetBlue;
            panel8.Controls.Add(panel9);
            panel8.Controls.Add(button3);
            panel8.Location = new Point(8, 341);
            panel8.Name = "panel8";
            panel8.Size = new Size(485, 145);
            panel8.TabIndex = 22;
            // 
            // panel9
            // 
            panel9.BackgroundImage = Properties.Resources.inventory1;
            panel9.BackgroundImageLayout = ImageLayout.Zoom;
            panel9.Location = new Point(18, 15);
            panel9.Name = "panel9";
            panel9.Size = new Size(93, 115);
            panel9.TabIndex = 17;
            // 
            // button3
            // 
            button3.BackColor = Color.CadetBlue;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.FlatAppearance.BorderColor = Color.Ivory;
            button3.FlatAppearance.BorderSize = 5;
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(118, 15);
            button3.Name = "button3";
            button3.Size = new Size(352, 115);
            button3.TabIndex = 0;
            button3.Text = "Inventario";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.CadetBlue;
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(button2);
            panel6.Location = new Point(8, 175);
            panel6.Name = "panel6";
            panel6.Size = new Size(485, 147);
            panel6.TabIndex = 21;
            // 
            // panel7
            // 
            panel7.BackgroundImage = Properties.Resources.service1;
            panel7.BackgroundImageLayout = ImageLayout.Zoom;
            panel7.Location = new Point(18, 16);
            panel7.Name = "panel7";
            panel7.Size = new Size(93, 115);
            panel7.TabIndex = 17;
            // 
            // button2
            // 
            button2.BackColor = Color.CadetBlue;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatAppearance.BorderColor = Color.Ivory;
            button2.FlatAppearance.BorderSize = 5;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(118, 16);
            button2.Name = "button2";
            button2.Size = new Size(352, 115);
            button2.TabIndex = 0;
            button2.Text = "Servicios";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.CadetBlue;
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(button1);
            panel4.Location = new Point(8, 8);
            panel4.Name = "panel4";
            panel4.Size = new Size(485, 143);
            panel4.TabIndex = 20;
            // 
            // panel5
            // 
            panel5.BackgroundImage = Properties.Resources.home1;
            panel5.BackgroundImageLayout = ImageLayout.Zoom;
            panel5.Location = new Point(18, 15);
            panel5.Name = "panel5";
            panel5.Size = new Size(93, 115);
            panel5.TabIndex = 17;
            // 
            // button1
            // 
            button1.BackColor = Color.CadetBlue;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderColor = Color.Ivory;
            button1.FlatAppearance.BorderSize = 5;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(118, 15);
            button1.Name = "button1";
            button1.Size = new Size(352, 115);
            button1.TabIndex = 0;
            button1.Text = "Inicio";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1898, 1001);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(DeleteBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(InsertBtn);
            Controls.Add(ProductDataGridView);
            Controls.Add(PrecioUp);
            Controls.Add(NombreTxt);
            Controls.Add(DescripcionTxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1916, 1048);
            MinimumSize = new Size(1751, 1015);
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)PrecioUp).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductDataGridView).EndInit();
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
        private Label label3;
        private TextBox DescripcionTxt;
        private TextBox NombreTxt;
        private NumericUpDown PrecioUp;
        private DataGridView ProductDataGridView;
        private Button InsertBtn;
        private Button UpdateBtn;
        private Button DeleteBtn;
        private Panel panel1;
        private Panel panel2;
        private Label label6;
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
    }
}