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
            btnBuscar = new Button();
            dgvCategorias = new DataGridView();
            tabPage2 = new TabPage();
            TabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-16, 100);
            label1.Name = "label1";
            label1.Size = new Size(0, 41);
            label1.TabIndex = 0;
            // 
            // TabControl
            // 
            TabControl.Controls.Add(tabPage1);
            TabControl.Controls.Add(tabPage2);
            TabControl.Dock = DockStyle.Fill;
            TabControl.Location = new Point(0, 0);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1316, 1069);
            TabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnBuscar);
            tabPage1.Controls.Add(dgvCategorias);
            tabPage1.Location = new Point(10, 58);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1296, 1001);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Categorias";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(3, 24);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(188, 58);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvCategorias
            // 
            dgvCategorias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvCategorias.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dgvCategorias.BackgroundColor = Color.WhiteSmoke;
            dgvCategorias.BorderStyle = BorderStyle.None;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Enabled = false;
            dgvCategorias.Location = new Point(3, 355);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.RowHeadersWidth = 102;
            dgvCategorias.Size = new Size(1290, 643);
            dgvCategorias.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(10, 58);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1296, 1001);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Nueva";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // FrmCategorias
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1316, 1069);
            Controls.Add(TabControl);
            Controls.Add(label1);
            MinimumSize = new Size(795, 774);
            Name = "FrmCategorias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categorias";
            TabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
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
        private Button btnBuscar;
    }
}