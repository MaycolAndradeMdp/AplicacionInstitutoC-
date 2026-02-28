namespace HILET
{
    partial class Reportes
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
            panel1 = new Panel();
            btn_generarReporte = new Button();
            btn_buscarReportes = new Button();
            txtMatriculaReportes = new TextBox();
            txtDNIreportes = new TextBox();
            label1 = new Label();
            label4 = new Label();
            txtApellidoReportes = new TextBox();
            txtNombreReportes = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            dtg_Reportes = new DataGridView();
            btnSalir = new Button();
            btnMinimizar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_Reportes).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 63, 97);
            panel1.Controls.Add(btn_generarReporte);
            panel1.Controls.Add(btn_buscarReportes);
            panel1.Controls.Add(txtMatriculaReportes);
            panel1.Controls.Add(txtDNIreportes);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtApellidoReportes);
            panel1.Controls.Add(txtNombreReportes);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.Transparent;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(329, 487);
            panel1.TabIndex = 0;
            // 
            // btn_generarReporte
            // 
            btn_generarReporte.BackColor = Color.FromArgb(46, 89, 134);
            btn_generarReporte.FlatStyle = FlatStyle.Popup;
            btn_generarReporte.Font = new Font("Segoe UI", 9F);
            btn_generarReporte.ForeColor = Color.Black;
            btn_generarReporte.Location = new Point(189, 413);
            btn_generarReporte.Name = "btn_generarReporte";
            btn_generarReporte.Size = new Size(108, 45);
            btn_generarReporte.TabIndex = 16;
            btn_generarReporte.Text = "Guardar";
            btn_generarReporte.UseVisualStyleBackColor = false;
            btn_generarReporte.Click += btn_generarReporte_Click_1;
            // 
            // btn_buscarReportes
            // 
            btn_buscarReportes.BackColor = Color.FromArgb(46, 89, 134);
            btn_buscarReportes.FlatStyle = FlatStyle.Popup;
            btn_buscarReportes.Font = new Font("Segoe UI", 9F);
            btn_buscarReportes.ForeColor = Color.Black;
            btn_buscarReportes.Location = new Point(25, 413);
            btn_buscarReportes.Name = "btn_buscarReportes";
            btn_buscarReportes.Size = new Size(108, 45);
            btn_buscarReportes.TabIndex = 15;
            btn_buscarReportes.Text = "Analitico";
            btn_buscarReportes.UseVisualStyleBackColor = false;
            btn_buscarReportes.Click += btn_buscarReportes_Click;
            // 
            // txtMatriculaReportes
            // 
            txtMatriculaReportes.Location = new Point(100, 267);
            txtMatriculaReportes.Margin = new Padding(4);
            txtMatriculaReportes.Name = "txtMatriculaReportes";
            txtMatriculaReportes.Size = new Size(121, 26);
            txtMatriculaReportes.TabIndex = 14;
            // 
            // txtDNIreportes
            // 
            txtDNIreportes.Location = new Point(100, 204);
            txtDNIreportes.Margin = new Padding(4);
            txtDNIreportes.Name = "txtDNIreportes";
            txtDNIreportes.Size = new Size(121, 26);
            txtDNIreportes.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F);
            label1.Location = new Point(13, 270);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 12;
            label1.Text = "Matricula";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F);
            label4.Location = new Point(11, 207);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 11;
            label4.Text = "DNI";
            // 
            // txtApellidoReportes
            // 
            txtApellidoReportes.Location = new Point(100, 134);
            txtApellidoReportes.Margin = new Padding(4);
            txtApellidoReportes.Name = "txtApellidoReportes";
            txtApellidoReportes.Size = new Size(121, 26);
            txtApellidoReportes.TabIndex = 10;
            // 
            // txtNombreReportes
            // 
            txtNombreReportes.Location = new Point(100, 69);
            txtNombreReportes.Margin = new Padding(4);
            txtNombreReportes.Name = "txtNombreReportes";
            txtNombreReportes.Size = new Size(121, 26);
            txtNombreReportes.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F);
            label3.Location = new Point(11, 134);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 8;
            label3.Text = "Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F);
            label2.Location = new Point(11, 72);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 7;
            label2.Text = "Nombre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 20.25F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(334, 9);
            label5.Name = "label5";
            label5.Size = new Size(131, 33);
            label5.TabIndex = 1;
            label5.Text = "Reportes";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 15.75F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(546, 73);
            label6.Name = "label6";
            label6.Size = new Size(125, 24);
            label6.TabIndex = 2;
            label6.Text = "Vista Previa";
            // 
            // dtg_Reportes
            // 
            dtg_Reportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Reportes.Location = new Point(439, 110);
            dtg_Reportes.Name = "dtg_Reportes";
            dtg_Reportes.Size = new Size(326, 365);
            dtg_Reportes.TabIndex = 3;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.LightGray;
            btnSalir.FlatAppearance.BorderColor = Color.White;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnSalir.Location = new Point(779, 12);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(43, 24);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.BackColor = Color.LightGray;
            btnMinimizar.FlatAppearance.BorderColor = Color.White;
            btnMinimizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnMinimizar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMinimizar.Location = new Point(723, 12);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(50, 24);
            btnMinimizar.TabIndex = 8;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // Reportes
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 89, 134);
            ClientSize = new Size(834, 487);
            Controls.Add(btnMinimizar);
            Controls.Add(btnSalir);
            Controls.Add(dtg_Reportes);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 11.25F);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Reportes";
            Text = "Reportes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_Reportes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtApellidoReportes;
        private TextBox txtNombreReportes;
        private Label label3;
        private Label label2;
        private TextBox txtMatriculaReportes;
        private TextBox txtDNIreportes;
        private Label label1;
        private Label label4;
        private Button btn_generarReporte;
        private Button btn_buscarReportes;
        private Label label5;
        private Label label6;
        private DataGridView dtg_Reportes;
        private Button btnSalir;
        private Button btnMinimizar;
    }
}