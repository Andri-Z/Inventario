using Inventario.Context;
using Inventario.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario.Forms
{
    public partial class FrmCategorias : Form
    {
        private readonly ICategorias _categorias;
        public FrmCategorias(ICategorias categorias)
        {
            InitializeComponent();
            _categorias = categorias;
        }
        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            
        }
        private async void btnMostrar_Click(object sender, EventArgs e)
        {
            var result = await _categorias.GetCategoriasAsync();
            if (result is null || result.Count == 0)
                MessageBox.Show("No existen categorias para mostrar.",
                    "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Question);
            else
            {
                InicializarDGV();
                dgvCategorias.DataSource = result.ToList();
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            InicializarDGV();

            var texto = txtBuscar.Text;

            if (texto is null)
                MessageBox.Show("No se puede realizar esta accion.");
            else
            {
                var result = _categorias.FilterByDescripcionAsync(texto);
                dgvCategorias.DataSource = result;
            }
        }
        private void InicializarDGV()
        {
            dgvCategorias.Columns.Clear();
            dgvCategorias.AutoGenerateColumns = false;

            dgvCategorias.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Id",
                DataPropertyName = "Id"
            });
            dgvCategorias.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Descripcion",
                DataPropertyName = "Descripcion",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }
    }
}
