namespace Inventario.Forms.SubForms
{
    partial class FrmCrearCategorias
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
            btnAgregar = new Button();
            txtAgregar = new TextBox();
            lblAgregar = new Label();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(124, 142);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(80, 29);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtAgregar
            // 
            txtAgregar.Location = new Point(91, 113);
            txtAgregar.Name = "txtAgregar";
            txtAgregar.Size = new Size(140, 23);
            txtAgregar.TabIndex = 1;
            // 
            // lblAgregar
            // 
            lblAgregar.AutoSize = true;
            lblAgregar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAgregar.Location = new Point(124, 83);
            lblAgregar.Name = "lblAgregar";
            lblAgregar.Size = new Size(76, 17);
            lblAgregar.TabIndex = 2;
            lblAgregar.Text = "Descripcion";
            // 
            // FrmCrearCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(314, 273);
            Controls.Add(lblAgregar);
            Controls.Add(txtAgregar);
            Controls.Add(btnAgregar);
            MaximizeBox = false;
            Name = "FrmCrearCategorias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear Categorias";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblAgregar;
        public Button btnAgregar;
        public TextBox txtAgregar;
    }
}