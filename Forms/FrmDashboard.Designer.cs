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
            lblNomUsuario = new Label();
            btnCerrarSesion = new Button();
            txtUsuarioConectado = new TextBox();
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
            pnlKpiVentas.Location = new Point(2, 12);
            pnlKpiVentas.Margin = new Padding(2);
            pnlKpiVentas.Name = "pnlKpiVentas";
            pnlKpiVentas.Size = new Size(308, 195);
            pnlKpiVentas.TabIndex = 4;
            // 
            // pnlKpiIngresos
            // 
            pnlKpiIngresos.Location = new Point(328, 12);
            pnlKpiIngresos.Margin = new Padding(2);
            pnlKpiIngresos.Name = "pnlKpiIngresos";
            pnlKpiIngresos.Size = new Size(308, 195);
            pnlKpiIngresos.TabIndex = 5;
            // 
            // pnlKpiProductos
            // 
            pnlKpiProductos.Location = new Point(652, 12);
            pnlKpiProductos.Margin = new Padding(2);
            pnlKpiProductos.Name = "pnlKpiProductos";
            pnlKpiProductos.Size = new Size(308, 195);
            pnlKpiProductos.TabIndex = 5;
            // 
            // pnlKpiClientes
            // 
            pnlKpiClientes.Location = new Point(978, 12);
            pnlKpiClientes.Margin = new Padding(2);
            pnlKpiClientes.Name = "pnlKpiClientes";
            pnlKpiClientes.Size = new Size(308, 195);
            pnlKpiClientes.TabIndex = 5;
            // 
            // dgvUltimasVentas
            // 
            dgvUltimasVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUltimasVentas.Location = new Point(2, 502);
            dgvUltimasVentas.Margin = new Padding(2);
            dgvUltimasVentas.Name = "dgvUltimasVentas";
            dgvUltimasVentas.RowHeadersWidth = 62;
            dgvUltimasVentas.Size = new Size(1282, 196);
            dgvUltimasVentas.TabIndex = 6;
            // 
            // dgvAlertasStock
            // 
            dgvAlertasStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlertasStock.Location = new Point(2, 242);
            dgvAlertasStock.Margin = new Padding(2);
            dgvAlertasStock.Name = "dgvAlertasStock";
            dgvAlertasStock.RowHeadersWidth = 62;
            dgvAlertasStock.Size = new Size(1282, 198);
            dgvAlertasStock.TabIndex = 7;
            // 
            // dgvOrdenesPendientes
            // 
            dgvOrdenesPendientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrdenesPendientes.Location = new Point(2, 760);
            dgvOrdenesPendientes.Margin = new Padding(2);
            dgvOrdenesPendientes.Name = "dgvOrdenesPendientes";
            dgvOrdenesPendientes.RowHeadersWidth = 62;
            dgvOrdenesPendientes.Size = new Size(1282, 214);
            dgvOrdenesPendientes.TabIndex = 8;
            // 
            // lblAlertasStock
            // 
            lblAlertasStock.AutoSize = true;
            lblAlertasStock.Location = new Point(2, 215);
            lblAlertasStock.Margin = new Padding(2, 0, 2, 0);
            lblAlertasStock.Name = "lblAlertasStock";
            lblAlertasStock.Size = new Size(203, 25);
            lblAlertasStock.TabIndex = 9;
            lblAlertasStock.Text = "Alertas de de stock bajo";
            // 
            // lblUltimasVentas
            // 
            lblUltimasVentas.AutoSize = true;
            lblUltimasVentas.Location = new Point(2, 474);
            lblUltimasVentas.Margin = new Padding(2, 0, 2, 0);
            lblUltimasVentas.Name = "lblUltimasVentas";
            lblUltimasVentas.Size = new Size(185, 25);
            lblUltimasVentas.TabIndex = 10;
            lblUltimasVentas.Text = "Últimas ventas del día";
            // 
            // lblOrdenesPendientes
            // 
            lblOrdenesPendientes.AutoSize = true;
            lblOrdenesPendientes.Location = new Point(2, 732);
            lblOrdenesPendientes.Margin = new Padding(2, 0, 2, 0);
            lblOrdenesPendientes.Name = "lblOrdenesPendientes";
            lblOrdenesPendientes.Size = new Size(242, 25);
            lblOrdenesPendientes.TabIndex = 11;
            lblOrdenesPendientes.Text = "Órdenes de compra en curso";
            // 
            // pnlSidebar
            // 
            pnlSidebar.Controls.Add(lblNomUsuario);
            pnlSidebar.Controls.Add(btnCerrarSesion);
            pnlSidebar.Controls.Add(txtUsuarioConectado);
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
            pnlSidebar.Margin = new Padding(2);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(300, 978);
            pnlSidebar.TabIndex = 12;
            // 
            // lblNomUsuario
            // 
            lblNomUsuario.AutoSize = true;
            lblNomUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomUsuario.Location = new Point(52, 892);
            lblNomUsuario.Margin = new Padding(2, 0, 2, 0);
            lblNomUsuario.Name = "lblNomUsuario";
            lblNomUsuario.Size = new Size(196, 25);
            lblNomUsuario.TabIndex = 14;
            lblNomUsuario.Text = "Rol de Usuario Actual";
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(2, 685);
            btnCerrarSesion.Margin = new Padding(2);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(294, 56);
            btnCerrarSesion.TabIndex = 13;
            btnCerrarSesion.Tag = "Cerrar Sesión";
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // txtUsuarioConectado
            // 
            txtUsuarioConectado.BorderStyle = BorderStyle.FixedSingle;
            txtUsuarioConectado.Location = new Point(9, 920);
            txtUsuarioConectado.Margin = new Padding(2);
            txtUsuarioConectado.Name = "txtUsuarioConectado";
            txtUsuarioConectado.Size = new Size(287, 31);
            txtUsuarioConectado.TabIndex = 13;
            txtUsuarioConectado.TextChanged += txtUsuarioConectado_TextChanged;
            // 
            // btnNavDashboard
            // 
            btnNavDashboard.Location = new Point(2, 2);
            btnNavDashboard.Margin = new Padding(2);
            btnNavDashboard.Name = "btnNavDashboard";
            btnNavDashboard.Size = new Size(294, 56);
            btnNavDashboard.TabIndex = 1;
            btnNavDashboard.Tag = "Dashboard";
            btnNavDashboard.Text = "Dashboard";
            btnNavDashboard.UseVisualStyleBackColor = true;
            // 
            // btnNavUsuarios
            // 
            btnNavUsuarios.Location = new Point(2, 561);
            btnNavUsuarios.Margin = new Padding(2);
            btnNavUsuarios.Name = "btnNavUsuarios";
            btnNavUsuarios.Size = new Size(294, 56);
            btnNavUsuarios.TabIndex = 12;
            btnNavUsuarios.Tag = "Usuarios";
            btnNavUsuarios.Text = "Usuarios";
            btnNavUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnNavClientes
            // 
            btnNavClientes.Location = new Point(2, 375);
            btnNavClientes.Margin = new Padding(2);
            btnNavClientes.Name = "btnNavClientes";
            btnNavClientes.Size = new Size(294, 56);
            btnNavClientes.TabIndex = 9;
            btnNavClientes.Tag = "Clientes";
            btnNavClientes.Text = "Clientes";
            btnNavClientes.UseVisualStyleBackColor = true;
            // 
            // btnNavProductos
            // 
            btnNavProductos.Location = new Point(2, 128);
            btnNavProductos.Margin = new Padding(2);
            btnNavProductos.Name = "btnNavProductos";
            btnNavProductos.Size = new Size(294, 56);
            btnNavProductos.TabIndex = 5;
            btnNavProductos.Tag = "Productos";
            btnNavProductos.Text = "Productos";
            btnNavProductos.UseVisualStyleBackColor = true;
            // 
            // btnNavInventario
            // 
            btnNavInventario.Location = new Point(2, 189);
            btnNavInventario.Margin = new Padding(2);
            btnNavInventario.Name = "btnNavInventario";
            btnNavInventario.Size = new Size(294, 56);
            btnNavInventario.TabIndex = 6;
            btnNavInventario.Tag = "Inventario";
            btnNavInventario.Text = "Inventario";
            btnNavInventario.UseVisualStyleBackColor = true;
            // 
            // btnNavReportes
            // 
            btnNavReportes.Location = new Point(2, 499);
            btnNavReportes.Margin = new Padding(2);
            btnNavReportes.Name = "btnNavReportes";
            btnNavReportes.Size = new Size(294, 56);
            btnNavReportes.TabIndex = 11;
            btnNavReportes.Tag = "Reportes";
            btnNavReportes.Text = "Reportes";
            btnNavReportes.UseVisualStyleBackColor = true;
            // 
            // btnNavGarantias
            // 
            btnNavGarantias.Location = new Point(2, 438);
            btnNavGarantias.Margin = new Padding(2);
            btnNavGarantias.Name = "btnNavGarantias";
            btnNavGarantias.Size = new Size(294, 56);
            btnNavGarantias.TabIndex = 10;
            btnNavGarantias.Tag = "Garantías";
            btnNavGarantias.Text = "Garantías";
            btnNavGarantias.UseVisualStyleBackColor = true;
            // 
            // btnNavProveedores
            // 
            btnNavProveedores.Location = new Point(2, 251);
            btnNavProveedores.Margin = new Padding(2);
            btnNavProveedores.Name = "btnNavProveedores";
            btnNavProveedores.Size = new Size(294, 56);
            btnNavProveedores.TabIndex = 7;
            btnNavProveedores.Tag = "Proveedores";
            btnNavProveedores.Text = "Proveedores";
            btnNavProveedores.UseVisualStyleBackColor = true;
            // 
            // btnNavOrdenes
            // 
            btnNavOrdenes.Location = new Point(2, 312);
            btnNavOrdenes.Margin = new Padding(2);
            btnNavOrdenes.Name = "btnNavOrdenes";
            btnNavOrdenes.Size = new Size(294, 56);
            btnNavOrdenes.TabIndex = 8;
            btnNavOrdenes.Tag = "Ordenes";
            btnNavOrdenes.Text = "Ordenes";
            btnNavOrdenes.UseVisualStyleBackColor = true;
            // 
            // btnNavVentas
            // 
            btnNavVentas.Location = new Point(2, 65);
            btnNavVentas.Margin = new Padding(2);
            btnNavVentas.Name = "btnNavVentas";
            btnNavVentas.Size = new Size(294, 56);
            btnNavVentas.TabIndex = 4;
            btnNavVentas.Tag = "Ventas";
            btnNavVentas.Text = "Ventas";
            btnNavVentas.UseVisualStyleBackColor = true;
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
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1296, 978);
            panel1.TabIndex = 5;
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1615, 1010);
            Controls.Add(panel1);
            Controls.Add(pnlSidebar);
            Margin = new Padding(2);
            Name = "FrmDashboard";
            Text = "FrmDashboard";
            ((System.ComponentModel.ISupportInitialize)dgvUltimasVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlertasStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenesPendientes).EndInit();
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
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
        private Label lblNomUsuario;
        private TextBox txtUsuarioConectado;
    }
}