namespace HILET
{
    partial class ABMMaterias
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
            tcABMMaterias = new TabControl();
            tpMaterias = new TabPage();
            label5 = new Label();
            grillaMaterias = new DataGridView();
            tpABMMaterias = new TabPage();
            btnLimpiar = new Button();
            grillaCarreras = new DataGridView();
            grillaProfesores = new DataGridView();
            label6 = new Label();
            txtAñoCursadaMateria = new TextBox();
            lblAñoCursadaMateria = new Label();
            txtNombreMateria = new TextBox();
            lblNombreMateria = new Label();
            txtIdProfesor = new TextBox();
            lblIdProfesor = new Label();
            txtIdCarreraxMateria = new TextBox();
            lblIdCarreraMateria = new Label();
            btnEliminarMaterias = new Button();
            btnModificarMaterias = new Button();
            btnAgregarMaterias = new Button();
            txtIdMateria = new TextBox();
            lblIdMateria = new Label();
            error1 = new ErrorProvider(components);
            btnReporteMaterias = new Button();
            tcABMMaterias.SuspendLayout();
            tpMaterias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grillaMaterias).BeginInit();
            tpABMMaterias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grillaCarreras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaProfesores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)error1).BeginInit();
            SuspendLayout();
            // 
            // tcABMMaterias
            // 
            tcABMMaterias.Controls.Add(tpMaterias);
            tcABMMaterias.Controls.Add(tpABMMaterias);
            tcABMMaterias.Dock = DockStyle.Fill;
            tcABMMaterias.Location = new Point(0, 0);
            tcABMMaterias.Name = "tcABMMaterias";
            tcABMMaterias.SelectedIndex = 0;
            tcABMMaterias.Size = new Size(850, 491);
            tcABMMaterias.TabIndex = 0;
            // 
            // tpMaterias
            // 
            tpMaterias.BackColor = Color.FromArgb(49, 66, 82);
            tpMaterias.Controls.Add(btnReporteMaterias);
            tpMaterias.Controls.Add(label5);
            tpMaterias.Controls.Add(grillaMaterias);
            tpMaterias.ForeColor = Color.Black;
            tpMaterias.Location = new Point(4, 24);
            tpMaterias.Name = "tpMaterias";
            tpMaterias.Padding = new Padding(3);
            tpMaterias.Size = new Size(842, 463);
            tpMaterias.TabIndex = 0;
            tpMaterias.Text = "Materias";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(192, 192, 0);
            label5.Location = new Point(25, 18);
            label5.Name = "label5";
            label5.Size = new Size(524, 25);
            label5.TabIndex = 192;
            label5.Text = "Haga doble click en la materia para modificar/eliminar";
            // 
            // grillaMaterias
            // 
            grillaMaterias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaMaterias.Location = new Point(39, 57);
            grillaMaterias.Name = "grillaMaterias";
            grillaMaterias.ReadOnly = true;
            grillaMaterias.Size = new Size(760, 332);
            grillaMaterias.TabIndex = 91;
            grillaMaterias.CellDoubleClick += grillaMaterias_CellDoubleClick;
            // 
            // tpABMMaterias
            // 
            tpABMMaterias.BackColor = Color.FromArgb(49, 66, 82);
            tpABMMaterias.Controls.Add(btnLimpiar);
            tpABMMaterias.Controls.Add(grillaCarreras);
            tpABMMaterias.Controls.Add(grillaProfesores);
            tpABMMaterias.Controls.Add(label6);
            tpABMMaterias.Controls.Add(txtAñoCursadaMateria);
            tpABMMaterias.Controls.Add(lblAñoCursadaMateria);
            tpABMMaterias.Controls.Add(txtNombreMateria);
            tpABMMaterias.Controls.Add(lblNombreMateria);
            tpABMMaterias.Controls.Add(txtIdProfesor);
            tpABMMaterias.Controls.Add(lblIdProfesor);
            tpABMMaterias.Controls.Add(txtIdCarreraxMateria);
            tpABMMaterias.Controls.Add(lblIdCarreraMateria);
            tpABMMaterias.Controls.Add(btnEliminarMaterias);
            tpABMMaterias.Controls.Add(btnModificarMaterias);
            tpABMMaterias.Controls.Add(btnAgregarMaterias);
            tpABMMaterias.Controls.Add(txtIdMateria);
            tpABMMaterias.Controls.Add(lblIdMateria);
            tpABMMaterias.Location = new Point(4, 24);
            tpABMMaterias.Name = "tpABMMaterias";
            tpABMMaterias.Padding = new Padding(3);
            tpABMMaterias.Size = new Size(842, 463);
            tpABMMaterias.TabIndex = 1;
            tpABMMaterias.Text = "ABM";
            // 
            // btnLimpiar
            // 
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnLimpiar.Font = new Font("Century Gothic", 11.25F);
            btnLimpiar.Image = Properties.Resources.delete_4219;
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(574, 173);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(169, 50);
            btnLimpiar.TabIndex = 210;
            btnLimpiar.Text = "Limpiar ";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // grillaCarreras
            // 
            grillaCarreras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaCarreras.Location = new Point(454, 229);
            grillaCarreras.Name = "grillaCarreras";
            grillaCarreras.ReadOnly = true;
            grillaCarreras.Size = new Size(243, 228);
            grillaCarreras.TabIndex = 209;
            // 
            // grillaProfesores
            // 
            grillaProfesores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaProfesores.Location = new Point(27, 227);
            grillaProfesores.Name = "grillaProfesores";
            grillaProfesores.ReadOnly = true;
            grillaProfesores.Size = new Size(362, 228);
            grillaProfesores.TabIndex = 208;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(192, 192, 0);
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(19, 24);
            label6.Name = "label6";
            label6.Size = new Size(522, 16);
            label6.TabIndex = 207;
            label6.Text = "El campo de Id Materia se llena solamente si se va a modificar/eliminar alguna materia";
            // 
            // txtAñoCursadaMateria
            // 
            txtAñoCursadaMateria.ForeColor = Color.Black;
            txtAñoCursadaMateria.Location = new Point(321, 121);
            txtAñoCursadaMateria.Name = "txtAñoCursadaMateria";
            txtAñoCursadaMateria.Size = new Size(86, 23);
            txtAñoCursadaMateria.TabIndex = 206;
            // 
            // lblAñoCursadaMateria
            // 
            lblAñoCursadaMateria.AutoSize = true;
            lblAñoCursadaMateria.ForeColor = Color.Transparent;
            lblAñoCursadaMateria.Location = new Point(240, 124);
            lblAñoCursadaMateria.Name = "lblAñoCursadaMateria";
            lblAñoCursadaMateria.Size = new Size(75, 15);
            lblAñoCursadaMateria.TabIndex = 205;
            lblAñoCursadaMateria.Text = "Año Cursada";
            // 
            // txtNombreMateria
            // 
            txtNombreMateria.ForeColor = Color.Black;
            txtNombreMateria.Location = new Point(93, 118);
            txtNombreMateria.Name = "txtNombreMateria";
            txtNombreMateria.Size = new Size(121, 23);
            txtNombreMateria.TabIndex = 204;
            // 
            // lblNombreMateria
            // 
            lblNombreMateria.AutoSize = true;
            lblNombreMateria.ForeColor = Color.Transparent;
            lblNombreMateria.Location = new Point(27, 121);
            lblNombreMateria.Name = "lblNombreMateria";
            lblNombreMateria.Size = new Size(51, 15);
            lblNombreMateria.TabIndex = 203;
            lblNombreMateria.Text = "Nombre";
            // 
            // txtIdProfesor
            // 
            txtIdProfesor.ForeColor = Color.Black;
            txtIdProfesor.Location = new Point(401, 72);
            txtIdProfesor.Name = "txtIdProfesor";
            txtIdProfesor.Size = new Size(42, 23);
            txtIdProfesor.TabIndex = 202;
            // 
            // lblIdProfesor
            // 
            lblIdProfesor.AutoSize = true;
            lblIdProfesor.ForeColor = Color.Transparent;
            lblIdProfesor.Location = new Point(335, 75);
            lblIdProfesor.Name = "lblIdProfesor";
            lblIdProfesor.Size = new Size(64, 15);
            lblIdProfesor.TabIndex = 201;
            lblIdProfesor.Text = "Id Profesor";
            // 
            // txtIdCarreraxMateria
            // 
            txtIdCarreraxMateria.ForeColor = Color.Black;
            txtIdCarreraxMateria.Location = new Point(245, 72);
            txtIdCarreraxMateria.Name = "txtIdCarreraxMateria";
            txtIdCarreraxMateria.Size = new Size(42, 23);
            txtIdCarreraxMateria.TabIndex = 200;
            // 
            // lblIdCarreraMateria
            // 
            lblIdCarreraMateria.AutoSize = true;
            lblIdCarreraMateria.ForeColor = Color.Transparent;
            lblIdCarreraMateria.Location = new Point(179, 75);
            lblIdCarreraMateria.Name = "lblIdCarreraMateria";
            lblIdCarreraMateria.Size = new Size(58, 15);
            lblIdCarreraMateria.TabIndex = 199;
            lblIdCarreraMateria.Text = "Id Carrera";
            // 
            // btnEliminarMaterias
            // 
            btnEliminarMaterias.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnEliminarMaterias.Font = new Font("Century Gothic", 11.25F);
            btnEliminarMaterias.ForeColor = Color.Black;
            btnEliminarMaterias.Image = Properties.Resources.Eliminar;
            btnEliminarMaterias.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarMaterias.Location = new Point(385, 173);
            btnEliminarMaterias.Name = "btnEliminarMaterias";
            btnEliminarMaterias.Size = new Size(165, 48);
            btnEliminarMaterias.TabIndex = 198;
            btnEliminarMaterias.Text = "Eliminar";
            btnEliminarMaterias.UseVisualStyleBackColor = true;
            btnEliminarMaterias.Click += btnEliminarMaterias_Click;
            // 
            // btnModificarMaterias
            // 
            btnModificarMaterias.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnModificarMaterias.Font = new Font("Century Gothic", 11.25F);
            btnModificarMaterias.ForeColor = Color.Black;
            btnModificarMaterias.Image = Properties.Resources.Modificar;
            btnModificarMaterias.ImageAlign = ContentAlignment.MiddleLeft;
            btnModificarMaterias.Location = new Point(209, 173);
            btnModificarMaterias.Name = "btnModificarMaterias";
            btnModificarMaterias.Size = new Size(158, 48);
            btnModificarMaterias.TabIndex = 197;
            btnModificarMaterias.Text = "Modificar";
            btnModificarMaterias.UseVisualStyleBackColor = true;
            btnModificarMaterias.Click += btnModificarMaterias_Click;
            // 
            // btnAgregarMaterias
            // 
            btnAgregarMaterias.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnAgregarMaterias.Font = new Font("Century Gothic", 11.25F);
            btnAgregarMaterias.ForeColor = Color.Black;
            btnAgregarMaterias.Image = Properties.Resources.Agregar;
            btnAgregarMaterias.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarMaterias.Location = new Point(27, 173);
            btnAgregarMaterias.Name = "btnAgregarMaterias";
            btnAgregarMaterias.Size = new Size(156, 48);
            btnAgregarMaterias.TabIndex = 196;
            btnAgregarMaterias.Text = "Agregar";
            btnAgregarMaterias.UseVisualStyleBackColor = true;
            btnAgregarMaterias.Click += btnAgregarMaterias_Click;
            // 
            // txtIdMateria
            // 
            txtIdMateria.ForeColor = Color.Black;
            txtIdMateria.Location = new Point(93, 69);
            txtIdMateria.Name = "txtIdMateria";
            txtIdMateria.Size = new Size(42, 23);
            txtIdMateria.TabIndex = 195;
            // 
            // lblIdMateria
            // 
            lblIdMateria.AutoSize = true;
            lblIdMateria.ForeColor = Color.Transparent;
            lblIdMateria.Location = new Point(27, 72);
            lblIdMateria.Name = "lblIdMateria";
            lblIdMateria.Size = new Size(60, 15);
            lblIdMateria.TabIndex = 194;
            lblIdMateria.Text = "Id Materia";
            // 
            // error1
            // 
            error1.ContainerControl = this;
            // 
            // btnReporteMaterias
            // 
            btnReporteMaterias.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReporteMaterias.Location = new Point(39, 395);
            btnReporteMaterias.Name = "btnReporteMaterias";
            btnReporteMaterias.Size = new Size(171, 57);
            btnReporteMaterias.TabIndex = 194;
            btnReporteMaterias.Text = "Generar reporte de Materias";
            btnReporteMaterias.UseVisualStyleBackColor = true;
            btnReporteMaterias.Click += btnReporteMaterias_Click;
            // 
            // ABMMaterias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(850, 491);
            ControlBox = false;
            Controls.Add(tcABMMaterias);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ABMMaterias";
            Text = "Materias";
            tcABMMaterias.ResumeLayout(false);
            tpMaterias.ResumeLayout(false);
            tpMaterias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grillaMaterias).EndInit();
            tpABMMaterias.ResumeLayout(false);
            tpABMMaterias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grillaCarreras).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaProfesores).EndInit();
            ((System.ComponentModel.ISupportInitialize)error1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcABMMaterias;
        private TabPage tpMaterias;
        private TabPage tpABMMaterias;
        private DataGridView grillaMaterias;
        private Label label5;
        private Label label6;
        private TextBox txtAñoCursadaMateria;
        private Label lblAñoCursadaMateria;
        private TextBox txtNombreMateria;
        private Label lblNombreMateria;
        private TextBox txtIdProfesor;
        private Label lblIdProfesor;
        private TextBox txtIdCarreraxMateria;
        private Label lblIdCarreraMateria;
        private Button btnEliminarMaterias;
        private Button btnModificarMaterias;
        private Button btnAgregarMaterias;
        private TextBox txtIdMateria;
        private Label lblIdMateria;
        private DataGridView grillaCarreras;
        private DataGridView grillaProfesores;
        private ErrorProvider error1;
        private Button btnLimpiar;
        private Button btnReporteMaterias;
    }
}