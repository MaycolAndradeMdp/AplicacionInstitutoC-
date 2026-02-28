namespace HILET
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblTitulo = new Label();
            btnAcceder = new Button();
            btnSalir = new Button();
            pbOjo = new PictureBox();
            error1 = new ErrorProvider(components);
            linkLabel1 = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOjo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)error1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 63, 97);
            panel1.Controls.Add(pictureBox3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 291);
            panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Hilet;
            pictureBox3.Location = new Point(0, 104);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(225, 76);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.ControlLight;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.DimGray;
            txtUsuario.Location = new Point(298, 78);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(400, 20);
            txtUsuario.TabIndex = 1;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = SystemColors.ControlLight;
            txtContraseña.BorderStyle = BorderStyle.None;
            txtContraseña.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña.ForeColor = Color.DimGray;
            txtContraseña.Location = new Point(298, 143);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.PlaceholderText = "Contraseña";
            txtContraseña.Size = new Size(400, 20);
            txtContraseña.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = Properties.Resources.dusky_grey_sky_background;
            pictureBox1.Location = new Point(298, 104);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 10);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.dusky_grey_sky_background;
            pictureBox2.Location = new Point(298, 169);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(400, 10);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = SystemColors.ControlLight;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(33, 63, 97);
            lblTitulo.Location = new Point(445, 23);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(119, 39);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "HILET";
            // 
            // btnAcceder
            // 
            btnAcceder.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnAcceder.FlatStyle = FlatStyle.Flat;
            btnAcceder.Location = new Point(298, 199);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(408, 40);
            btnAcceder.TabIndex = 0;
            btnAcceder.Text = "ACCEDER";
            btnAcceder.UseVisualStyleBackColor = true;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.LightGray;
            btnSalir.FlatAppearance.BorderColor = Color.White;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnSalir.Location = new Point(709, 12);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(43, 24);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // pbOjo
            // 
            pbOjo.Image = Properties.Resources.image;
            pbOjo.Location = new Point(249, 141);
            pbOjo.Name = "pbOjo";
            pbOjo.Size = new Size(46, 32);
            pbOjo.SizeMode = PictureBoxSizeMode.Zoom;
            pbOjo.TabIndex = 7;
            pbOjo.TabStop = false;
            pbOjo.Click += pbOjo_Click;
            // 
            // error1
            // 
            error1.ContainerControl = this;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(298, 252);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(128, 15);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "¿Olvido su contraseña?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(764, 291);
            ControlBox = false;
            Controls.Add(linkLabel1);
            Controls.Add(pbOjo);
            Controls.Add(btnSalir);
            Controls.Add(lblTitulo);
            Controls.Add(btnAcceder);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(panel1);
            MaximizeBox = false;
            MaximumSize = new Size(780, 330);
            MinimizeBox = false;
            MinimumSize = new Size(780, 330);
            Name = "Login";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOjo).EndInit();
            ((System.ComponentModel.ISupportInitialize)error1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        public TextBox txtUsuario;
        public TextBox txtContraseña;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblTitulo;
        private Button btnAcceder;
        private PictureBox pictureBox3;
        private Button btnSalir;
        private PictureBox pbOjo;
        private ErrorProvider error1;
        private LinkLabel linkLabel1;
    }
}
