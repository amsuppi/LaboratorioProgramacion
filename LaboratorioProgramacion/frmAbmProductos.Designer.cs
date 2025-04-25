namespace LaboratorioProgramacion
{
    partial class frmAbmProductos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.rtxtDescripcion = new System.Windows.Forms.RichTextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.nudCodigo = new System.Windows.Forms.NumericUpDown();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodigo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(266, 51);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(223, 26);
            this.txtNombre.TabIndex = 0;
            // 
            // nudStock
            // 
            this.nudStock.Location = new System.Drawing.Point(266, 122);
            this.nudStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudStock.Name = "nudStock";
            this.nudStock.Size = new System.Drawing.Size(225, 26);
            this.nudStock.TabIndex = 1;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(18, 120);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(214, 26);
            this.txtPrecio.TabIndex = 2;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(18, 169);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(78, 20);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(261, 95);
            this.lblStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(50, 20);
            this.lblStock.TabIndex = 5;
            this.lblStock.Text = "Stock";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(18, 95);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(53, 20);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(18, 22);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 20);
            this.lblCodigo.TabIndex = 7;
            this.lblCodigo.Text = "Codigo";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(378, 452);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 35);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(18, 194);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(470, 28);
            this.cmbCategoria.TabIndex = 9;
            // 
            // rtxtDescripcion
            // 
            this.rtxtDescripcion.Location = new System.Drawing.Point(18, 274);
            this.rtxtDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtxtDescripcion.Name = "rtxtDescripcion";
            this.rtxtDescripcion.Size = new System.Drawing.Size(470, 146);
            this.rtxtDescripcion.TabIndex = 10;
            this.rtxtDescripcion.Text = "";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(18, 249);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(92, 20);
            this.lblDescripcion.TabIndex = 11;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // nudCodigo
            // 
            this.nudCodigo.Location = new System.Drawing.Point(18, 51);
            this.nudCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudCodigo.Name = "nudCodigo";
            this.nudCodigo.Size = new System.Drawing.Size(216, 26);
            this.nudCodigo.TabIndex = 12;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(261, 22);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Nombre";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(198, 452);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(112, 35);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(18, 452);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 35);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // frmAbmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 511);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.nudCodigo);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.rtxtDescripcion);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.nudStock);
            this.Controls.Add(this.txtNombre);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAbmProductos";
            this.Text = "ABM Productos";
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodigo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.NumericUpDown nudStock;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.RichTextBox rtxtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.NumericUpDown nudCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
    }
}

