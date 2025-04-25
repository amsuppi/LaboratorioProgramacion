using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioProgramacion
{
    public partial class frmAbmProductos : Form
    {
        public frmAbmProductos()
        {
            InitializeComponent();
            clsProductos producto = new clsProductos();
            producto.conexion();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsProductos producto = new clsProductos();
            int Codigo = (int)nudCodigo.Value;
            string Nombre = txtNombre.Text;
            string Precio = txtPrecio.Text;
            int Stock = (int)nudStock.Value;
            string Descripcion = txtNombre.Text;
            string Categoria = txtNombre.Text;

            producto.agregarProducto(Codigo, Nombre, Precio, Stock, Descripcion, Categoria);
        }
    }
}
