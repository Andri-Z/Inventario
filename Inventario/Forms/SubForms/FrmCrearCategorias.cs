using Inventario.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario.Forms.SubForms
{
    public partial class FrmCrearCategorias : Form
    {
        private readonly ICategorias _categorias;
        public FrmCrearCategorias(ICategorias categorias)
        {
            InitializeComponent();
            _categorias = categorias;
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            var descripcion = txtAgregar.Text;

            if (string.IsNullOrEmpty(descripcion))
            {
                MessageBox.Show("Entrada no valida.");
                return;
            }

            var result = await _categorias.CreateCategoriaAsync(descripcion);
            if (result is not null)
            {
                MessageBox.Show("Categoria creada satisfactoriamente","Mensaje",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Este producto ya existe.","Mensaje",
                    MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }
    }
}
