using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ISW_II_2
{
    partial class FrmProveedores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            btnNuevoProveedor = new Button();
            btnEditarProveedor = new Button();
            btnVerOrdenesProveedor = new Button();
            btnDesempeno = new Button();
            dgvProveedores = new DataGridView();
            RNC = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Contacto = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            CondicionPago = new DataGridViewTextBoxColumn();
            TEntrega = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
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
            ((ISupportInitialize)dgvProveedores).BeginInit();
            pnlSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // btnNuevoProveedor
            // 
            btnNuevoProveedor.Location = new Point(569, 139);
            btnNuevoProveedor.Name = "btnNuevoProveedor";
            btnNuevoProveedor.Size = new Size(175, 54);
            btnNuevoProveedor.TabIndex = 0;
            btnNuevoProveedor.Text = "Nuevo proveedor";
            btnNuevoProveedor.UseVisualStyleBackColor = true;
            btnNuevoProveedor.Click += button1_Click;
            // 
            // btnEditarProveedor
            // 
            btnEditarProveedor.Location = new Point(776, 139);
            btnEditarProveedor.Name = "btnEditarProveedor";
            btnEditarProveedor.Size = new Size(175, 54);
            btnEditarProveedor.TabIndex = 1;
            btnEditarProveedor.Text = "Editar";
            btnEditarProveedor.UseVisualStyleBackColor = true;
            btnEditarProveedor.Click += button2_Click;
            // 
            // btnVerOrdenesProveedor
            // 
            btnVerOrdenesProveedor.Location = new Point(983, 139);
            btnVerOrdenesProveedor.Name = "btnVerOrdenesProveedor";
            btnVerOrdenesProveedor.Size = new Size(175, 54);
            btnVerOrdenesProveedor.TabIndex = 2;
            btnVerOrdenesProveedor.Text = "Ver órdenes";
            btnVerOrdenesProveedor.UseVisualStyleBackColor = true;
            btnVerOrdenesProveedor.Click += button3_Click;
            // 
            // btnDesempeno
            // 
            btnDesempeno.Location = new Point(1190, 139);
            btnDesempeno.Name = "btnDesempeno";
            btnDesempeno.Size = new Size(175, 54);
            btnDesempeno.TabIndex = 3;
            btnDesempeno.Text = "Desempeño";
            btnDesempeno.UseVisualStyleBackColor = true;
            btnDesempeno.Click += button4_Click;
            // 
            // dgvProveedores
            // 
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Columns.AddRange(new DataGridViewColumn[] { RNC, Nombre, Contacto, Telefono, Email, CondicionPago, TEntrega, Estado });
            dgvProveedores.Location = new Point(335, 250);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.RowHeadersWidth = 62;
            dgvProveedores.Size = new Size(1268, 739);
            dgvProveedores.TabIndex = 4;
            // 
            // RNC
            // 
            RNC.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RNC.HeaderText = "RNC";
            RNC.MinimumWidth = 8;
            RNC.Name = "RNC";
            // 
            // Nombre
            // 
            Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            // 
            // Contacto
            // 
            Contacto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Contacto.HeaderText = "Contacto";
            Contacto.MinimumWidth = 8;
            Contacto.Name = "Contacto";
            // 
            // Telefono
            // 
            Telefono.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Telefono.HeaderText = "Teléfono";
            Telefono.MinimumWidth = 8;
            Telefono.Name = "Telefono";
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Email.HeaderText = "Email";
            Email.MinimumWidth = 8;
            Email.Name = "Email";
            // 
            // CondicionPago
            // 
            CondicionPago.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CondicionPago.HeaderText = "Condición pago";
            CondicionPago.MinimumWidth = 8;
            CondicionPago.Name = "CondicionPago";
            // 
            // TEntrega
            // 
            TEntrega.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TEntrega.HeaderText = "Tiempo entrega";
            TEntrega.MinimumWidth = 8;
            TEntrega.Name = "TEntrega";
            // 
            // Estado
            // 
            Estado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 8;
            Estado.Name = "Estado";
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
            pnlSidebar.Location = new Point(12, 12);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(300, 977);
            pnlSidebar.TabIndex = 19;
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
            // FrmProveedores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1615, 1010);
            Controls.Add(pnlSidebar);
            Controls.Add(dgvProveedores);
            Controls.Add(btnDesempeno);
            Controls.Add(btnVerOrdenesProveedor);
            Controls.Add(btnEditarProveedor);
            Controls.Add(btnNuevoProveedor);
            Name = "FrmProveedores";
            Text = "FrmProveedores";
            ((ISupportInitialize)dgvProveedores).EndInit();
            pnlSidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnNuevoProveedor;
        private Button btnEditarProveedor;
        private Button btnVerOrdenesProveedor;
        private Button btnDesempeno;
        private DataGridView dgvProveedores;
        private DataGridViewTextBoxColumn RNC;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Contacto;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn CondicionPago;
        private DataGridViewTextBoxColumn TEntrega;
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