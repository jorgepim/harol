namespace BDatos.Forms
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            ServicesBtn = new Button();
            InventoryBtn = new Button();
            ProductBtn = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // ServicesBtn
            // 
            ServicesBtn.BackColor = Color.LightGray;
            ServicesBtn.BackgroundImage = Properties.Resources.service;
            ServicesBtn.BackgroundImageLayout = ImageLayout.Zoom;
            ServicesBtn.FlatAppearance.BorderSize = 0;
            ServicesBtn.FlatStyle = FlatStyle.Flat;
            ServicesBtn.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            ServicesBtn.ForeColor = Color.Gray;
            ServicesBtn.Location = new Point(15, 31);
            ServicesBtn.Margin = new Padding(3, 4, 3, 4);
            ServicesBtn.Name = "ServicesBtn";
            ServicesBtn.Size = new Size(805, 209);
            ServicesBtn.TabIndex = 0;
            ServicesBtn.Text = "Registro                Servicios";
            ServicesBtn.TextImageRelation = TextImageRelation.TextAboveImage;
            ServicesBtn.UseVisualStyleBackColor = false;
            ServicesBtn.Click += ServicesBtn_Click;
            // 
            // InventoryBtn
            // 
            InventoryBtn.BackColor = Color.WhiteSmoke;
            InventoryBtn.BackgroundImage = Properties.Resources.inventory;
            InventoryBtn.BackgroundImageLayout = ImageLayout.Zoom;
            InventoryBtn.FlatAppearance.BorderSize = 0;
            InventoryBtn.FlatStyle = FlatStyle.Flat;
            InventoryBtn.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            InventoryBtn.ForeColor = Color.Gray;
            InventoryBtn.Location = new Point(15, 31);
            InventoryBtn.Margin = new Padding(3, 4, 3, 4);
            InventoryBtn.Name = "InventoryBtn";
            InventoryBtn.Size = new Size(805, 209);
            InventoryBtn.TabIndex = 1;
            InventoryBtn.Text = "Registro              Inventario";
            InventoryBtn.UseVisualStyleBackColor = false;
            InventoryBtn.Click += InventoryBtn_Click;
            // 
            // ProductBtn
            // 
            ProductBtn.BackColor = Color.DarkGray;
            ProductBtn.BackgroundImage = Properties.Resources.products;
            ProductBtn.BackgroundImageLayout = ImageLayout.Zoom;
            ProductBtn.FlatAppearance.BorderSize = 0;
            ProductBtn.FlatStyle = FlatStyle.Flat;
            ProductBtn.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            ProductBtn.ForeColor = Color.White;
            ProductBtn.Location = new Point(15, 36);
            ProductBtn.Margin = new Padding(3, 4, 3, 4);
            ProductBtn.Name = "ProductBtn";
            ProductBtn.Size = new Size(805, 209);
            ProductBtn.TabIndex = 2;
            ProductBtn.Text = "Registro              Productos";
            ProductBtn.UseVisualStyleBackColor = false;
            ProductBtn.Click += ProductBtn_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.menuPic;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(59, 49);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(840, 900);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(ServicesBtn);
            panel2.Location = new Point(943, 360);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(839, 277);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(InventoryBtn);
            panel3.Location = new Point(943, 49);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(839, 277);
            panel3.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkGray;
            panel4.Controls.Add(ProductBtn);
            panel4.Location = new Point(943, 672);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(839, 277);
            panel4.TabIndex = 6;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(1898, 1001);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1916, 1048);
            MinimumSize = new Size(1751, 1015);
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuForm";
            Load += MenuForm_Load;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button ServicesBtn;
        private Button InventoryBtn;
        private Button ProductBtn;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}