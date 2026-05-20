namespace ISW_II_2
{
    partial class FrmDashboard
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
            pnlKpiVentas = new Panel();
            pnlKpiIngresos = new Panel();
            pnlKpiProductos = new Panel();
            pnlKpiClientes = new Panel();
            dgvUltimasVentas = new DataGridView();
            dgvAlertasStock = new DataGridView();
            dgvOrdenesPendientes = new DataGridView();
            lblAlertasStock = new Label();
            lblUltimasVentas = new Label();
            lblOrdenesPendientes = new Label();
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
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvUltimasVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlertasStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenesPendientes).BeginInit();
            pnlSidebar.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlKpiVentas
            // 
            pnlKpiVentas.Location = new Point(3, 12);
            pnlKpiVentas.Name = "pnlKpiVentas";
            pnlKpiVentas.Size = new Size(308, 195);
            pnlKpiVentas.TabIndex = 4;
            // 
            // pnlKpiIngresos
            // 
            pnlKpiIngresos.Location = new Point(328, 12);
            pnlKpiIngresos.Name = "pnlKpiIngresos";
            pnlKpiIngresos.Size = new Size(308, 195);
            pnlKpiIngresos.TabIndex = 5;
            // 
            // pnlKpiProductos
            // 
            pnlKpiProductos.Location = new Point(653, 12);
            pnlKpiProductos.Name = "pnlKpiProductos";
            pnlKpiProductos.Size = new Size(308, 195);
            pnlKpiProductos.TabIndex = 5;
            // 
            // pnlKpiClientes
            // 
            pnlKpiClientes.Location = new Point(978, 12);
            pnlKpiClientes.Name = "pnlKpiClientes";
            pnlKpiClientes.Size = new Size(308, 195);
            pnlKpiClientes.TabIndex = 5;
            // 
            // dgvUltimasVentas
            // 
            dgvUltimasVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUltimasVentas.Location = new Point(3, 502);
            dgvUltimasVentas.Name = "dgvUltimasVentas";
            dgvUltimasVentas.RowHeadersWidth = 62;
            dgvUltimasVentas.Size = new Size(1283, 196);
            dgvUltimasVentas.TabIndex = 6;
            // 
            // dgvAlertasStock
            // 
            dgvAlertasStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlertasStock.Location = new Point(3, 243);
            dgvAlertasStock.Name = "dgvAlertasStock";
            dgvAlertasStock.RowHeadersWidth = 62;
            dgvAlertasStock.Size = new Size(1283, 197);
            dgvAlertasStock.TabIndex = 7;
            // 
            // dgvOrdenesPendientes
            // 
            dgvOrdenesPendientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrdenesPendientes.Location = new Point(3, 760);
            dgvOrdenesPendientes.Name = "dgvOrdenesPendientes";
            dgvOrdenesPendientes.RowHeadersWidth = 62;
            dgvOrdenesPendientes.Size = new Size(1283, 214);
            dgvOrdenesPendientes.TabIndex = 8;
            // 
            // lblAlertasStock
            // 
            lblAlertasStock.AutoSize = true;
            lblAlertasStock.Location = new Point(3, 215);
            lblAlertasStock.Name = "lblAlertasStock";
            lblAlertasStock.Size = new Size(203, 25);
            lblAlertasStock.TabIndex = 9;
            lblAlertasStock.Text = "Alertas de de stock bajo";
            // 
            // lblUltimasVentas
            // 
            lblUltimasVentas.AutoSize = true;
            lblUltimasVentas.Location = new Point(3, 474);
            lblUltimasVentas.Name = "lblUltimasVentas";
            lblUltimasVentas.Size = new Size(185, 25);
            lblUltimasVentas.TabIndex = 10;
            lblUltimasVentas.Text = "Últimas ventas del día";
            // 
            // lblOrdenesPendientes
            // 
            lblOrdenesPendientes.AutoSize = true;
            lblOrdenesPendientes.Location = new Point(3, 733);
            lblOrdenesPendientes.Name = "lblOrdenesPendientes";
            lblOrdenesPendientes.Size = new Size(242, 25);
            lblOrdenesPendientes.TabIndex = 11;
            lblOrdenesPendientes.Text = "Órdenes de compra en curso";
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
            pnlSidebar.Location = new Point(5, 21);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(300, 977);
            pnlSidebar.TabIndex = 12;
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
            btnCerrarSesion.Click += btnCerrarSesion_Click;
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
            btnNavUsuarios.Click += btnNavUsuarios_Click;
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
            btnNavClientes.Click += btnNavClientes_Click;
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
            btnNavProductos.Click += btnNavProductos_Click;
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
            btnNavInventario.Click += btnNavInventario_Click;
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
            btnNavReportes.Click += btnNavReportes_Click;
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
            btnNavGarantias.Click += btnNavGarantias_Click;
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
            btnNavProveedores.Click += btnNavProveedores_Click;
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
            btnNavOrdenes.Click += btnNavOrdenes_Click;
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
            btnNavVentas.Click += btnNavVentas_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pnlKpiVentas);
            panel1.Controls.Add(pnlKpiIngresos);
            panel1.Controls.Add(lblOrdenesPendientes);
            panel1.Controls.Add(pnlKpiProductos);
            panel1.Controls.Add(lblUltimasVentas);
            panel1.Controls.Add(pnlKpiClientes);
            panel1.Controls.Add(lblAlertasStock);
            panel1.Controls.Add(dgvUltimasVentas);
            panel1.Controls.Add(dgvOrdenesPendientes);
            panel1.Controls.Add(dgvAlertasStock);
            panel1.Location = new Point(308, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(1296, 977);
            panel1.TabIndex = 5;
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1615, 1010);
            Controls.Add(panel1);
            Controls.Add(pnlSidebar);
            Name = "FrmDashboard";
            Text = "FrmDashboard";
            Load += FrmDashboard_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvUltimasVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlertasStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenesPendientes).EndInit();
            pnlSidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlKpiVentas;
        private Panel pnlKpiIngresos;
        private Panel pnlKpiProductos;
        private Panel pnlKpiClientes;
        private DataGridView dgvUltimasVentas;
        private DataGridView dgvAlertasStock;
        private DataGridView dgvOrdenesPendientes;
        private Label lblAlertasStock;
        private Label lblUltimasVentas;
        private Label lblOrdenesPendientes;
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
        private Panel panel1;
    }
}