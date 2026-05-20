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
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Location = new Point(345, 359);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(162, 36);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // txtNomUsuario
            // 
            txtNomUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtNomUsuario.Location = new Point(200, 167);
            txtNomUsuario.Name = "txtNomUsuario";
            txtNomUsuario.Size = new Size(307, 31);
            txtNomUsuario.TabIndex = 1;
            // 
            // txtContraseña
            // 
            txtContraseña.BorderStyle = BorderStyle.FixedSingle;
            txtContraseña.Location = new Point(200, 274);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(307, 31);
            txtContraseña.TabIndex = 2;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // lblNomUsuario
            // 
            lblNomUsuario.AutoSize = true;
            lblNomUsuario.Location = new Point(68, 167);
            lblNomUsuario.Name = "lblNomUsuario";
            lblNomUsuario.Size = new Size(72, 25);
            lblNomUsuario.TabIndex = 3;
            lblNomUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(68, 277);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(101, 25);
            lblContraseña.TabIndex = 4;
            lblContraseña.Text = "Contraseña";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(617, -64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(413, 735);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(975, 584);
            Controls.Add(pictureBox1);
            Controls.Add(lblContraseña);
            Controls.Add(lblNomUsuario);
            Controls.Add(txtContraseña);
            Controls.Add(txtNomUsuario);
            Controls.Add(btnLogin);
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
