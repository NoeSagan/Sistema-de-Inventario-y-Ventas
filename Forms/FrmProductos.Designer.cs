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
            cmbFiltroCategoria = new ComboBox();
            cmbFiltroEstado = new ComboBox();
            dgvProductos = new DataGridView();
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
            txtBuscarProducto = new TextBox();
            lblBuscarProducto = new Label();
            lblcategoría = new Label();
            lblEstado = new Label();
            pnlSidebar = new Panel();
            btnCerrarSesion = new Button();
            btnNavDashboard = new Button();
            btnNavUsuarios = new Button();
            btnNavClientes = new Button();
            btnNavProductos = new Button();
            btnNavInventario = new Button();
            btnNavReportes = new Button();
            btnNavGarantias = new Button();
            btnNavProveedores = new Button();
            btnNavOrdenes = new Button();
            btnNavVentas = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            pnlSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // btnNuevoProducto
            // 
            btnNuevoProducto.Location = new Point(321, 66);
            btnNuevoProducto.Name = "btnNuevoProducto";
            btnNuevoProducto.Size = new Size(153, 53);
            btnNuevoProducto.TabIndex = 0;
            btnNuevoProducto.Text = "Nuevo producto";
            btnNuevoProducto.UseVisualStyleBackColor = true;
            // 
            // btnEditarProducto
            // 
            btnEditarProducto.Location = new Point(503, 66);
            btnEditarProducto.Name = "btnEditarProducto";
            btnEditarProducto.Size = new Size(153, 53);
            btnEditarProducto.TabIndex = 1;
            btnEditarProducto.Text = "Editar producto";
            btnEditarProducto.UseVisualStyleBackColor = true;
            // 
            // btnDesactivar
            // 
            btnDesactivar.Location = new Point(685, 66);
            btnDesactivar.Name = "btnDesactivar";
            btnDesactivar.Size = new Size(153, 53);
            btnDesactivar.TabIndex = 2;
            btnDesactivar.Text = "Desactivar";
            btnDesactivar.UseVisualStyleBackColor = true;
            // 
            // btnExportarProductos
            // 
            btnExportarProductos.Location = new Point(867, 66);
            btnExportarProductos.Name = "btnExportarProductos";
            btnExportarProductos.Size = new Size(189, 53);
            btnExportarProductos.TabIndex = 3;
            btnExportarProductos.Text = "Exportar productos";
            btnExportarProductos.UseVisualStyleBackColor = true;
            // 
            // cmbFiltroCategoria
            // 
            cmbFiltroCategoria.FormattingEnabled = true;
            cmbFiltroCategoria.Location = new Point(1002, 176);
            cmbFiltroCategoria.Name = "cmbFiltroCategoria";
            cmbFiltroCategoria.Size = new Size(182, 33);
            cmbFiltroCategoria.TabIndex = 5;
            // 
            // cmbFiltroEstado
            // 
            cmbFiltroEstado.FormattingEnabled = true;
            cmbFiltroEstado.Location = new Point(1300, 176);
            cmbFiltroEstado.Name = "cmbFiltroEstado";
            cmbFiltroEstado.Size = new Size(182, 33);
            cmbFiltroEstado.TabIndex = 6;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { SKU, Nombre, Marca, Categoría, PrecioCompra, PrecioVenta, Margen, Stock, StockMinimo, Ubicacion, Estado });
            dgvProductos.Location = new Point(316, 267);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.Size = new Size(1287, 731);
            dgvProductos.TabIndex = 7;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
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
            // txtBuscarProducto
            // 
            txtBuscarProducto.Location = new Point(466, 178);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.Size = new Size(409, 31);
            txtBuscarProducto.TabIndex = 8;
            // 
            // lblBuscarProducto
            // 
            lblBuscarProducto.AutoSize = true;
            lblBuscarProducto.Location = new Point(318, 180);
            lblBuscarProducto.Name = "lblBuscarProducto";
            lblBuscarProducto.Size = new Size(142, 25);
            lblBuscarProducto.TabIndex = 9;
            lblBuscarProducto.Text = "Buscar producto";
            // 
            // lblcategoría
            // 
            lblcategoría.AutoSize = true;
            lblcategoría.Location = new Point(908, 180);
            lblcategoría.Name = "lblcategoría";
            lblcategoría.Size = new Size(88, 25);
            lblcategoría.TabIndex = 10;
            lblcategoría.Text = "Categoría";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(1228, 180);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(66, 25);
            lblEstado.TabIndex = 11;
            lblEstado.Text = "Estado";
            // 
            // pnlSidebar
            // 
            pnlSidebar.Controls.Add(btnCerrarSesion);
            pnlSidebar.Controls.Add(btnNavDashboard);
            pnlSidebar.Controls.Add(btnNavUsuarios);
            pnlSidebar.Controls.Add(btnNavClientes);
            pnlSidebar.Controls.Add(btnNavProductos);
            pnlSidebar.Controls.Add(btnNavInventario);
            pnlSidebar.Controls.Add(btnNavReportes);
            pnlSidebar.Controls.Add(btnNavGarantias);
            pnlSidebar.Controls.Add(btnNavProveedores);
            pnlSidebar.Controls.Add(btnNavOrdenes);
            pnlSidebar.Controls.Add(btnNavVentas);
            pnlSidebar.Location = new Point(10, 21);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(300, 977);
            pnlSidebar.TabIndex = 13;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(3, 685);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(294, 56);
            btnCerrarSesion.TabIndex = 13;
            btnCerrarSesion.Tag = "Cerrar Sesión";
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // btnNavDashboard
            // 
            btnNavDashboard.Location = new Point(3, 3);
            btnNavDashboard.Name = "btnNavDashboard";
            btnNavDashboard.Size = new Size(294, 56);
            btnNavDashboard.TabIndex = 1;
            btnNavDashboard.Tag = "Dashboard";
            btnNavDashboard.Text = "Dashboard";
            btnNavDashboard.UseVisualStyleBackColor = true;
            btnNavDashboard.Click += btnNavDashboard_Click;
            // 
            // btnNavUsuarios
            // 
            btnNavUsuarios.Location = new Point(3, 561);
            btnNavUsuarios.Name = "btnNavUsuarios";
            btnNavUsuarios.Size = new Size(294, 56);
            btnNavUsuarios.TabIndex = 12;
            btnNavUsuarios.Tag = "Usuarios";
            btnNavUsuarios.Text = "Usuarios";
            btnNavUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnNavClientes
            // 
            btnNavClientes.Location = new Point(3, 375);
            btnNavClientes.Name = "btnNavClientes";
            btnNavClientes.Size = new Size(294, 56);
            btnNavClientes.TabIndex = 9;
            btnNavClientes.Tag = "Clientes";
            btnNavClientes.Text = "Clientes";
            btnNavClientes.UseVisualStyleBackColor = true;
            // 
            // btnNavProductos
            // 
            btnNavProductos.Location = new Point(3, 127);
            btnNavProductos.Name = "btnNavProductos";
            btnNavProductos.Size = new Size(294, 56);
            btnNavProductos.TabIndex = 5;
            btnNavProductos.Tag = "Productos";
            btnNavProductos.Text = "Productos";
            btnNavProductos.UseVisualStyleBackColor = true;
            // 
            // btnNavInventario
            // 
            btnNavInventario.Location = new Point(3, 189);
            btnNavInventario.Name = "btnNavInventario";
            btnNavInventario.Size = new Size(294, 56);
            btnNavInventario.TabIndex = 6;
            btnNavInventario.Tag = "Inventario";
            btnNavInventario.Text = "Inventario";
            btnNavInventario.UseVisualStyleBackColor = true;
            // 
            // btnNavReportes
            // 
            btnNavReportes.Location = new Point(3, 499);
            btnNavReportes.Name = "btnNavReportes";
            btnNavReportes.Size = new Size(294, 56);
            btnNavReportes.TabIndex = 11;
            btnNavReportes.Tag = "Reportes";
            btnNavReportes.Text = "Reportes";
            btnNavReportes.UseVisualStyleBackColor = true;
            // 
            // btnNavGarantias
            // 
            btnNavGarantias.Location = new Point(3, 437);
            btnNavGarantias.Name = "btnNavGarantias";
            btnNavGarantias.Size = new Size(294, 56);
            btnNavGarantias.TabIndex = 10;
            btnNavGarantias.Tag = "Garantías";
            btnNavGarantias.Text = "Garantías";
            btnNavGarantias.UseVisualStyleBackColor = true;
            // 
            // btnNavProveedores
            // 
            btnNavProveedores.Location = new Point(3, 251);
            btnNavProveedores.Name = "btnNavProveedores";
            btnNavProveedores.Size = new Size(294, 56);
            btnNavProveedores.TabIndex = 7;
            btnNavProveedores.Tag = "Proveedores";
            btnNavProveedores.Text = "Proveedores";
            btnNavProveedores.UseVisualStyleBackColor = true;
            // 
            // btnNavOrdenes
            // 
            btnNavOrdenes.Location = new Point(3, 313);
            btnNavOrdenes.Name = "btnNavOrdenes";
            btnNavOrdenes.Size = new Size(294, 56);
            btnNavOrdenes.TabIndex = 8;
            btnNavOrdenes.Tag = "Ordenes";
            btnNavOrdenes.Text = "Ordenes";
            btnNavOrdenes.UseVisualStyleBackColor = true;
            // 
            // btnNavVentas
            // 
            btnNavVentas.Location = new Point(3, 65);
            btnNavVentas.Name = "btnNavVentas";
            btnNavVentas.Size = new Size(294, 56);
            btnNavVentas.TabIndex = 4;
            btnNavVentas.Tag = "Ventas";
            btnNavVentas.Text = "Ventas";
            btnNavVentas.UseVisualStyleBackColor = true;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1615, 1010);
            Controls.Add(pnlSidebar);
            Controls.Add(lblEstado);
            Controls.Add(lblcategoría);
            Controls.Add(lblBuscarProducto);
            Controls.Add(txtBuscarProducto);
            Controls.Add(dgvProductos);
            Controls.Add(cmbFiltroEstado);
            Controls.Add(cmbFiltroCategoria);
            Controls.Add(btnExportarProductos);
            Controls.Add(btnDesactivar);
            Controls.Add(btnEditarProducto);
            Controls.Add(btnNuevoProducto);
            Name = "FrmProductos";
            Text = "FrmProductos";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            pnlSidebar.ResumeLayout(false);
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
        private Panel pnlSidebar;
        private Button btnCerrarSesion;
        private Button btnNavDashboard;
        private Button btnNavUsuarios;
        private Button btnNavClientes;
        private Button btnNavProductos;
        private Button btnNavInventario;
        private Button btnNavReportes;
        private Button btnNavGarantias;
        private Button btnNavProveedores;
        private Button btnNavOrdenes;
        private Button btnNavVentas;
    }
}