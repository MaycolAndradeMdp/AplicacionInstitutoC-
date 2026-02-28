namespace HILET
{
    partial class Alumnos
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
            menuStrip1 = new MenuStrip();
            alumnosToolStripMenuItem = new ToolStripMenuItem();
            buscarAlumnoToolStripMenuItem = new ToolStripMenuItem();
            notasToolStripMenuItem = new ToolStripMenuItem();
            modificarNotasToolStripMenuItem = new ToolStripMenuItem();
            generarReporteToolStripMenuItem = new ToolStripMenuItem();
            navegacionToolStripMenuItem = new ToolStripMenuItem();
            volverToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            ajustesToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            btnSalir = new Button();
            btnReporteAlumno = new Button();
            btnBuscarAlumno = new Button();
            dtg_verAlumnos = new DataGridView();
            txtMatricula = new TextBox();
            txtDni = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnMinimizar = new Button();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_verAlumnos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 89, 134);
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1070, 24);
            panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(46, 89, 134);
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.Items.AddRange(new ToolStripItem[] { alumnosToolStripMenuItem, notasToolStripMenuItem, navegacionToolStripMenuItem, ajustesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1070, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // alumnosToolStripMenuItem
            // 
            alumnosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { buscarAlumnoToolStripMenuItem });
            alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            alumnosToolStripMenuItem.Size = new Size(67, 20);
            alumnosToolStripMenuItem.Text = "Alumnos";
            // 
            // buscarAlumnoToolStripMenuItem
            // 
            buscarAlumnoToolStripMenuItem.Name = "buscarAlumnoToolStripMenuItem";
            buscarAlumnoToolStripMenuItem.Size = new Size(155, 22);
            buscarAlumnoToolStripMenuItem.Text = "Buscar Alumno";
            buscarAlumnoToolStripMenuItem.Click += buscarAlumnoToolStripMenuItem_Click;
            // 
            // notasToolStripMenuItem
            // 
            notasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { modificarNotasToolStripMenuItem, generarReporteToolStripMenuItem });
            notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            notasToolStripMenuItem.Size = new Size(50, 20);
            notasToolStripMenuItem.Text = "Notas";
            // 
            // modificarNotasToolStripMenuItem
            // 
            modificarNotasToolStripMenuItem.Name = "modificarNotasToolStripMenuItem";
            modificarNotasToolStripMenuItem.Size = new Size(159, 22);
            modificarNotasToolStripMenuItem.Text = "Modificar Notas";
            modificarNotasToolStripMenuItem.Click += modificarNotasToolStripMenuItem_Click;
            // 
            // generarReporteToolStripMenuItem
            // 
            generarReporteToolStripMenuItem.Name = "generarReporteToolStripMenuItem";
            generarReporteToolStripMenuItem.Size = new Size(159, 22);
            generarReporteToolStripMenuItem.Text = "Generar reporte";
            generarReporteToolStripMenuItem.Click += generarReporteToolStripMenuItem_Click;
            // 
            // navegacionToolStripMenuItem
            // 
            navegacionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { volverToolStripMenuItem, salirToolStripMenuItem });
            navegacionToolStripMenuItem.Name = "navegacionToolStripMenuItem";
            navegacionToolStripMenuItem.Size = new Size(82, 20);
            navegacionToolStripMenuItem.Text = "Navegacion";
            // 
            // volverToolStripMenuItem
            // 
            volverToolStripMenuItem.Name = "volverToolStripMenuItem";
            volverToolStripMenuItem.Size = new Size(106, 22);
            volverToolStripMenuItem.Text = "Volver";
            volverToolStripMenuItem.Click += volverToolStripMenuItem_Click_1;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(106, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click_2;
            // 
            // ajustesToolStripMenuItem
            // 
            ajustesToolStripMenuItem.Name = "ajustesToolStripMenuItem";
            ajustesToolStripMenuItem.Size = new Size(57, 20);
            ajustesToolStripMenuItem.Text = "Ajustes";
            ajustesToolStripMenuItem.Click += ajustesToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(33, 63, 97);
            panel2.Controls.Add(btnMinimizar);
            panel2.Controls.Add(btnSalir);
            panel2.Controls.Add(btnReporteAlumno);
            panel2.Controls.Add(btnBuscarAlumno);
            panel2.Controls.Add(dtg_verAlumnos);
            panel2.Controls.Add(txtMatricula);
            panel2.Controls.Add(txtDni);
            panel2.Controls.Add(txtApellido);
            panel2.Controls.Add(txtNombre);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(0, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(1070, 502);
            panel2.TabIndex = 1;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.LightGray;
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.ForeColor = Color.Black;
            btnSalir.Location = new Point(1015, 17);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(43, 24);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += button1_Click;
            // 
            // btnReporteAlumno
            // 
            btnReporteAlumno.BackColor = Color.FromArgb(46, 89, 134);
            btnReporteAlumno.FlatStyle = FlatStyle.Popup;
            btnReporteAlumno.ForeColor = Color.Black;
            btnReporteAlumno.Location = new Point(943, 235);
            btnReporteAlumno.Name = "btnReporteAlumno";
            btnReporteAlumno.Size = new Size(105, 33);
            btnReporteAlumno.TabIndex = 11;
            btnReporteAlumno.Text = "Reporte";
            btnReporteAlumno.UseVisualStyleBackColor = false;
            btnReporteAlumno.Click += btnReporteAlumno_Click_1;
            // 
            // btnBuscarAlumno
            // 
            btnBuscarAlumno.BackColor = Color.FromArgb(46, 89, 134);
            btnBuscarAlumno.FlatStyle = FlatStyle.Popup;
            btnBuscarAlumno.ForeColor = Color.Black;
            btnBuscarAlumno.Location = new Point(822, 235);
            btnBuscarAlumno.Name = "btnBuscarAlumno";
            btnBuscarAlumno.Size = new Size(105, 33);
            btnBuscarAlumno.TabIndex = 10;
            btnBuscarAlumno.Text = "Buscar";
            btnBuscarAlumno.UseVisualStyleBackColor = false;
            btnBuscarAlumno.Click += btnBuscarAlumno_Click_1;
            // 
            // dtg_verAlumnos
            // 
            dtg_verAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_verAlumnos.Location = new Point(12, 287);
            dtg_verAlumnos.Name = "dtg_verAlumnos";
            dtg_verAlumnos.Size = new Size(1046, 193);
            dtg_verAlumnos.TabIndex = 9;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(408, 117);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(150, 23);
            txtMatricula.TabIndex = 8;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(408, 77);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(150, 23);
            txtDni.TabIndex = 7;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(107, 121);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(150, 23);
            txtApellido.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(107, 77);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 23);
            txtNombre.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(323, 120);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 4;
            label5.Text = "Matricula";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(323, 80);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 3;
            label4.Text = "DNI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(22, 125);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(22, 80);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(424, 17);
            label1.Name = "label1";
            label1.Size = new Size(251, 33);
            label1.TabIndex = 0;
            label1.Text = "Visualizar Alumnos";
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.BackColor = Color.LightGray;
            btnMinimizar.FlatAppearance.BorderColor = Color.White;
            btnMinimizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnMinimizar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMinimizar.Location = new Point(959, 17);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(50, 24);
            btnMinimizar.TabIndex = 14;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // Alumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 526);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "Alumnos";
            Text = "Alumnos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_verAlumnos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MenuStrip menuStrip1;
        private Panel panel2;
        private ToolStripMenuItem alumnosToolStripMenuItem;
        private ToolStripMenuItem buscarAlumnoToolStripMenuItem;
        private ToolStripMenuItem notasToolStripMenuItem;
        private ToolStripMenuItem modificarNotasToolStripMenuItem;
        private ToolStripMenuItem generarReporteToolStripMenuItem;
        private ToolStripMenuItem navegacionToolStripMenuItem;
        private ToolStripMenuItem volverToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem ajustesToolStripMenuItem;
        private Label label1;
        private TextBox txtNombre;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtMatricula;
        private TextBox txtDni;
        private TextBox txtApellido;
        private Button btnReporteAlumno;
        private Button btnBuscarAlumno;
        private DataGridView dtg_verAlumnos;
        private Button btnSalir;
        private Button btnMinimizar;
    }
}