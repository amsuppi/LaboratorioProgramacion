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

        clsProductos producto;               
        public frmAbmProductos()
        {
            InitializeComponent();
            producto = new clsProductos();
            producto.conexion();

            cmbCategoria.Items.Add("Frutas");
            cmbCategoria.Items.Add("Verduras");
            cmbCategoria.Items.Add("Legumbres");
            cmbCategoria.Items.Add("Huevos");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
            int Codigo = (int)nudCodigo.Value;
            string Nombre = txtNombre.Text;
            string Precio = txtPrecio.Text;
            int Stock = (int)nudStock.Value;
            string Descripcion = txtNombre.Text;
            string Categoria = txtNombre.Text;

            producto.agregarProducto(Codigo, Nombre, Precio, Stock, Descripcion, Categoria);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int Codigo = (int)nudCodigo.Value;
            string Nombre = txtNombre.Text;
            string Precio = txtPrecio.Text;
            int Stock = (int)nudStock.Value;
            string Descripcion = txtNombre.Text;
            string Categoria = txtNombre.Text;

            producto.modificarProducto(Codigo, Nombre, Precio, Stock, Descripcion, Categoria);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int Codigo = (int)nudCodigo.Value;

            producto.eliminarProducto(Codigo);  
        }
    }
}
