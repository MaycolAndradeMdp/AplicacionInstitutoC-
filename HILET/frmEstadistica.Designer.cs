namespace HILET
{
    partial class frmEstadistica
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            lblAlumnos = new Label();
            lblCarreras = new Label();
            lblMaterias = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(112, 31);
            label1.Name = "label1";
            label1.Size = new Size(631, 65);
            label1.TabIndex = 0;
            label1.Text = "ESTADISTICAS GENERALES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(322, 153);
            label2.Name = "label2";
            label2.Size = new Size(194, 30);
            label2.TabIndex = 1;
            label2.Text = "Alumnos inscriptos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(312, 240);
            label3.Name = "label3";
            label3.Size = new Size(204, 30);
            label3.TabIndex = 2;
            label3.Text = "Carreras disponibles:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(308, 328);
            label4.Name = "label4";
            label4.Size = new Size(208, 30);
            label4.TabIndex = 3;
            label4.Text = "Materias disponibles:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.dusky_grey_sky_background;
            pictureBox2.Location = new Point(225, 208);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(400, 10);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.dusky_grey_sky_background;
            pictureBox1.Location = new Point(225, 297);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 10);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.dusky_grey_sky_background;
            pictureBox3.Location = new Point(225, 399);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(400, 10);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // lblAlumnos
            // 
            lblAlumnos.AutoSize = true;
            lblAlumnos.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAlumnos.Location = new Point(522, 153);
            lblAlumnos.Name = "lblAlumnos";
            lblAlumnos.Size = new Size(21, 30);
            lblAlumnos.TabIndex = 9;
            lblAlumnos.Text = "-";
            // 
            // lblCarreras
            // 
            lblCarreras.AutoSize = true;
            lblCarreras.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCarreras.Location = new Point(522, 240);
            lblCarreras.Name = "lblCarreras";
            lblCarreras.Size = new Size(21, 30);
            lblCarreras.TabIndex = 10;
            lblCarreras.Text = "-";
            // 
            // lblMaterias
            // 
            lblMaterias.AutoSize = true;
            lblMaterias.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaterias.Location = new Point(522, 328);
            lblMaterias.Name = "lblMaterias";
            lblMaterias.Size = new Size(21, 30);
            lblMaterias.TabIndex = 11;
            lblMaterias.Text = "-";
            // 
            // frmEstadistica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(850, 491);
            Controls.Add(lblMaterias);
            Controls.Add(lblCarreras);
            Controls.Add(lblAlumnos);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEstadistica";
            Text = "frmEstadistica";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label lblAlumnos;
        private Label lblCarreras;
        private Label lblMaterias;
    }
}