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

        private async void button1_Click(object sender, EventArgs e)
        {
            var result = await _categorias.GetCategorias();
            if (result is null || result.Count == 0)
                MessageBox.Show("No existen categorias para mostrar.");
        }
    }
}
