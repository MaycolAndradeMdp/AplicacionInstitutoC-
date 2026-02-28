namespace HILET
{
    partial class frmConfimacionPerfil
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
            pbOjo = new PictureBox();
            btnGuardarPerfil = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            txtContraseñaNueva = new TextBox();
            txtUsuarioNuevo = new TextBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            error1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbOjo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)error1).BeginInit();
            SuspendLayout();
            // 
            // pbOjo
            // 
            pbOjo.Image = Properties.Resources.image;
            pbOjo.Location = new Point(1, 160);
            pbOjo.Name = "pbOjo";
            pbOjo.Size = new Size(46, 32);
            pbOjo.SizeMode = PictureBoxSizeMode.Zoom;
            pbOjo.TabIndex = 13;
            pbOjo.TabStop = false;
            pbOjo.Click += pbOjo_Click_1;
            // 
            // btnGuardarPerfil
            // 
            btnGuardarPerfil.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnGuardarPerfil.Location = new Point(50, 218);
            btnGuardarPerfil.Name = "btnGuardarPerfil";
            btnGuardarPerfil.Size = new Size(408, 40);
            btnGuardarPerfil.TabIndex = 8;
            btnGuardarPerfil.Text = "GUARDAR";
            btnGuardarPerfil.UseVisualStyleBackColor = true;
            btnGuardarPerfil.Click += btnGuardarPerfil_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.dusky_grey_sky_background;
            pictureBox2.Location = new Point(50, 188);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(400, 10);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = Properties.Resources.dusky_grey_sky_background;
            pictureBox1.Location = new Point(50, 123);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 10);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // txtContraseñaNueva
            // 
            txtContraseñaNueva.BackColor = SystemColors.ControlLight;
            txtContraseñaNueva.BorderStyle = BorderStyle.None;
            txtContraseñaNueva.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseñaNueva.ForeColor = Color.DimGray;
            txtContraseñaNueva.Location = new Point(50, 162);
            txtContraseñaNueva.Name = "txtContraseñaNueva";
            txtContraseñaNueva.PasswordChar = '*';
            txtContraseñaNueva.PlaceholderText = "Contraseña";
            txtContraseñaNueva.Size = new Size(400, 20);
            txtContraseñaNueva.TabIndex = 10;
            // 
            // txtUsuarioNuevo
            // 
            txtUsuarioNuevo.BackColor = SystemColors.ControlLight;
            txtUsuarioNuevo.BorderStyle = BorderStyle.None;
            txtUsuarioNuevo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuarioNuevo.ForeColor = Color.Gray;
            txtUsuarioNuevo.Location = new Point(50, 97);
            txtUsuarioNuevo.Name = "txtUsuarioNuevo";
            txtUsuarioNuevo.PlaceholderText = "Usuario";
            txtUsuarioNuevo.Size = new Size(400, 20);
            txtUsuarioNuevo.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 63, 97);
            panel1.Controls.Add(pictureBox3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(490, 76);
            panel1.TabIndex = 14;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 286);
            label1.Name = "label1";
            label1.Size = new Size(450, 17);
            label1.TabIndex = 15;
            label1.Text = "Por seguridad cambie su Usuario y Contraseña e ingrese ambas nuevas.";
            // 
            // error1
            // 
            error1.ContainerControl = this;
            // 
            // frmConfimacionPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(490, 332);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pbOjo);
            Controls.Add(btnGuardarPerfil);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txtContraseñaNueva);
            Controls.Add(txtUsuarioNuevo);
            Name = "frmConfimacionPerfil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmConfimacionPerfil";
            ((System.ComponentModel.ISupportInitialize)pbOjo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)error1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbOjo;
        private Button btnGuardarPerfil;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        public TextBox txtContraseñaNueva;
        public TextBox txtUsuarioNuevo;
        private Panel panel1;
        private PictureBox pictureBox3;
        private Label label1;
        private ErrorProvider error1;
    }
}