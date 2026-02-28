namespace HILET
{
    partial class frmProfesores
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
            btn_redireccionNotas = new Button();
            btn_redireccionAulmnos = new Button();
            panel2 = new Panel();
            dtg_Pofesorxmateria = new DataGridView();
            label4 = new Label();
            lblNota = new Label();
            lblFecha = new Label();
            menuStrip1 = new MenuStrip();
            alumnosToolStripMenuItem = new ToolStripMenuItem();
            visualizarAlumnosToolStripMenuItem = new ToolStripMenuItem();
            buscarAlumnosToolStripMenuItem = new ToolStripMenuItem();
            notasToolStripMenuItem = new ToolStripMenuItem();
            modificarNotasToolStripMenuItem = new ToolStripMenuItem();
            generarReporteToolStripMenuItem = new ToolStripMenuItem();
            navegacionToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            ajustesToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            btnMinimizar = new Button();
            btnSalir = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_Pofesorxmateria).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 63, 97);
            panel1.Controls.Add(btn_redireccionNotas);
            panel1.Controls.Add(btn_redireccionAulmnos);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(159, 502);
            panel1.TabIndex = 0;
            // 
            // btn_redireccionNotas
            // 
            btn_redireccionNotas.BackColor = Color.FromArgb(33, 63, 97);
            btn_redireccionNotas.FlatAppearance.BorderSize = 0;
            btn_redireccionNotas.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 89, 134);
            btn_redireccionNotas.FlatStyle = FlatStyle.Flat;
            btn_redireccionNotas.Font = new Font("Segoe UI", 9F);
            btn_redireccionNotas.ForeColor = Color.White;
            btn_redireccionNotas.ImageAlign = ContentAlignment.MiddleLeft;
            btn_redireccionNotas.Location = new Point(0, 244);
            btn_redireccionNotas.Name = "btn_redireccionNotas";
            btn_redireccionNotas.Size = new Size(159, 38);
            btn_redireccionNotas.TabIndex = 3;
            btn_redireccionNotas.Text = "Notas";
            btn_redireccionNotas.UseVisualStyleBackColor = false;
            btn_redireccionNotas.Click += btn_redireccionNotas_Click;
            // 
            // btn_redireccionAulmnos
            // 
            btn_redireccionAulmnos.BackColor = Color.FromArgb(33, 63, 97);
            btn_redireccionAulmnos.FlatAppearance.BorderSize = 0;
            btn_redireccionAulmnos.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 89, 134);
            btn_redireccionAulmnos.FlatStyle = FlatStyle.Flat;
            btn_redireccionAulmnos.Font = new Font("Segoe UI", 9F);
            btn_redireccionAulmnos.ForeColor = Color.White;
            btn_redireccionAulmnos.ImageAlign = ContentAlignment.MiddleLeft;
            btn_redireccionAulmnos.Location = new Point(0, 146);
            btn_redireccionAulmnos.Name = "btn_redireccionAulmnos";
            btn_redireccionAulmnos.Size = new Size(159, 38);
            btn_redireccionAulmnos.TabIndex = 2;
            btn_redireccionAulmnos.Text = "Alumnos";
            btn_redireccionAulmnos.UseVisualStyleBackColor = false;
            btn_redireccionAulmnos.Click += btn_redireccionAlumnos_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dtg_Pofesorxmateria);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(lblNota);
            panel2.Controls.Add(lblFecha);
            panel2.Dock = DockStyle.Bottom;
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(159, 124);
            panel2.Name = "panel2";
            panel2.Size = new Size(911, 402);
            panel2.TabIndex = 1;
            // 
            // dtg_Pofesorxmateria
            // 
            dtg_Pofesorxmateria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Pofesorxmateria.Location = new Point(318, 47);
            dtg_Pofesorxmateria.Name = "dtg_Pofesorxmateria";
            dtg_Pofesorxmateria.Size = new Size(410, 290);
            dtg_Pofesorxmateria.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14.25F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(448, 11);
            label4.Name = "label4";
            label4.Size = new Size(152, 22);
            label4.TabIndex = 6;
            label4.Text = "Materias dadas";
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.Font = new Font("Century Gothic", 20.25F);
            lblNota.ForeColor = Color.White;
            lblNota.Location = new Point(43, 173);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(77, 33);
            lblNota.TabIndex = 5;
            lblNota.Text = "Hora";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Century Gothic", 20.25F);
            lblFecha.ForeColor = Color.White;
            lblFecha.Location = new Point(43, 124);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(97, 33);
            lblFecha.TabIndex = 4;
            lblFecha.Text = "Fecha";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(46, 89, 134);
            menuStrip1.Items.AddRange(new ToolStripItem[] { alumnosToolStripMenuItem, notasToolStripMenuItem, navegacionToolStripMenuItem, ajustesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1070, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // alumnosToolStripMenuItem
            // 
            alumnosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { visualizarAlumnosToolStripMenuItem, buscarAlumnosToolStripMenuItem });
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
            // buscarAlumnosToolStripMenuItem
            // 
            buscarAlumnosToolStripMenuItem.Name = "buscarAlumnosToolStripMenuItem";
            buscarAlumnosToolStripMenuItem.Size = new Size(172, 22);
            buscarAlumnosToolStripMenuItem.Text = "Buscar Alumno";
            buscarAlumnosToolStripMenuItem.Click += buscarAlumnosToolStripMenuItem_Click;
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
            modificarNotasToolStripMenuItem.Size = new Size(157, 22);
            modificarNotasToolStripMenuItem.Text = "Modificar notas";
            modificarNotasToolStripMenuItem.Click += modificarNotasToolStripMenuItem_Click;
            // 
            // generarReporteToolStripMenuItem
            // 
            generarReporteToolStripMenuItem.Name = "generarReporteToolStripMenuItem";
            generarReporteToolStripMenuItem.Size = new Size(157, 22);
            generarReporteToolStripMenuItem.Text = "Generar reporte";
            generarReporteToolStripMenuItem.Click += generarReporteToolStripMenuItem_Click;
            // 
            // navegacionToolStripMenuItem
            // 
            navegacionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            navegacionToolStripMenuItem.Name = "navegacionToolStripMenuItem";
            navegacionToolStripMenuItem.Size = new Size(82, 20);
            navegacionToolStripMenuItem.Text = "Navegacion";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(96, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // ajustesToolStripMenuItem
            // 
            ajustesToolStripMenuItem.Name = "ajustesToolStripMenuItem";
            ajustesToolStripMenuItem.Size = new Size(57, 20);
            ajustesToolStripMenuItem.Text = "Ajustes";
            ajustesToolStripMenuItem.Click += ajustesToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F);
            label1.Location = new Point(385, 44);
            label1.Name = "label1";
            label1.Size = new Size(329, 39);
            label1.TabIndex = 3;
            label1.Text = "Bienvenido profesor";
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.BackColor = Color.LightGray;
            btnMinimizar.FlatAppearance.BorderColor = Color.White;
            btnMinimizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnMinimizar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMinimizar.ForeColor = Color.Black;
            btnMinimizar.Location = new Point(956, 27);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(50, 24);
            btnMinimizar.TabIndex = 9;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSalir.BackColor = Color.LightGray;
            btnSalir.FlatAppearance.BorderColor = Color.White;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnSalir.ForeColor = Color.Black;
            btnSalir.Location = new Point(1015, 27);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(43, 24);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmProfesores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1070, 526);
            Controls.Add(btnMinimizar);
            Controls.Add(btnSalir);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "frmProfesores";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_Pofesorxmateria).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dtg_Pofesorxmateria;
        private Label label4;
        private Label lblNota;
        private Label lblFecha;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem alumnosToolStripMenuItem;
        private ToolStripMenuItem visualizarAlumnosToolStripMenuItem;
        private ToolStripMenuItem buscarAlumnosToolStripMenuItem;
        private ToolStripMenuItem notasToolStripMenuItem;
        private ToolStripMenuItem modificarNotasToolStripMenuItem;
        private ToolStripMenuItem generarReporteToolStripMenuItem;
        private ToolStripMenuItem navegacionToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem ajustesToolStripMenuItem;
        private Label label1;
        private Button btn_redireccionNotas;
        private Button btn_redireccionAulmnos;
        private Button btnMinimizar;
        private Button btnSalir;
    }
}