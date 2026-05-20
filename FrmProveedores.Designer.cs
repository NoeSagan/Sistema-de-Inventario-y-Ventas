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
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            SuspendLayout();
            // 
            // btnNuevoProveedor
            // 
            btnNuevoProveedor.Location = new Point(27, 59);
            btnNuevoProveedor.Name = "btnNuevoProveedor";
            btnNuevoProveedor.Size = new Size(175, 54);
            btnNuevoProveedor.TabIndex = 0;
            btnNuevoProveedor.Text = "Nuevo proveedor";
            btnNuevoProveedor.UseVisualStyleBackColor = true;
            btnNuevoProveedor.Click += button1_Click;
            // 
            // btnEditarProveedor
            // 
            btnEditarProveedor.Location = new Point(234, 59);
            btnEditarProveedor.Name = "btnEditarProveedor";
            btnEditarProveedor.Size = new Size(175, 54);
            btnEditarProveedor.TabIndex = 1;
            btnEditarProveedor.Text = "Editar";
            btnEditarProveedor.UseVisualStyleBackColor = true;
            btnEditarProveedor.Click += button2_Click;
            // 
            // btnVerOrdenesProveedor
            // 
            btnVerOrdenesProveedor.Location = new Point(441, 59);
            btnVerOrdenesProveedor.Name = "btnVerOrdenesProveedor";
            btnVerOrdenesProveedor.Size = new Size(175, 54);
            btnVerOrdenesProveedor.TabIndex = 2;
            btnVerOrdenesProveedor.Text = "Ver órdenes";
            btnVerOrdenesProveedor.UseVisualStyleBackColor = true;
            btnVerOrdenesProveedor.Click += button3_Click;
            // 
            // btnDesempeno
            // 
            btnDesempeno.Location = new Point(648, 59);
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
            dgvProveedores.Location = new Point(12, 186);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.RowHeadersWidth = 62;
            dgvProveedores.Size = new Size(1330, 626);
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
            // FrmProveedores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 854);
            Controls.Add(dgvProveedores);
            Controls.Add(btnDesempeno);
            Controls.Add(btnVerOrdenesProveedor);
            Controls.Add(btnEditarProveedor);
            Controls.Add(btnNuevoProveedor);
            Name = "FrmProveedores";
            Text = "FrmProveedores";
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
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

        // Manejadores de eventos añadidos para resolver errores de compilación.
        // Implementar la lógica real en el archivo de código parcial principal si se desea.
        private void button5_Click(object sender, EventArgs e)
        {
            // Nuevo proveedor - implementar según necesidades.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Editar proveedor - implementar según necesidades.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Ver órdenes del proveedor - implementar según necesidades.
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Desempeño del proveedor - implementar según necesidades.
        }
    }
}