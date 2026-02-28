namespace HILET
{
    partial class frmConfirmacionPerfilProfesores
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pbOjo = new PictureBox();
            btnGuardarPerfil = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            txtContraseñaNueva = new TextBox();
            txtUsuarioNuevo = new TextBox();
            error1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOjo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)error1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 360);
            label1.Name = "label1";
            label1.Size = new Size(450, 17);
            label1.TabIndex = 23;
            label1.Text = "Por seguridad cambie su Usuario y Contraseña e ingrese ambas nuevas.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 301);
            label2.Name = "label2";
            label2.Size = new Size(450, 17);
            label2.TabIndex = 31;
            label2.Text = "Por seguridad cambie su Usuario y Contraseña e ingrese ambas nuevas.";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 63, 97);
            panel1.Controls.Add(pictureBox3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(490, 76);
            panel1.TabIndex = 30;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Hilet;
            pictureBox3.Location = new Point(110, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(292, 51);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // pbOjo
            // 
            pbOjo.Image = Properties.Resources.image;
            pbOjo.Location = new Point(1, 175);
            pbOjo.Name = "pbOjo";
            pbOjo.Size = new Size(46, 32);
            pbOjo.SizeMode = PictureBoxSizeMode.Zoom;
            pbOjo.TabIndex = 29;
            pbOjo.TabStop = false;
            pbOjo.Click += pbOjo_Click_1;
            // 
            // btnGuardarPerfil
            // 
            btnGuardarPerfil.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnGuardarPerfil.Location = new Point(50, 233);
            btnGuardarPerfil.Name = "btnGuardarPerfil";
            btnGuardarPerfil.Size = new Size(408, 40);
            btnGuardarPerfil.TabIndex = 24;
            btnGuardarPerfil.Text = "GUARDAR";
            btnGuardarPerfil.UseVisualStyleBackColor = true;
            btnGuardarPerfil.Click += btnGuardarPerfil_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.dusky_grey_sky_background;
            pictureBox2.Location = new Point(50, 203);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(400, 10);
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = Properties.Resources.dusky_grey_sky_background;
            pictureBox1.Location = new Point(50, 138);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 10);
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // txtContraseñaNueva
            // 
            txtContraseñaNueva.BackColor = SystemColors.ControlLight;
            txtContraseñaNueva.BorderStyle = BorderStyle.None;
            txtContraseñaNueva.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseñaNueva.ForeColor = Color.DimGray;
            txtContraseñaNueva.Location = new Point(50, 177);
            txtContraseñaNueva.Name = "txtContraseñaNueva";
            txtContraseñaNueva.PasswordChar = '*';
            txtContraseñaNueva.PlaceholderText = "Contraseña";
            txtContraseñaNueva.Size = new Size(400, 20);
            txtContraseñaNueva.TabIndex = 26;
            // 
            // txtUsuarioNuevo
            // 
            txtUsuarioNuevo.BackColor = SystemColors.ControlLight;
            txtUsuarioNuevo.BorderStyle = BorderStyle.None;
            txtUsuarioNuevo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuarioNuevo.ForeColor = Color.Gray;
            txtUsuarioNuevo.Location = new Point(50, 112);
            txtUsuarioNuevo.Name = "txtUsuarioNuevo";
            txtUsuarioNuevo.PlaceholderText = "Usuario";
            txtUsuarioNuevo.Size = new Size(400, 20);
            txtUsuarioNuevo.TabIndex = 25;
            // 
            // error1
            // 
            error1.ContainerControl = this;
            // 
            // frmConfirmacionPerfilProfesores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 332);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(pbOjo);
            Controls.Add(btnGuardarPerfil);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txtContraseñaNueva);
            Controls.Add(txtUsuarioNuevo);
            Controls.Add(label1);
            Name = "frmConfirmacionPerfilProfesores";
            Text = "frmConfirmacionPerfilProfesores";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOjo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)error1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox pbOjo;
        private Button btnGuardarPerfil;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        public TextBox txtContraseñaNueva;
        public TextBox txtUsuarioNuevo;
        private ErrorProvider error1;
    }
}