namespace Inventario.Forms
{
    partial class FrmCategorias
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
            TabControl = new TabControl();
            tabPage1 = new TabPage();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            btnMostrar = new Button();
            dgvCategorias = new DataGridView();
            tabPage2 = new TabPage();
            Id = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            TabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-7, 37);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // TabControl
            // 
            TabControl.Controls.Add(tabPage1);
            TabControl.Controls.Add(tabPage2);
            TabControl.Dock = DockStyle.Fill;
            TabControl.Location = new Point(0, 0);
            TabControl.Margin = new Padding(1);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(567, 470);
            TabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtBuscar);
            tabPage1.Controls.Add(btnBuscar);
            tabPage1.Controls.Add(btnMostrar);
            tabPage1.Controls.Add(dgvCategorias);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(1);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(1);
            tabPage1.Size = new Size(559, 442);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Categorias";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(68, 19);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(144, 23);
            txtBuscar.TabIndex = 3;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(6, 19);
            btnBuscar.Margin = new Padding(1);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(58, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(6, 100);
            btnMostrar.Margin = new Padding(1);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(117, 28);
            btnMostrar.TabIndex = 1;
            btnMostrar.Text = "Mostrar Categorias";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // dgvCategorias
            // 
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.AllowUserToDeleteRows = false;
            dgvCategorias.AllowUserToResizeRows = false;
            dgvCategorias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCategorias.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCategorias.BackgroundColor = Color.WhiteSmoke;
            dgvCategorias.BorderStyle = BorderStyle.None;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Columns.AddRange(new DataGridViewColumn[] { Id, Descripcion });
            dgvCategorias.Location = new Point(1, 130);
            dgvCategorias.Margin = new Padding(1);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.RowHeadersVisible = false;
            dgvCategorias.RowHeadersWidth = 102;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvCategorias.Size = new Size(556, 314);
            dgvCategorias.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(1);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(1);
            tabPage2.Size = new Size(559, 442);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Nueva";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 23;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            Descripcion.Visible = false;
            Descripcion.Width = 75;
            // 
            // FrmCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 470);
            Controls.Add(TabControl);
            Controls.Add(label1);
            Margin = new Padding(1);
            MaximizeBox = false;
            MaximumSize = new Size(583, 509);
            MinimumSize = new Size(337, 308);
            Name = "FrmCategorias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categorias";
            Load += FrmCategorias_Load;
            TabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl TabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvCategorias;
        private Button btnMostrar;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Descripcion;
    }
}