namespace BDatos.Forms
{
    partial class ServicesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServicesForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            NameTxtBox = new TextBox();
            PriceUpDown = new NumericUpDown();
            DurationUpDown = new NumericUpDown();
            ToleranceUpDown = new NumericUpDown();
            DescriptionTxtBox = new TextBox();
            InsertBtn = new Button();
            servicesDataGridView = new DataGridView();
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
            panel10 = new Panel();
            ((System.ComponentModel.ISupportInitialize)PriceUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DurationUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ToleranceUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)servicesDataGridView).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label1.ForeColor = Color.CadetBlue;
            label1.Location = new Point(602, 68);
            label1.Name = "label1";
            label1.Size = new Size(133, 38);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label2.ForeColor = Color.CadetBlue;
            label2.Location = new Point(621, 161);
            label2.Name = "label2";
            label2.Size = new Size(106, 38);
            label2.TabIndex = 1;
            label2.Text = "Precio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label3.ForeColor = Color.CadetBlue;
            label3.Location = new Point(1093, 64);
            label3.Name = "label3";
            label3.Size = new Size(177, 38);
            label3.TabIndex = 2;
            label3.Text = "Descripción:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label4.ForeColor = Color.CadetBlue;
            label4.Location = new Point(583, 252);
            label4.Name = "label4";
            label4.Size = new Size(144, 38);
            label4.TabIndex = 3;
            label4.Text = "Duración:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label5.ForeColor = Color.CadetBlue;
            label5.Location = new Point(1127, 245);
            label5.Name = "label5";
            label5.Size = new Size(157, 38);
            label5.TabIndex = 4;
            label5.Text = "Tolerancia:";
            // 
            // NameTxtBox
            // 
            NameTxtBox.Font = new Font("Segoe UI", 16.2F);
            NameTxtBox.ForeColor = Color.CadetBlue;
            NameTxtBox.Location = new Point(733, 69);
            NameTxtBox.Margin = new Padding(3, 4, 3, 4);
            NameTxtBox.Name = "NameTxtBox";
            NameTxtBox.Size = new Size(319, 43);
            NameTxtBox.TabIndex = 5;
            // 
            // PriceUpDown
            // 
            PriceUpDown.DecimalPlaces = 2;
            PriceUpDown.Font = new Font("Segoe UI", 16.2F);
            PriceUpDown.ForeColor = Color.CadetBlue;
            PriceUpDown.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            PriceUpDown.Location = new Point(733, 165);
            PriceUpDown.Margin = new Padding(3, 5, 3, 5);
            PriceUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            PriceUpDown.Name = "PriceUpDown";
            PriceUpDown.Size = new Size(157, 43);
            PriceUpDown.TabIndex = 6;
            // 
            // DurationUpDown
            // 
            DurationUpDown.Font = new Font("Segoe UI", 16.2F);
            DurationUpDown.ForeColor = Color.CadetBlue;
            DurationUpDown.Location = new Point(733, 252);
            DurationUpDown.Margin = new Padding(3, 5, 3, 5);
            DurationUpDown.Maximum = new decimal(new int[] { 240, 0, 0, 0 });
            DurationUpDown.Name = "DurationUpDown";
            DurationUpDown.Size = new Size(157, 43);
            DurationUpDown.TabIndex = 7;
            // 
            // ToleranceUpDown
            // 
            ToleranceUpDown.Font = new Font("Segoe UI", 16.2F);
            ToleranceUpDown.ForeColor = Color.CadetBlue;
            ToleranceUpDown.Location = new Point(1285, 244);
            ToleranceUpDown.Margin = new Padding(3, 5, 3, 5);
            ToleranceUpDown.Name = "ToleranceUpDown";
            ToleranceUpDown.Size = new Size(157, 43);
            ToleranceUpDown.TabIndex = 8;
            // 
            // DescriptionTxtBox
            // 
            DescriptionTxtBox.Font = new Font("Segoe UI", 16.2F);
            DescriptionTxtBox.ForeColor = Color.CadetBlue;
            DescriptionTxtBox.Location = new Point(1285, 68);
            DescriptionTxtBox.Margin = new Padding(3, 4, 3, 4);
            DescriptionTxtBox.Multiline = true;
            DescriptionTxtBox.Name = "DescriptionTxtBox";
            DescriptionTxtBox.Size = new Size(460, 133);
            DescriptionTxtBox.TabIndex = 9;
            // 
            // InsertBtn
            // 
            InsertBtn.BackColor = Color.CadetBlue;
            InsertBtn.FlatAppearance.BorderColor = Color.White;
            InsertBtn.FlatAppearance.BorderSize = 2;
            InsertBtn.FlatStyle = FlatStyle.Flat;
            InsertBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InsertBtn.ForeColor = Color.White;
            InsertBtn.Location = new Point(1568, 240);
            InsertBtn.Margin = new Padding(3, 4, 3, 4);
            InsertBtn.Name = "InsertBtn";
            InsertBtn.Size = new Size(177, 61);
            InsertBtn.TabIndex = 10;
            InsertBtn.Text = "Insertar";
            InsertBtn.UseVisualStyleBackColor = false;
            InsertBtn.Click += InsertBtn_Click;
            // 
            // servicesDataGridView
            // 
            dataGridViewCellStyle1.BackColor = Color.Ivory;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.CadetBlue;
            dataGridViewCellStyle1.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            servicesDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            servicesDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            servicesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            servicesDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            servicesDataGridView.BackgroundColor = Color.Ivory;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            servicesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            servicesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            servicesDataGridView.Location = new Point(38, 112);
            servicesDataGridView.Margin = new Padding(3, 4, 3, 4);
            servicesDataGridView.MultiSelect = false;
            servicesDataGridView.Name = "servicesDataGridView";
            servicesDataGridView.ReadOnly = true;
            servicesDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            servicesDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            servicesDataGridView.Size = new Size(1178, 413);
            servicesDataGridView.TabIndex = 12;
            servicesDataGridView.SelectionChanged += servicesDataGridView_SelectionChanged;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.Ivory;
            UpdateBtn.FlatAppearance.BorderColor = Color.White;
            UpdateBtn.FlatAppearance.BorderSize = 2;
            UpdateBtn.FlatStyle = FlatStyle.Flat;
            UpdateBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            UpdateBtn.ForeColor = Color.CadetBlue;
            UpdateBtn.Location = new Point(38, 29);
            UpdateBtn.Margin = new Padding(3, 4, 3, 4);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(177, 61);
            UpdateBtn.TabIndex = 13;
            UpdateBtn.Text = "Modificar";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Tomato;
            DeleteBtn.FlatAppearance.BorderColor = Color.White;
            DeleteBtn.FlatAppearance.BorderSize = 2;
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(247, 29);
            DeleteBtn.Margin = new Padding(3, 4, 3, 4);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(177, 61);
            DeleteBtn.TabIndex = 14;
            DeleteBtn.Text = "Eliminar";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(UpdateBtn);
            panel1.Controls.Add(servicesDataGridView);
            panel1.Controls.Add(DeleteBtn);
            panel1.Location = new Point(605, 353);
            panel1.Name = "panel1";
            panel1.Size = new Size(1249, 560);
            panel1.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BackColor = Color.CadetBlue;
            panel2.BackgroundImage = Properties.Resources.logoWhite;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Controls.Add(label6);
            panel2.Location = new Point(3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(485, 393);
            panel2.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(69, 312);
            label6.Name = "label6";
            label6.Size = new Size(386, 50);
            label6.TabIndex = 0;
            label6.Text = "Registro de Servicios";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(30, 423);
            panel3.Name = "panel3";
            panel3.Size = new Size(497, 501);
            panel3.TabIndex = 17;
            // 
            // panel8
            // 
            panel8.BackColor = Color.CadetBlue;
            panel8.Controls.Add(panel9);
            panel8.Controls.Add(button3);
            panel8.Location = new Point(3, 345);
            panel8.Name = "panel8";
            panel8.Size = new Size(485, 145);
            panel8.TabIndex = 19;
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
            panel6.Location = new Point(3, 179);
            panel6.Name = "panel6";
            panel6.Size = new Size(485, 147);
            panel6.TabIndex = 18;
            // 
            // panel7
            // 
            panel7.BackgroundImage = Properties.Resources.products1;
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
            button2.Text = "Productos";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.CadetBlue;
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(button1);
            panel4.Location = new Point(3, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(485, 143);
            panel4.TabIndex = 3;
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
            // panel10
            // 
            panel10.Controls.Add(panel2);
            panel10.Location = new Point(30, 16);
            panel10.Margin = new Padding(3, 4, 3, 4);
            panel10.Name = "panel10";
            panel10.Size = new Size(497, 400);
            panel10.TabIndex = 18;
            // 
            // ServicesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(1898, 1001);
            Controls.Add(panel10);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(InsertBtn);
            Controls.Add(DescriptionTxtBox);
            Controls.Add(ToleranceUpDown);
            Controls.Add(DurationUpDown);
            Controls.Add(PriceUpDown);
            Controls.Add(NameTxtBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.CadetBlue;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1916, 1048);
            MinimumSize = new Size(1751, 1015);
            Name = "ServicesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Servicios";
            ((System.ComponentModel.ISupportInitialize)PriceUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)DurationUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ToleranceUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)servicesDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel10.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox NameTxtBox;
        private NumericUpDown PriceUpDown;
        private NumericUpDown DurationUpDown;
        private NumericUpDown ToleranceUpDown;
        private TextBox DescriptionTxtBox;
        private Button InsertBtn;
        private DataGridView servicesDataGridView;
        private Button UpdateBtn;
        private Button DeleteBtn;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button button1;
        private Panel panel4;
        private Panel panel5;
        private Panel panel8;
        private Panel panel9;
        private Button button3;
        private Panel panel6;
        private Panel panel7;
        private Button button2;
        private Panel panel10;
        private Label label6;
    }
}