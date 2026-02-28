namespace HILET
{
    partial class Notas
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
            panel2 = new Panel();
            btnBuscarNota = new Button();
            btnAgregar = new Button();
            groupBox1 = new GroupBox();
            txtApellidoNotaBuscar = new TextBox();
            txtNombrenotasBuscar = new TextBox();
            txtDniNotaBuscar = new TextBox();
            label10 = new Label();
            label8 = new Label();
            label9 = new Label();
            cmbInstancia = new ComboBox();
            txtMatriculaNota = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtLibro = new TextBox();
            label7 = new Label();
            CmbMateria = new ComboBox();
            txtFolio = new TextBox();
            label4 = new Label();
            label3 = new Label();
            btnSalir = new Button();
            btnModificar = new Button();
            dtgNotas = new DataGridView();
            txtNota = new TextBox();
            label2 = new Label();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            alumnosToolStripMenuItem = new ToolStripMenuItem();
            visualizarAlumnosToolStripMenuItem = new ToolStripMenuItem();
            buscarAlumnoToolStripMenuItem = new ToolStripMenuItem();
            notasToolStripMenuItem = new ToolStripMenuItem();
            generarReporteToolStripMenuItem = new ToolStripMenuItem();
            notasToolStripMenuItem1 = new ToolStripMenuItem();
            navegacionToolStripMenuItem = new ToolStripMenuItem();
            volverToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            ajustesToolStripMenuItem = new ToolStripMenuItem();
            errorProvider1 = new ErrorProvider(components);
            error1 = new ErrorProvider(components);
            btnMinimizar = new Button();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgNotas).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)error1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(33, 63, 97);
            panel2.Controls.Add(btnMinimizar);
            panel2.Controls.Add(btnBuscarNota);
            panel2.Controls.Add(btnAgregar);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(cmbInstancia);
            panel2.Controls.Add(txtMatriculaNota);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtLibro);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(CmbMateria);
            panel2.Controls.Add(txtFolio);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnSalir);
            panel2.Controls.Add(btnModificar);
            panel2.Controls.Add(dtgNotas);
            panel2.Controls.Add(txtNota);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(menuStrip1);
            panel2.Dock = DockStyle.Fill;
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1070, 526);
            panel2.TabIndex = 2;
            // 
            // btnBuscarNota
            // 
            btnBuscarNota.BackColor = Color.FromArgb(46, 89, 134);
            btnBuscarNota.FlatStyle = FlatStyle.Popup;
            btnBuscarNota.ForeColor = Color.Black;
            btnBuscarNota.Location = new Point(950, 255);
            btnBuscarNota.Name = "btnBuscarNota";
            btnBuscarNota.Size = new Size(105, 33);
            btnBuscarNota.TabIndex = 33;
            btnBuscarNota.Text = "Buscar";
            btnBuscarNota.UseVisualStyleBackColor = false;
            btnBuscarNota.Click += btnBuscarNota_Click_1;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(46, 89, 134);
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.Location = new Point(23, 246);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(105, 33);
            btnAgregar.TabIndex = 32;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtApellidoNotaBuscar);
            groupBox1.Controls.Add(txtNombrenotasBuscar);
            groupBox1.Controls.Add(txtDniNotaBuscar);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Font = new Font("Century Gothic", 11.25F);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(631, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(266, 154);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar";
            // 
            // txtApellidoNotaBuscar
            // 
            txtApellidoNotaBuscar.Location = new Point(100, 75);
            txtApellidoNotaBuscar.Name = "txtApellidoNotaBuscar";
            txtApellidoNotaBuscar.Size = new Size(150, 26);
            txtApellidoNotaBuscar.TabIndex = 37;
            // 
            // txtNombrenotasBuscar
            // 
            txtNombrenotasBuscar.Location = new Point(101, 38);
            txtNombrenotasBuscar.Name = "txtNombrenotasBuscar";
            txtNombrenotasBuscar.Size = new Size(150, 26);
            txtNombrenotasBuscar.TabIndex = 33;
            // 
            // txtDniNotaBuscar
            // 
            txtDniNotaBuscar.Location = new Point(100, 111);
            txtDniNotaBuscar.Name = "txtDniNotaBuscar";
            txtDniNotaBuscar.Size = new Size(150, 26);
            txtDniNotaBuscar.TabIndex = 36;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 11.25F);
            label10.Location = new Point(12, 41);
            label10.Name = "label10";
            label10.Size = new Size(68, 20);
            label10.TabIndex = 32;
            label10.Text = "Nombre";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 11.25F);
            label8.Location = new Point(11, 114);
            label8.Name = "label8";
            label8.Size = new Size(36, 20);
            label8.TabIndex = 35;
            label8.Text = "DNI";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 11.25F);
            label9.Location = new Point(10, 78);
            label9.Name = "label9";
            label9.Size = new Size(69, 20);
            label9.TabIndex = 34;
            label9.Text = "Apellido";
            // 
            // cmbInstancia
            // 
            cmbInstancia.FormattingEnabled = true;
            cmbInstancia.Location = new Point(393, 140);
            cmbInstancia.Name = "cmbInstancia";
            cmbInstancia.Size = new Size(150, 23);
            cmbInstancia.TabIndex = 30;
            // 
            // txtMatriculaNota
            // 
            txtMatriculaNota.Location = new Point(392, 175);
            txtMatriculaNota.Name = "txtMatriculaNota";
            txtMatriculaNota.Size = new Size(150, 23);
            txtMatriculaNota.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(303, 178);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 28;
            label5.Text = "Matricula";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 11.25F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(302, 142);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 27;
            label6.Text = "Instancia";
            // 
            // txtLibro
            // 
            txtLibro.Location = new Point(393, 102);
            txtLibro.Name = "txtLibro";
            txtLibro.Size = new Size(150, 23);
            txtLibro.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 11.25F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(304, 105);
            label7.Name = "label7";
            label7.Size = new Size(44, 20);
            label7.TabIndex = 25;
            label7.Text = "Libro";
            // 
            // CmbMateria
            // 
            CmbMateria.FormattingEnabled = true;
            CmbMateria.Location = new Point(112, 140);
            CmbMateria.Name = "CmbMateria";
            CmbMateria.Size = new Size(150, 23);
            CmbMateria.TabIndex = 24;
            // 
            // txtFolio
            // 
            txtFolio.Location = new Point(111, 175);
            txtFolio.Name = "txtFolio";
            txtFolio.Size = new Size(150, 23);
            txtFolio.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(22, 178);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 16;
            label4.Text = "Folio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(21, 142);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 14;
            label3.Text = "Materia";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.LightGray;
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.ForeColor = Color.Black;
            btnSalir.Location = new Point(1012, 41);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(43, 24);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(46, 89, 134);
            btnModificar.FlatStyle = FlatStyle.Popup;
            btnModificar.ForeColor = Color.Black;
            btnModificar.Location = new Point(144, 248);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(105, 33);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // dtgNotas
            // 
            dtgNotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgNotas.Location = new Point(12, 287);
            dtgNotas.Name = "dtgNotas";
            dtgNotas.Size = new Size(1046, 195);
            dtgNotas.TabIndex = 9;
            // 
            // txtNota
            // 
            txtNota.Location = new Point(112, 102);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(150, 23);
            txtNota.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(23, 105);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 1;
            label2.Text = "Nota";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(380, 41);
            label1.Name = "label1";
            label1.Size = new Size(239, 33);
            label1.TabIndex = 0;
            label1.Text = "Manejo de notas";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(46, 89, 134);
            menuStrip1.Items.AddRange(new ToolStripItem[] { alumnosToolStripMenuItem, notasToolStripMenuItem, navegacionToolStripMenuItem, ajustesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1070, 24);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // alumnosToolStripMenuItem
            // 
            alumnosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { visualizarAlumnosToolStripMenuItem, buscarAlumnoToolStripMenuItem });
            alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            alumnosToolStripMenuItem.Size = new Size(67, 20);
            alumnosToolStripMenuItem.Text = "Alumnos";
            // 
            // visualizarAlumnosToolStripMenuItem
            // 
            visualizarAlumnosToolStripMenuItem.Name = "visualizarAlumnosToolStripMenuItem";
            visualizarAlumnosToolStripMenuItem.Size = new Size(172, 22);
            visualizarAlumnosToolStripMenuItem.Text = "Visualizar alumnos";
            visualizarAlumnosToolStripMenuItem.Click += visualizarAlumnosToolStripMenuItem_Click_1;
            // 
            // buscarAlumnoToolStripMenuItem
            // 
            buscarAlumnoToolStripMenuItem.Name = "buscarAlumnoToolStripMenuItem";
            buscarAlumnoToolStripMenuItem.Size = new Size(172, 22);
            buscarAlumnoToolStripMenuItem.Text = "Buscar alumno";
            buscarAlumnoToolStripMenuItem.Click += buscarAlumnoToolStripMenuItem_Click;
            // 
            // notasToolStripMenuItem
            // 
            notasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { generarReporteToolStripMenuItem, notasToolStripMenuItem1 });
            notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            notasToolStripMenuItem.Size = new Size(50, 20);
            notasToolStripMenuItem.Text = "Notas";
            // 
            // generarReporteToolStripMenuItem
            // 
            generarReporteToolStripMenuItem.Name = "generarReporteToolStripMenuItem";
            generarReporteToolStripMenuItem.Size = new Size(156, 22);
            generarReporteToolStripMenuItem.Text = "Generar reporte";
            generarReporteToolStripMenuItem.Click += generarReporteToolStripMenuItem_Click;
            // 
            // notasToolStripMenuItem1
            // 
            notasToolStripMenuItem1.Name = "notasToolStripMenuItem1";
            notasToolStripMenuItem1.Size = new Size(156, 22);
            notasToolStripMenuItem1.Text = "Notas";
            notasToolStripMenuItem1.Click += notasToolStripMenuItem1_Click;
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
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click_1;
            // 
            // ajustesToolStripMenuItem
            // 
            ajustesToolStripMenuItem.Name = "ajustesToolStripMenuItem";
            ajustesToolStripMenuItem.Size = new Size(57, 20);
            ajustesToolStripMenuItem.Text = "Ajustes";
            ajustesToolStripMenuItem.Click += ajustesToolStripMenuItem_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // error1
            // 
            error1.ContainerControl = this;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.BackColor = Color.LightGray;
            btnMinimizar.FlatAppearance.BorderColor = Color.White;
            btnMinimizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnMinimizar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMinimizar.Location = new Point(950, 40);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(50, 24);
            btnMinimizar.TabIndex = 34;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // Notas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 526);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Notas";
            Text = "Notas";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgNotas).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)error1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btnSalir;
        private Button btnModificar;
        private DataGridView dtgNotas;
        private TextBox txtMatricula;
        private TextBox txtDni;
        private TextBox txtApellido;
        private TextBox txtNota;
        private Label label2;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem alumnosToolStripMenuItem;
        private TextBox txtFolio;
        private Label label4;
        private Label label3;
        private ToolStripMenuItem visualizarAlumnosToolStripMenuItem;
        private ToolStripMenuItem buscarAlumnoToolStripMenuItem;
        private ToolStripMenuItem notasToolStripMenuItem;
        private ToolStripMenuItem generarReporteToolStripMenuItem;
        private ToolStripMenuItem notasToolStripMenuItem1;
        private ToolStripMenuItem navegacionToolStripMenuItem;
        private ToolStripMenuItem volverToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem ajustesToolStripMenuItem;
        private ComboBox CmbMateria;
        private ComboBox cmbInstancia;
        private TextBox txtMatriculaNota;
        private Label label5;
        private Label label6;
        private TextBox txtLibro;
        private Label label7;
        private Button btnAgregar;
        private GroupBox groupBox1;
        private TextBox txtApellidoNotaBuscar;
        private TextBox txtNombrenotasBuscar;
        private TextBox txtDniNotaBuscar;
        private Label label10;
        private Label label8;
        private Label label9;
        private Button btnBuscarNota;
        private ErrorProvider errorProvider1;
        private ErrorProvider error1;
        private Button btnMinimizar;
    }
}