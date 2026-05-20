namespace ISW_II_2
{
    partial class FrmClientes
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
            btnNuevoCliente = new Button();
            btnEditarCliente = new Button();
            btnVerHistorialCliente = new Button();
            txtBuscarCliente = new TextBox();
            dataGridView1 = new DataGridView();
            Cedula_Pasaporte = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            NumCompras = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            ultimaCompra = new DataGridViewTextBoxColumn();
            TotalGastado = new DataGridViewTextBoxColumn();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            pnlSidebar.TabIndex = 15;
            pnlSidebar.Paint += pnlSidebar_Paint;
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
            // btnNuevoCliente
            // 
            btnNuevoCliente.Location = new Point(585, 86);
            btnNuevoCliente.Name = "btnNuevoCliente";
            btnNuevoCliente.Size = new Size(230, 80);
            btnNuevoCliente.TabIndex = 16;
            btnNuevoCliente.Text = "Nuevo cliente";
            btnNuevoCliente.UseVisualStyleBackColor = true;
            // 
            // btnEditarCliente
            // 
            btnEditarCliente.Location = new Point(338, 90);
            btnEditarCliente.Name = "btnEditarCliente";
            btnEditarCliente.Size = new Size(230, 76);
            btnEditarCliente.TabIndex = 17;
            btnEditarCliente.Text = "Editar";
            btnEditarCliente.UseVisualStyleBackColor = true;
            // 
            // btnVerHistorialCliente
            // 
            btnVerHistorialCliente.Location = new Point(853, 86);
            btnVerHistorialCliente.Name = "btnVerHistorialCliente";
            btnVerHistorialCliente.Size = new Size(230, 80);
            btnVerHistorialCliente.TabIndex = 18;
            btnVerHistorialCliente.Text = "Ver historial";
            btnVerHistorialCliente.UseVisualStyleBackColor = true;
            // 
            // txtBuscarCliente
            // 
            txtBuscarCliente.Location = new Point(1092, 311);
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.Size = new Size(511, 31);
            txtBuscarCliente.TabIndex = 19;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Cedula_Pasaporte, Nombre, Telefono, Email, NumCompras, Direccion, ultimaCompra, TotalGastado });
            dataGridView1.Location = new Point(338, 357);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1265, 641);
            dataGridView1.TabIndex = 20;
            // 
            // Cedula_Pasaporte
            // 
            Cedula_Pasaporte.HeaderText = "Cédula/Pasaporte";
            Cedula_Pasaporte.MinimumWidth = 8;
            Cedula_Pasaporte.Name = "Cedula_Pasaporte";
            Cedula_Pasaporte.Width = 150;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.Width = 150;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Teléfono";
            Telefono.MinimumWidth = 8;
            Telefono.Name = "Telefono";
            Telefono.Width = 150;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 8;
            Email.Name = "Email";
            Email.Width = 150;
            // 
            // NumCompras
            // 
            NumCompras.HeaderText = " # Compras";
            NumCompras.MinimumWidth = 8;
            NumCompras.Name = "NumCompras";
            NumCompras.Width = 150;
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Dirección";
            Direccion.MinimumWidth = 8;
            Direccion.Name = "Direccion";
            Direccion.Width = 150;
            // 
            // ultimaCompra
            // 
            ultimaCompra.HeaderText = "Última compra";
            ultimaCompra.MinimumWidth = 8;
            ultimaCompra.Name = "ultimaCompra";
            ultimaCompra.Width = 150;
            // 
            // TotalGastado
            // 
            TotalGastado.HeaderText = "Total gastado";
            TotalGastado.MinimumWidth = 8;
            TotalGastado.Name = "TotalGastado";
            TotalGastado.Width = 150;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1615, 1010);
            Controls.Add(dataGridView1);
            Controls.Add(txtBuscarCliente);
            Controls.Add(btnVerHistorialCliente);
            Controls.Add(btnEditarCliente);
            Controls.Add(btnNuevoCliente);
            Controls.Add(pnlSidebar);
            Name = "FrmClientes";
            Text = "FrmClientes";
            pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Button btnNuevoCliente;
        private Button btnEditarCliente;
        private Button btnVerHistorialCliente;
        private TextBox txtBuscarCliente;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Cedula_Pasaporte;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn NumCompras;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn ultimaCompra;
        private DataGridViewTextBoxColumn TotalGastado;
    }
}