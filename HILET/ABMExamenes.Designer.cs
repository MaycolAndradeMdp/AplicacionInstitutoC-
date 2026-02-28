namespace HILET
{
    partial class ABMExamenes
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
            tcExamenes = new TabControl();
            tpExamenes = new TabPage();
            btnReporteNotas = new Button();
            label2 = new Label();
            grillaNotas = new DataGridView();
            tpABMNotas = new TabPage();
            txtIdMatricula = new TextBox();
            label4 = new Label();
            label3 = new Label();
            grillaMateria = new DataGridView();
            grillaInstancia = new DataGridView();
            btnLimpiar = new Button();
            btnEliminarExamen = new Button();
            btnModificarExamen = new Button();
            btnAgregarExamen = new Button();
            label1 = new Label();
            calendarioExamen = new MonthCalendar();
            txtFolio = new TextBox();
            lblFolio = new Label();
            txtLibro = new TextBox();
            lblLibro = new Label();
            cmbInstancia = new ComboBox();
            txtNota = new TextBox();
            lblNota = new Label();
            lblIdInstancia = new Label();
            txtIdMateriaxExamenes = new TextBox();
            lblIdMateria = new Label();
            txtIdExamenes = new TextBox();
            lblIdExamenes = new Label();
            tpReportesFinales = new TabPage();
            grillaFinales = new DataGridView();
            btnReportesFinales = new Button();
            tpAnalitico = new TabPage();
            btnBuscar = new Button();
            txtMatricula = new TextBox();
            grillaAnalitico = new DataGridView();
            btnReporteAnaliticos = new Button();
            error1 = new ErrorProvider(components);
            tcExamenes.SuspendLayout();
            tpExamenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grillaNotas).BeginInit();
            tpABMNotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grillaMateria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaInstancia).BeginInit();
            tpReportesFinales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grillaFinales).BeginInit();
            tpAnalitico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grillaAnalitico).BeginInit();
            ((System.ComponentModel.ISupportInitialize)error1).BeginInit();
            SuspendLayout();
            // 
            // tcExamenes
            // 
            tcExamenes.Controls.Add(tpExamenes);
            tcExamenes.Controls.Add(tpABMNotas);
            tcExamenes.Controls.Add(tpReportesFinales);
            tcExamenes.Controls.Add(tpAnalitico);
            tcExamenes.Dock = DockStyle.Fill;
            tcExamenes.Location = new Point(0, 0);
            tcExamenes.Name = "tcExamenes";
            tcExamenes.SelectedIndex = 0;
            tcExamenes.Size = new Size(850, 491);
            tcExamenes.TabIndex = 0;
            // 
            // tpExamenes
            // 
            tpExamenes.BackColor = Color.FromArgb(49, 66, 82);
            tpExamenes.Controls.Add(btnReporteNotas);
            tpExamenes.Controls.Add(label2);
            tpExamenes.Controls.Add(grillaNotas);
            tpExamenes.ForeColor = Color.Black;
            tpExamenes.Location = new Point(4, 24);
            tpExamenes.Name = "tpExamenes";
            tpExamenes.Padding = new Padding(3);
            tpExamenes.Size = new Size(842, 463);
            tpExamenes.TabIndex = 0;
            tpExamenes.Text = "Examenes";
            // 
            // btnReporteNotas
            // 
            btnReporteNotas.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReporteNotas.Location = new Point(42, 398);
            btnReporteNotas.Name = "btnReporteNotas";
            btnReporteNotas.Size = new Size(171, 57);
            btnReporteNotas.TabIndex = 194;
            btnReporteNotas.Text = "Generar reporte de notas";
            btnReporteNotas.UseVisualStyleBackColor = true;
            btnReporteNotas.Click += btnReporteNotas_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(192, 192, 0);
            label2.Location = new Point(42, 3);
            label2.Name = "label2";
            label2.Size = new Size(521, 25);
            label2.TabIndex = 193;
            label2.Text = "Haga doble click en la carrera para modificar/eliminar";
            // 
            // grillaNotas
            // 
            grillaNotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaNotas.Location = new Point(42, 44);
            grillaNotas.Name = "grillaNotas";
            grillaNotas.Size = new Size(746, 349);
            grillaNotas.TabIndex = 117;
            grillaNotas.CellDoubleClick += grillaNotas_CellDoubleClick;
            // 
            // tpABMNotas
            // 
            tpABMNotas.BackColor = Color.FromArgb(49, 66, 82);
            tpABMNotas.Controls.Add(txtIdMatricula);
            tpABMNotas.Controls.Add(label4);
            tpABMNotas.Controls.Add(label3);
            tpABMNotas.Controls.Add(grillaMateria);
            tpABMNotas.Controls.Add(grillaInstancia);
            tpABMNotas.Controls.Add(btnLimpiar);
            tpABMNotas.Controls.Add(btnEliminarExamen);
            tpABMNotas.Controls.Add(btnModificarExamen);
            tpABMNotas.Controls.Add(btnAgregarExamen);
            tpABMNotas.Controls.Add(label1);
            tpABMNotas.Controls.Add(calendarioExamen);
            tpABMNotas.Controls.Add(txtFolio);
            tpABMNotas.Controls.Add(lblFolio);
            tpABMNotas.Controls.Add(txtLibro);
            tpABMNotas.Controls.Add(lblLibro);
            tpABMNotas.Controls.Add(cmbInstancia);
            tpABMNotas.Controls.Add(txtNota);
            tpABMNotas.Controls.Add(lblNota);
            tpABMNotas.Controls.Add(lblIdInstancia);
            tpABMNotas.Controls.Add(txtIdMateriaxExamenes);
            tpABMNotas.Controls.Add(lblIdMateria);
            tpABMNotas.Controls.Add(txtIdExamenes);
            tpABMNotas.Controls.Add(lblIdExamenes);
            tpABMNotas.ForeColor = Color.Black;
            tpABMNotas.Location = new Point(4, 24);
            tpABMNotas.Name = "tpABMNotas";
            tpABMNotas.Padding = new Padding(3);
            tpABMNotas.Size = new Size(842, 463);
            tpABMNotas.TabIndex = 1;
            tpABMNotas.Text = "ABM";
            // 
            // txtIdMatricula
            // 
            txtIdMatricula.Location = new Point(96, 104);
            txtIdMatricula.Name = "txtIdMatricula";
            txtIdMatricula.Size = new Size(42, 23);
            txtIdMatricula.TabIndex = 237;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(18, 107);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 236;
            label4.Text = "Matricula";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(192, 192, 0);
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(8, 11);
            label3.Name = "label3";
            label3.Size = new Size(487, 16);
            label3.TabIndex = 235;
            label3.Text = "El campo de Id Nota se llena solamente si se va a modificar/eliminar alguna nota";
            // 
            // grillaMateria
            // 
            grillaMateria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaMateria.Location = new Point(301, 290);
            grillaMateria.Name = "grillaMateria";
            grillaMateria.Size = new Size(263, 150);
            grillaMateria.TabIndex = 234;
            // 
            // grillaInstancia
            // 
            grillaInstancia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaInstancia.Location = new Point(17, 290);
            grillaInstancia.Name = "grillaInstancia";
            grillaInstancia.Size = new Size(261, 150);
            grillaInstancia.TabIndex = 233;
            // 
            // btnLimpiar
            // 
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnLimpiar.Font = new Font("Century Gothic", 11.25F);
            btnLimpiar.Image = Properties.Resources.delete_4219;
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(199, 225);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(169, 50);
            btnLimpiar.TabIndex = 232;
            btnLimpiar.Text = "Limpiar ";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminarExamen
            // 
            btnEliminarExamen.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnEliminarExamen.Font = new Font("Century Gothic", 11.25F);
            btnEliminarExamen.ForeColor = Color.Black;
            btnEliminarExamen.Image = Properties.Resources.Eliminar;
            btnEliminarExamen.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarExamen.Location = new Point(15, 225);
            btnEliminarExamen.Name = "btnEliminarExamen";
            btnEliminarExamen.Size = new Size(165, 48);
            btnEliminarExamen.TabIndex = 231;
            btnEliminarExamen.Text = "Eliminar";
            btnEliminarExamen.UseVisualStyleBackColor = true;
            btnEliminarExamen.Click += btnEliminarExamen_Click;
            // 
            // btnModificarExamen
            // 
            btnModificarExamen.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnModificarExamen.Font = new Font("Century Gothic", 11.25F);
            btnModificarExamen.ForeColor = Color.Black;
            btnModificarExamen.Image = Properties.Resources.Modificar;
            btnModificarExamen.ImageAlign = ContentAlignment.MiddleLeft;
            btnModificarExamen.Location = new Point(203, 162);
            btnModificarExamen.Name = "btnModificarExamen";
            btnModificarExamen.Size = new Size(165, 48);
            btnModificarExamen.TabIndex = 230;
            btnModificarExamen.Text = "Modificar";
            btnModificarExamen.UseVisualStyleBackColor = true;
            btnModificarExamen.Click += btnModificarExamen_Click;
            // 
            // btnAgregarExamen
            // 
            btnAgregarExamen.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnAgregarExamen.Font = new Font("Century Gothic", 11.25F);
            btnAgregarExamen.ForeColor = Color.Black;
            btnAgregarExamen.Image = Properties.Resources.Agregar;
            btnAgregarExamen.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarExamen.Location = new Point(17, 162);
            btnAgregarExamen.Name = "btnAgregarExamen";
            btnAgregarExamen.Size = new Size(163, 48);
            btnAgregarExamen.TabIndex = 229;
            btnAgregarExamen.Text = "Agregar";
            btnAgregarExamen.UseVisualStyleBackColor = true;
            btnAgregarExamen.Click += btnAgregarExamen_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(621, 24);
            label1.Name = "label1";
            label1.Size = new Size(138, 15);
            label1.TabIndex = 228;
            label1.Text = "Ingrese fecha de Examen";
            // 
            // calendarioExamen
            // 
            calendarioExamen.Location = new Point(565, 48);
            calendarioExamen.Name = "calendarioExamen";
            calendarioExamen.TabIndex = 227;
            // 
            // txtFolio
            // 
            txtFolio.Location = new Point(221, 107);
            txtFolio.Name = "txtFolio";
            txtFolio.Size = new Size(86, 23);
            txtFolio.TabIndex = 226;
            // 
            // lblFolio
            // 
            lblFolio.AutoSize = true;
            lblFolio.ForeColor = Color.Transparent;
            lblFolio.Location = new Point(176, 110);
            lblFolio.Name = "lblFolio";
            lblFolio.Size = new Size(33, 15);
            lblFolio.TabIndex = 225;
            lblFolio.Text = "Folio";
            // 
            // txtLibro
            // 
            txtLibro.Location = new Point(221, 72);
            txtLibro.Name = "txtLibro";
            txtLibro.Size = new Size(86, 23);
            txtLibro.TabIndex = 224;
            // 
            // lblLibro
            // 
            lblLibro.AutoSize = true;
            lblLibro.ForeColor = Color.Transparent;
            lblLibro.Location = new Point(176, 75);
            lblLibro.Name = "lblLibro";
            lblLibro.Size = new Size(34, 15);
            lblLibro.TabIndex = 223;
            lblLibro.Text = "Libro";
            // 
            // cmbInstancia
            // 
            cmbInstancia.FormattingEnabled = true;
            cmbInstancia.Location = new Point(380, 40);
            cmbInstancia.Name = "cmbInstancia";
            cmbInstancia.Size = new Size(125, 23);
            cmbInstancia.TabIndex = 222;
            // 
            // txtNota
            // 
            txtNota.Location = new Point(221, 37);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(86, 23);
            txtNota.TabIndex = 221;
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.ForeColor = Color.Transparent;
            lblNota.Location = new Point(176, 40);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(33, 15);
            lblNota.TabIndex = 220;
            lblNota.Text = "Nota";
            // 
            // lblIdInstancia
            // 
            lblIdInstancia.AutoSize = true;
            lblIdInstancia.ForeColor = Color.Transparent;
            lblIdInstancia.Location = new Point(320, 45);
            lblIdInstancia.Name = "lblIdInstancia";
            lblIdInstancia.Size = new Size(54, 15);
            lblIdInstancia.TabIndex = 219;
            lblIdInstancia.Text = "Instancia";
            // 
            // txtIdMateriaxExamenes
            // 
            txtIdMateriaxExamenes.Location = new Point(96, 72);
            txtIdMateriaxExamenes.Name = "txtIdMateriaxExamenes";
            txtIdMateriaxExamenes.Size = new Size(42, 23);
            txtIdMateriaxExamenes.TabIndex = 218;
            // 
            // lblIdMateria
            // 
            lblIdMateria.AutoSize = true;
            lblIdMateria.ForeColor = Color.Transparent;
            lblIdMateria.Location = new Point(15, 75);
            lblIdMateria.Name = "lblIdMateria";
            lblIdMateria.Size = new Size(60, 15);
            lblIdMateria.TabIndex = 217;
            lblIdMateria.Text = "Id Materia";
            // 
            // txtIdExamenes
            // 
            txtIdExamenes.Location = new Point(96, 37);
            txtIdExamenes.Name = "txtIdExamenes";
            txtIdExamenes.Size = new Size(42, 23);
            txtIdExamenes.TabIndex = 216;
            // 
            // lblIdExamenes
            // 
            lblIdExamenes.AutoSize = true;
            lblIdExamenes.ForeColor = Color.Transparent;
            lblIdExamenes.Location = new Point(29, 42);
            lblIdExamenes.Name = "lblIdExamenes";
            lblIdExamenes.Size = new Size(46, 15);
            lblIdExamenes.TabIndex = 215;
            lblIdExamenes.Text = "Id Nota";
            // 
            // tpReportesFinales
            // 
            tpReportesFinales.BackColor = Color.FromArgb(49, 66, 82);
            tpReportesFinales.Controls.Add(grillaFinales);
            tpReportesFinales.Controls.Add(btnReportesFinales);
            tpReportesFinales.Location = new Point(4, 24);
            tpReportesFinales.Name = "tpReportesFinales";
            tpReportesFinales.Padding = new Padding(3);
            tpReportesFinales.Size = new Size(842, 463);
            tpReportesFinales.TabIndex = 2;
            tpReportesFinales.Text = "Finales";
            // 
            // grillaFinales
            // 
            grillaFinales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaFinales.Location = new Point(28, 37);
            grillaFinales.Name = "grillaFinales";
            grillaFinales.Size = new Size(756, 349);
            grillaFinales.TabIndex = 196;
            // 
            // btnReportesFinales
            // 
            btnReportesFinales.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportesFinales.Location = new Point(28, 398);
            btnReportesFinales.Name = "btnReportesFinales";
            btnReportesFinales.Size = new Size(171, 57);
            btnReportesFinales.TabIndex = 195;
            btnReportesFinales.Text = "Generar reporte de finales";
            btnReportesFinales.UseVisualStyleBackColor = true;
            // 
            // tpAnalitico
            // 
            tpAnalitico.BackColor = Color.FromArgb(49, 66, 82);
            tpAnalitico.Controls.Add(btnBuscar);
            tpAnalitico.Controls.Add(txtMatricula);
            tpAnalitico.Controls.Add(grillaAnalitico);
            tpAnalitico.Controls.Add(btnReporteAnaliticos);
            tpAnalitico.Location = new Point(4, 24);
            tpAnalitico.Name = "tpAnalitico";
            tpAnalitico.Padding = new Padding(3);
            tpAnalitico.Size = new Size(842, 463);
            tpAnalitico.TabIndex = 3;
            tpAnalitico.Text = "Analiticos";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(168, 14);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 26);
            btnBuscar.TabIndex = 200;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(33, 14);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.PlaceholderText = "Ingrese matricula";
            txtMatricula.Size = new Size(129, 23);
            txtMatricula.TabIndex = 199;
            // 
            // grillaAnalitico
            // 
            grillaAnalitico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaAnalitico.Location = new Point(33, 43);
            grillaAnalitico.Name = "grillaAnalitico";
            grillaAnalitico.Size = new Size(756, 349);
            grillaAnalitico.TabIndex = 198;
            // 
            // btnReporteAnaliticos
            // 
            btnReporteAnaliticos.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReporteAnaliticos.Location = new Point(33, 398);
            btnReporteAnaliticos.Name = "btnReporteAnaliticos";
            btnReporteAnaliticos.Size = new Size(171, 57);
            btnReporteAnaliticos.TabIndex = 197;
            btnReporteAnaliticos.Text = "Generar reporte de analitico";
            btnReporteAnaliticos.UseVisualStyleBackColor = true;
            btnReporteAnaliticos.Click += btnReporteAnaliticos_Click;
            // 
            // error1
            // 
            error1.ContainerControl = this;
            // 
            // ABMExamenes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(850, 491);
            ControlBox = false;
            Controls.Add(tcExamenes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ABMExamenes";
            Text = "ABMExamenes";
            tcExamenes.ResumeLayout(false);
            tpExamenes.ResumeLayout(false);
            tpExamenes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grillaNotas).EndInit();
            tpABMNotas.ResumeLayout(false);
            tpABMNotas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grillaMateria).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaInstancia).EndInit();
            tpReportesFinales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grillaFinales).EndInit();
            tpAnalitico.ResumeLayout(false);
            tpAnalitico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grillaAnalitico).EndInit();
            ((System.ComponentModel.ISupportInitialize)error1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcExamenes;
        private TabPage tpExamenes;
        private DataGridView grillaNotas;
        private TabPage tpABMNotas;
        private DataGridView grillaMateria;
        private DataGridView grillaInstancia;
        private Button btnLimpiar;
        private Button btnEliminarExamen;
        private Button btnModificarExamen;
        private Button btnAgregarExamen;
        private Label label1;
        private MonthCalendar calendarioExamen;
        private TextBox txtFolio;
        private Label lblFolio;
        private TextBox txtLibro;
        private Label lblLibro;
        private ComboBox cmbInstancia;
        private TextBox txtNota;
        private Label lblNota;
        private Label lblIdInstancia;
        private TextBox txtIdMateriaxExamenes;
        private Label lblIdMateria;
        private TextBox txtIdExamenes;
        private Label lblIdExamenes;
        private Label label2;
        private Label label3;
        private ErrorProvider error1;
        private TextBox txtIdMatricula;
        private Label label4;
        private Button btnReporteNotas;
        private TabPage tpReportesFinales;
        private Button btnReportesFinales;
        private DataGridView grillaFinales;
        private TabPage tpAnalitico;
        private DataGridView grillaAnalitico;
        private Button btnReporteAnaliticos;
        private Button btnBuscar;
        private TextBox txtMatricula;
    }
}