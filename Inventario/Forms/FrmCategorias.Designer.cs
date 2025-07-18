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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            dgvCategorias = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            ContextMenuStrip = new ContextMenuStrip(components);
            editarMenuItem = new ToolStripMenuItem();
            eliminarMenuItem = new ToolStripMenuItem();
            btnMostrar = new Button();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            btnCreate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            ContextMenuStrip.SuspendLayout();
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
            // dgvCategorias
            // 
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.AllowUserToDeleteRows = false;
            dgvCategorias.AllowUserToResizeColumns = false;
            dgvCategorias.AllowUserToResizeRows = false;
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCategorias.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCategorias.BackgroundColor = Color.WhiteSmoke;
            dgvCategorias.BorderStyle = BorderStyle.None;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Columns.AddRange(new DataGridViewColumn[] { Id, Descripcion });
            dgvCategorias.ContextMenuStrip = ContextMenuStrip;
            dgvCategorias.Dock = DockStyle.Bottom;
            dgvCategorias.Location = new Point(0, 162);
            dgvCategorias.Margin = new Padding(1, 1, 1, 1);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.RowHeadersVisible = false;
            dgvCategorias.RowHeadersWidth = 102;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvCategorias.Size = new Size(568, 323);
            dgvCategorias.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 12;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 23;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 12;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            Descripcion.Visible = false;
            Descripcion.Width = 75;
            // 
            // ContextMenuStrip
            // 
            ContextMenuStrip.ImageScalingSize = new Size(40, 40);
            ContextMenuStrip.Items.AddRange(new ToolStripItem[] { editarMenuItem, eliminarMenuItem });
            ContextMenuStrip.Name = "contexMenu";
            ContextMenuStrip.Size = new Size(118, 48);
            ContextMenuStrip.Text = "Opciones";
            // 
            // editarMenuItem
            // 
            editarMenuItem.Name = "editarMenuItem";
            editarMenuItem.Size = new Size(117, 22);
            editarMenuItem.Text = "Editar";
            editarMenuItem.Click += editarMenuItem_Click;
            // 
            // eliminarMenuItem
            // 
            eliminarMenuItem.Name = "eliminarMenuItem";
            eliminarMenuItem.Size = new Size(117, 22);
            eliminarMenuItem.Text = "Eliminar";
            eliminarMenuItem.Click += eliminarMenuItem_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(12, 117);
            btnMostrar.Margin = new Padding(1, 1, 1, 1);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(117, 28);
            btnMostrar.TabIndex = 3;
            btnMostrar.Text = "Mostrar Categorias";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(160, 15);
            btnBuscar.Margin = new Padding(1, 1, 1, 1);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(63, 25);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(12, 15);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(144, 23);
            txtBuscar.TabIndex = 1;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(453, 15);
            btnCreate.Margin = new Padding(1, 1, 1, 1);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(105, 26);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "Nueva Categoria";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // FrmCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(568, 485);
            Controls.Add(btnCreate);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(btnMostrar);
            Controls.Add(label1);
            Controls.Add(dgvCategorias);
            Margin = new Padding(1, 1, 1, 1);
            MaximizeBox = false;
            MaximumSize = new Size(584, 524);
            MinimumSize = new Size(584, 524);
            Name = "FrmCategorias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categorias";
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ContextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvCategorias;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Descripcion;
        private Button btnMostrar;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Button btnCreate;
        private ContextMenuStrip ContextMenuStrip;
        private ToolStripMenuItem editarMenuItem;
        private ToolStripMenuItem eliminarMenuItem;
    }
}