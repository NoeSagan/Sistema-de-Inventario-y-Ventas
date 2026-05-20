namespace ISW_II_2
{
    partial class FrmOrdenesCompra
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
            btnNuevaOrden = new Button();
            btnVerDetalleOrden = new Button();
            btnMarcarRecibida = new Button();
            btnCancelarOrden = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // btnNuevaOrden
            // 
            btnNuevaOrden.Location = new Point(12, 35);
            btnNuevaOrden.Name = "btnNuevaOrden";
            btnNuevaOrden.Size = new Size(149, 47);
            btnNuevaOrden.TabIndex = 0;
            btnNuevaOrden.Text = "Nueva orden";
            btnNuevaOrden.UseVisualStyleBackColor = true;
            // 
            // btnVerDetalleOrden
            // 
            btnVerDetalleOrden.Location = new Point(208, 35);
            btnVerDetalleOrden.Name = "btnVerDetalleOrden";
            btnVerDetalleOrden.Size = new Size(149, 47);
            btnVerDetalleOrden.TabIndex = 1;
            btnVerDetalleOrden.Text = "Ver detalle";
            btnVerDetalleOrden.UseVisualStyleBackColor = true;
            // 
            // btnMarcarRecibida
            // 
            btnMarcarRecibida.Location = new Point(404, 35);
            btnMarcarRecibida.Name = "btnMarcarRecibida";
            btnMarcarRecibida.Size = new Size(149, 47);
            btnMarcarRecibida.TabIndex = 2;
            btnMarcarRecibida.Text = "Marcar recibida";
            btnMarcarRecibida.UseVisualStyleBackColor = true;
            // 
            // btnCancelarOrden
            // 
            btnCancelarOrden.Location = new Point(600, 35);
            btnCancelarOrden.Name = "btnCancelarOrden";
            btnCancelarOrden.Size = new Size(149, 47);
            btnCancelarOrden.TabIndex = 3;
            btnCancelarOrden.Text = "Cancelar";
            btnCancelarOrden.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(208, 112);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 4;
            // 
            // FrmOrdenesCompra
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 689);
            Controls.Add(comboBox1);
            Controls.Add(btnCancelarOrden);
            Controls.Add(btnMarcarRecibida);
            Controls.Add(btnVerDetalleOrden);
            Controls.Add(btnNuevaOrden);
            Name = "FrmOrdenesCompra";
            Text = "FrmOrdenesCompra";
            ResumeLayout(false);
        }

        #endregion

        private Button btnNuevaOrden;
        private Button btnVerDetalleOrden;
        private Button btnMarcarRecibida;
        private Button btnCancelarOrden;
        private ComboBox comboBox1;
    }
}