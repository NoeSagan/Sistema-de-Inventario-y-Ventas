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
            ((System.ComponentModel.ISupportInitialize)dgvUltimasVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlertasStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenesPendientes).BeginInit();
            SuspendLayout();
            // 
            // pnlKpiVentas
            // 
            pnlKpiVentas.Location = new Point(12, 12);
            pnlKpiVentas.Name = "pnlKpiVentas";
            pnlKpiVentas.Size = new Size(308, 195);
            pnlKpiVentas.TabIndex = 4;
            // 
            // pnlKpiIngresos
            // 
            pnlKpiIngresos.Location = new Point(337, 12);
            pnlKpiIngresos.Name = "pnlKpiIngresos";
            pnlKpiIngresos.Size = new Size(308, 195);
            pnlKpiIngresos.TabIndex = 5;
            // 
            // pnlKpiProductos
            // 
            pnlKpiProductos.Location = new Point(662, 12);
            pnlKpiProductos.Name = "pnlKpiProductos";
            pnlKpiProductos.Size = new Size(308, 195);
            pnlKpiProductos.TabIndex = 5;
            // 
            // pnlKpiClientes
            // 
            pnlKpiClientes.Location = new Point(987, 12);
            pnlKpiClientes.Name = "pnlKpiClientes";
            pnlKpiClientes.Size = new Size(308, 195);
            pnlKpiClientes.TabIndex = 5;
            // 
            // dgvUltimasVentas
            // 
            dgvUltimasVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUltimasVentas.Location = new Point(12, 681);
            dgvUltimasVentas.Name = "dgvUltimasVentas";
            dgvUltimasVentas.RowHeadersWidth = 62;
            dgvUltimasVentas.Size = new Size(1283, 300);
            dgvUltimasVentas.TabIndex = 6;
            // 
            // dgvAlertasStock
            // 
            dgvAlertasStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlertasStock.Location = new Point(12, 295);
            dgvAlertasStock.Name = "dgvAlertasStock";
            dgvAlertasStock.RowHeadersWidth = 62;
            dgvAlertasStock.Size = new Size(1283, 300);
            dgvAlertasStock.TabIndex = 7;
            // 
            // dgvOrdenesPendientes
            // 
            dgvOrdenesPendientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrdenesPendientes.Location = new Point(12, 1067);
            dgvOrdenesPendientes.Name = "dgvOrdenesPendientes";
            dgvOrdenesPendientes.RowHeadersWidth = 62;
            dgvOrdenesPendientes.Size = new Size(1283, 300);
            dgvOrdenesPendientes.TabIndex = 8;
            // 
            // lblAlertasStock
            // 
            lblAlertasStock.AutoSize = true;
            lblAlertasStock.Location = new Point(12, 267);
            lblAlertasStock.Name = "lblAlertasStock";
            lblAlertasStock.Size = new Size(203, 25);
            lblAlertasStock.TabIndex = 9;
            lblAlertasStock.Text = "Alertas de de stock bajo";
            // 
            // lblUltimasVentas
            // 
            lblUltimasVentas.AutoSize = true;
            lblUltimasVentas.Location = new Point(12, 653);
            lblUltimasVentas.Name = "lblUltimasVentas";
            lblUltimasVentas.Size = new Size(185, 25);
            lblUltimasVentas.TabIndex = 10;
            lblUltimasVentas.Text = "Últimas ventas del día";
            // 
            // lblOrdenesPendientes
            // 
            lblOrdenesPendientes.AutoSize = true;
            lblOrdenesPendientes.Location = new Point(12, 1039);
            lblOrdenesPendientes.Name = "lblOrdenesPendientes";
            lblOrdenesPendientes.Size = new Size(242, 25);
            lblOrdenesPendientes.TabIndex = 11;
            lblOrdenesPendientes.Text = "Órdenes de compra en curso";
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1307, 1380);
            Controls.Add(lblOrdenesPendientes);
            Controls.Add(lblUltimasVentas);
            Controls.Add(lblAlertasStock);
            Controls.Add(dgvOrdenesPendientes);
            Controls.Add(dgvAlertasStock);
            Controls.Add(dgvUltimasVentas);
            Controls.Add(pnlKpiClientes);
            Controls.Add(pnlKpiProductos);
            Controls.Add(pnlKpiIngresos);
            Controls.Add(pnlKpiVentas);
            Name = "FrmDashboard";
            Text = "FrmDashboard";
            ((System.ComponentModel.ISupportInitialize)dgvUltimasVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlertasStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenesPendientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}