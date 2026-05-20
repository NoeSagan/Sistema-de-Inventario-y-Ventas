namespace ISW_II_2
{
    partial class FrmVentas
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
            pnlBusqueda = new Panel();
            pnlCarrito = new Panel();
            txtBuscarProducto = new TextBox();
            btnBuscar = new Button();
            dgvProductos = new DataGridView();
            cmbCliente = new ComboBox();
            dgvCarrito = new DataGridView();
            button3 = new Button();
            btnAgregarCarrito = new Button();
            button5 = new Button();
            nudCantidad = new NumericUpDown();
            lblCantidad = new Label();
            cmbMetodoPago = new ComboBox();
            QuitarProducto = new DataGridViewButtonColumn();
            btnQuitarItem = new Button();
            lblDescuentoMonto = new Label();
            SKU = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            AgregarProducto = new DataGridViewButtonColumn();
            pnlBusqueda.SuspendLayout();
            pnlCarrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.Controls.Add(lblCantidad);
            pnlBusqueda.Controls.Add(nudCantidad);
            pnlBusqueda.Controls.Add(dgvProductos);
            pnlBusqueda.Controls.Add(btnAgregarCarrito);
            pnlBusqueda.Controls.Add(btnBuscar);
            pnlBusqueda.Controls.Add(txtBuscarProducto);
            pnlBusqueda.Location = new Point(12, 12);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(1213, 658);
            pnlBusqueda.TabIndex = 0;
            pnlBusqueda.Paint += panel1_Paint;
            // 
            // pnlCarrito
            // 
            pnlCarrito.Controls.Add(lblDescuentoMonto);
            pnlCarrito.Controls.Add(cmbMetodoPago);
            pnlCarrito.Controls.Add(button5);
            pnlCarrito.Controls.Add(button3);
            pnlCarrito.Controls.Add(btnQuitarItem);
            pnlCarrito.Controls.Add(dgvCarrito);
            pnlCarrito.Controls.Add(cmbCliente);
            pnlCarrito.Location = new Point(12, 676);
            pnlCarrito.Name = "pnlCarrito";
            pnlCarrito.Size = new Size(1213, 696);
            pnlCarrito.TabIndex = 1;
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Location = new Point(9, 12);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.Size = new Size(330, 31);
            txtBuscarProducto.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(375, 9);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 34);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { SKU, Producto, Marca, Precio, Stock, AgregarProducto });
            dgvProductos.Location = new Point(6, 61);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.Size = new Size(1181, 525);
            dgvProductos.TabIndex = 2;
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(883, 20);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(327, 33);
            cmbCliente.TabIndex = 2;
            // 
            // dgvCarrito
            // 
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Columns.AddRange(new DataGridViewColumn[] { QuitarProducto });
            dgvCarrito.Location = new Point(9, 73);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.RowHeadersWidth = 62;
            dgvCarrito.Size = new Size(1201, 450);
            dgvCarrito.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(604, 643);
            button3.Name = "button3";
            button3.Size = new Size(300, 50);
            button3.TabIndex = 4;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCarrito
            // 
            btnAgregarCarrito.Location = new Point(1007, 602);
            btnAgregarCarrito.Name = "btnAgregarCarrito";
            btnAgregarCarrito.Size = new Size(180, 42);
            btnAgregarCarrito.TabIndex = 5;
            btnAgregarCarrito.Text = "Agregar al carrito";
            btnAgregarCarrito.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(910, 643);
            button5.Name = "button5";
            button5.Size = new Size(300, 50);
            button5.TabIndex = 6;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(790, 609);
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(83, 31);
            nudCantidad.TabIndex = 7;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(635, 611);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(149, 25);
            lblCantidad.TabIndex = 8;
            lblCantidad.Text = "Agregar cantidad";
            // 
            // cmbMetodoPago
            // 
            cmbMetodoPago.FormattingEnabled = true;
            cmbMetodoPago.Items.AddRange(new object[] { "Efectivo", "Tarjeta de crédito", "Tarjeta de débito", "Transferencia bancaria", "Pago mixto" });
            cmbMetodoPago.Location = new Point(679, 535);
            cmbMetodoPago.Name = "cmbMetodoPago";
            cmbMetodoPago.Size = new Size(335, 33);
            cmbMetodoPago.TabIndex = 7;
            // 
            // QuitarProducto
            // 
            QuitarProducto.HeaderText = "Quitar";
            QuitarProducto.MinimumWidth = 8;
            QuitarProducto.Name = "QuitarProducto";
            QuitarProducto.Width = 150;
            // 
            // btnQuitarItem
            // 
            btnQuitarItem.Location = new Point(1032, 529);
            btnQuitarItem.Name = "btnQuitarItem";
            btnQuitarItem.Size = new Size(178, 42);
            btnQuitarItem.TabIndex = 3;
            btnQuitarItem.Text = "Quitar Item";
            btnQuitarItem.UseVisualStyleBackColor = true;
            // 
            // lblDescuentoMonto
            // 
            lblDescuentoMonto.AutoSize = true;
            lblDescuentoMonto.Location = new Point(9, 538);
            lblDescuentoMonto.Name = "lblDescuentoMonto";
            lblDescuentoMonto.Size = new Size(59, 25);
            lblDescuentoMonto.TabIndex = 8;
            lblDescuentoMonto.Text = "label1";
            // 
            // SKU
            // 
            SKU.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SKU.HeaderText = "SKU";
            SKU.MinimumWidth = 8;
            SKU.Name = "SKU";
            // 
            // Producto
            // 
            Producto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 8;
            Producto.Name = "Producto";
            // 
            // Marca
            // 
            Marca.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Marca.HeaderText = "Marca";
            Marca.MinimumWidth = 8;
            Marca.Name = "Marca";
            // 
            // Precio
            // 
            Precio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 8;
            Precio.Name = "Precio";
            // 
            // Stock
            // 
            Stock.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Stock.HeaderText = "Stock";
            Stock.MinimumWidth = 8;
            Stock.Name = "Stock";
            // 
            // AgregarProducto
            // 
            AgregarProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AgregarProducto.HeaderText = "Agregar";
            AgregarProducto.MinimumWidth = 8;
            AgregarProducto.Name = "AgregarProducto";
            // 
            // FrmVentas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 1393);
            Controls.Add(pnlCarrito);
            Controls.Add(pnlBusqueda);
            Name = "FrmVentas";
            Text = "FrmVentas";
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            pnlCarrito.ResumeLayout(false);
            pnlCarrito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBusqueda;
        private Panel pnlCarrito;
        private DataGridView dgvProductos;
        private Button btnBuscar;
        private TextBox txtBuscarProducto;
        private Button button5;
        private Button btnAgregarCarrito;
        private Button button3;
        private DataGridView dgvCarrito;
        private ComboBox cmbCliente;
        private Label lblCantidad;
        private NumericUpDown nudCantidad;
        private ComboBox cmbMetodoPago;
        private DataGridViewButtonColumn QuitarProducto;
        private Button btnQuitarItem;
        private Label lblDescuentoMonto;
        private DataGridViewTextBoxColumn SKU;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewButtonColumn AgregarProducto;
    }
}