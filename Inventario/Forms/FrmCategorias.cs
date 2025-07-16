using Inventario.Context;
using Inventario.Forms.SubForms;
using Inventario.Interfaces;
using Inventario.Models;
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
        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            var descripcion = txtBuscar.Text;

            if (string.IsNullOrWhiteSpace(descripcion))
            {
                MessageBox.Show("La busqueda no puede contener solo espacios en blanco o estar vacia.",
                    "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var result = await _categorias.FilterByDescripcionAsync(descripcion);

            InicializarDGV();
            dgvCategorias.DataSource = result;

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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FrmCrearCategorias frmCrear = new(_categorias);
            frmCrear.Show();
        }
        private void FrmCategorias_Load(object sender, EventArgs e)
        {

        }

        private void dgvCategorias_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }
        private void editarMenuItem_Click(object sender, EventArgs e)
        {
            

        }
        private void eliminarMenuItem_Click(object sender, EventArgs e)
        {
            //var id = ObtenerId();
            var id = ObtenerId();
            var descripcion = dgvCategorias.CurrentRow.Cells[0]?.Value.ToString();

            var categorias = new CategoriasModel
            {
                Id = id,
                Descripcion = descripcion
            };

        }

        private void dgvCategorias_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex > 0)
            {
                dgvCategorias.ClearSelection();
                dgvCategorias.Rows[e.RowIndex].Selected = true;
                dgvCategorias.CurrentCell = dgvCategorias.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
        }
        public int ObtenerId()
        {
            if (dgvCategorias.SelectedCells.Count > 0 &&
                    dgvCategorias.SelectedCells.Count < 2)
            {
                var id = dgvCategorias.CurrentRow.Cells[0]?.Value.ToString();
                if (int.TryParse(id, out int _id))
                    return _id;
            }
            return 0;
        }
    }
}
