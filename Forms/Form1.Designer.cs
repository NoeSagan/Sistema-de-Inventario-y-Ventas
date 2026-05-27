namespace ISW_II_2
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btnLogin = new Button();
            txtNomUsuario = new TextBox();
            txtContraseña = new TextBox();
            lblNomUsuario = new Label();
            lblContraseña = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.Control;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Location = new Point(276, 287);
            btnLogin.Margin = new Padding(2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(130, 29);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtNomUsuario
            // 
            txtNomUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtNomUsuario.Location = new Point(160, 134);
            txtNomUsuario.Margin = new Padding(2);
            txtNomUsuario.Name = "txtNomUsuario";
            txtNomUsuario.Size = new Size(246, 27);
            txtNomUsuario.TabIndex = 1;
            txtNomUsuario.TextChanged += txtNomUsuario_TextChanged;
            // 
            // txtContraseña
            // 
            txtContraseña.BorderStyle = BorderStyle.FixedSingle;
            txtContraseña.Location = new Point(160, 219);
            txtContraseña.Margin = new Padding(2);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(246, 27);
            txtContraseña.TabIndex = 2;
            txtContraseña.UseSystemPasswordChar = true;
            txtContraseña.TextChanged += txtContraseña_TextChanged;
            // 
            // lblNomUsuario
            // 
            lblNomUsuario.AutoSize = true;
            lblNomUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomUsuario.Location = new Point(54, 134);
            lblNomUsuario.Margin = new Padding(2, 0, 2, 0);
            lblNomUsuario.Name = "lblNomUsuario";
            lblNomUsuario.Size = new Size(63, 20);
            lblNomUsuario.TabIndex = 3;
            lblNomUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContraseña.Location = new Point(54, 222);
            lblContraseña.Margin = new Padding(2, 0, 2, 0);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(88, 20);
            lblContraseña.TabIndex = 4;
            lblContraseña.Text = "Contraseña";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(494, -51);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(740, 1044);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(780, 467);
            Controls.Add(pictureBox1);
            Controls.Add(lblContraseña);
            Controls.Add(lblNomUsuario);
            Controls.Add(txtContraseña);
            Controls.Add(txtNomUsuario);
            Controls.Add(btnLogin);
            Margin = new Padding(2);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtNomUsuario;
        private TextBox txtContraseña;
        private Label lblNomUsuario;
        private Label lblContraseña;
        private PictureBox pictureBox1;
    }
}
