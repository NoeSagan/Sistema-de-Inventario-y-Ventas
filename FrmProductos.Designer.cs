namespace ISW_II_2
{
    partial class FrmProductos
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
            btnNuevoProducto = new Button();
            btnEditarProducto = new Button();
            btnDesactivar = new Button();
            btnExportarProductos = new Button();
            this.cmbFiltroCategoria = new ComboBox();
            this.cmbFiltroEstado = new ComboBox();
            dgvProductos = new DataGridView();
            txtBuscarProducto = new TextBox();
            lblBuscarProducto = new Label();
            lblcategoría = new Label();
            lblEstado = new Label();
            SKU = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            Categoría = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Margen = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            StockMinimo = new DataGridViewTextBoxColumn();
            Ubicacion = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // btnNuevoProducto
            // 
            btnNuevoProducto.Location = new Point(43, 60);
            btnNuevoProducto.Name = "btnNuevoProducto";
            btnNuevoProducto.Size = new Size(153, 53);
            btnNuevoProducto.TabIndex = 0;
            btnNuevoProducto.Text = "Nuevo producto";
            btnNuevoProducto.UseVisualStyleBackColor = true;
            // 
            // btnEditarProducto
            // 
            btnEditarProducto.Location = new Point(225, 60);
            btnEditarProducto.Name = "btnEditarProducto";
            btnEditarProducto.Size = new Size(153, 53);
            btnEditarProducto.TabIndex = 1;
            btnEditarProducto.Text = "Editar producto";
            btnEditarProducto.UseVisualStyleBackColor = true;
            // 
            // btnDesactivar
            // 
            btnDesactivar.Location = new Point(407, 60);
            btnDesactivar.Name = "btnDesactivar";
            btnDesactivar.Size = new Size(153, 53);
            btnDesactivar.TabIndex = 2;
            btnDesactivar.Text = "Desactivar";
            btnDesactivar.UseVisualStyleBackColor = true;
            // 
            // btnExportarProductos
            // 
            btnExportarProductos.Location = new Point(589, 60);
            btnExportarProductos.Name = "btnExportarProductos";
            btnExportarProductos.Size = new Size(189, 53);
            btnExportarProductos.TabIndex = 3;
            btnExportarProductos.Text = "Exportar productos";
            btnExportarProductos.UseVisualStyleBackColor = true;
            // 
            // cmbFiltroCategoria
            // 
            this.cmbFiltroCategoria.FormattingEnabled = true;
            this.cmbFiltroCategoria.Location = new Point(724, 170);
            this.cmbFiltroCategoria.Name = "cmbFiltroCategoria";
            this.cmbFiltroCategoria.Size = new Size(182, 33);
            this.cmbFiltroCategoria.TabIndex = 5;
            // 
            // cmbFiltroEstado
            // 
            this.cmbFiltroEstado.FormattingEnabled = true;
            this.cmbFiltroEstado.Location = new Point(1022, 170);
            this.cmbFiltroEstado.Name = "cmbFiltroEstado";
            this.cmbFiltroEstado.Size = new Size(182, 33);
            this.cmbFiltroEstado.TabIndex = 6;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { SKU, Nombre, Marca, Categoría, PrecioCompra, PrecioVenta, Margen, Stock, StockMinimo, Ubicacion, Estado });
            dgvProductos.Location = new Point(27, 251);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.Size = new Size(1252, 731);
            dgvProductos.TabIndex = 7;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Location = new Point(188, 172);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.Size = new Size(409, 31);
            txtBuscarProducto.TabIndex = 8;
            // 
            // lblBuscarProducto
            // 
            lblBuscarProducto.AutoSize = true;
            lblBuscarProducto.Location = new Point(40, 174);
            lblBuscarProducto.Name = "lblBuscarProducto";
            lblBuscarProducto.Size = new Size(142, 25);
            lblBuscarProducto.TabIndex = 9;
            lblBuscarProducto.Text = "Buscar producto";
            // 
            // lblcategoría
            // 
            lblcategoría.AutoSize = true;
            lblcategoría.Location = new Point(630, 174);
            lblcategoría.Name = "lblcategoría";
            lblcategoría.Size = new Size(88, 25);
            lblcategoría.TabIndex = 10;
            lblcategoría.Text = "Categoría";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(950, 174);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(66, 25);
            lblEstado.TabIndex = 11;
            lblEstado.Text = "Estado";
            // 
            // SKU
            // 
            SKU.HeaderText = "SKU";
            SKU.MinimumWidth = 8;
            SKU.Name = "SKU";
            SKU.ReadOnly = true;
            SKU.Width = 150;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 150;
            // 
            // Marca
            // 
            Marca.HeaderText = "Marca";
            Marca.MinimumWidth = 8;
            Marca.Name = "Marca";
            Marca.ReadOnly = true;
            Marca.Width = 150;
            // 
            // Categoría
            // 
            Categoría.HeaderText = "Categoría";
            Categoría.MinimumWidth = 8;
            Categoría.Name = "Categoría";
            Categoría.ReadOnly = true;
            Categoría.Width = 150;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio compra";
            PrecioCompra.MinimumWidth = 8;
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.ReadOnly = true;
            PrecioCompra.Width = 150;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio venta";
            PrecioVenta.MinimumWidth = 8;
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            PrecioVenta.Width = 150;
            // 
            // Margen
            // 
            Margen.HeaderText = "Margen";
            Margen.MinimumWidth = 8;
            Margen.Name = "Margen";
            Margen.ReadOnly = true;
            Margen.Width = 150;
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.MinimumWidth = 8;
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            Stock.Width = 150;
            // 
            // StockMinimo
            // 
            StockMinimo.HeaderText = "Stock Minimo";
            StockMinimo.MinimumWidth = 8;
            StockMinimo.Name = "StockMinimo";
            StockMinimo.ReadOnly = true;
            StockMinimo.Width = 150;
            // 
            // Ubicacion
            // 
            Ubicacion.HeaderText = "Ubicación";
            Ubicacion.MinimumWidth = 8;
            Ubicacion.Name = "Ubicacion";
            Ubicacion.ReadOnly = true;
            Ubicacion.Width = 150;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 8;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Width = 150;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1307, 1012);
            Controls.Add(lblEstado);
            Controls.Add(lblcategoría);
            Controls.Add(lblBuscarProducto);
            Controls.Add(txtBuscarProducto);
            Controls.Add(dgvProductos);
            Controls.Add(this.cmbFiltroEstado);
            Controls.Add(this.cmbFiltroCategoria);
            Controls.Add(btnExportarProductos);
            Controls.Add(btnDesactivar);
            Controls.Add(btnEditarProducto);
            Controls.Add(btnNuevoProducto);
            Name = "FrmProductos";
            Text = "FrmProductos";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNuevoProducto;
        private Button btnEditarProducto;
        private Button btnDesactivar;
        private Button btnExportarProductos;
        private ComboBox cmbFiltroCategoria;
        private ComboBox cmbFiltroEstado;
        private DataGridView dgvProductos;
        private TextBox txtBuscarProducto;
        private Label lblBuscarProducto;
        private Label lblcategoría;
        private Label lblEstado;
        private DataGridViewTextBoxColumn SKU;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Categoría;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Margen;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn StockMinimo;
        private DataGridViewTextBoxColumn Ubicacion;
        private DataGridViewTextBoxColumn Estado;
    }
}