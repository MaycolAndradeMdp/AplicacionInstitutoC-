namespace HILET
{
    partial class ABMAlumnos
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
            lblCalendario = new Label();
            error1 = new ErrorProvider(components);
            tpCarreras = new TabPage();
            btnEliminarAlumnoCarrera = new Button();
            pnlInferior = new Panel();
            grillaAlumnosxCarrera = new DataGridView();
            btnModificarAlumnoCarrera = new Button();
            txtMatricula2 = new TextBox();
            txtAñoCursadaAlumno = new TextBox();
            lblMatricula2 = new Label();
            btnAgregarAlumnoCarrera = new Button();
            label3 = new Label();
            cmbCarreraAlumno = new ComboBox();
            lblAñoCursadaAlumno = new Label();
            lblCarreraAlumno = new Label();
            tpABMAlumnos = new TabPage();
            btnLimpiar = new Button();
            label2 = new Label();
            txtUsuarioAlumno = new TextBox();
            txtContraseñaAlumno = new TextBox();
            txtMatricula = new TextBox();
            txtEmailAlumno = new TextBox();
            txtTelefonoAlumno = new TextBox();
            txtNumeroCalleAlumno = new TextBox();
            txtNombreAlumno = new TextBox();
            txtDomicilioCalleAlumno = new TextBox();
            txtApellidoAlumno = new TextBox();
            txtDniAlumno = new TextBox();
            lblContraseñaAlumno = new Label();
            lblUsuarioAlumno = new Label();
            btnAgregarAlumno = new Button();
            btnEliminarAlumno = new Button();
            btnModificarAlumno = new Button();
            lblMatricula = new Label();
            lblNombreAlumno = new Label();
            lblDniAlumno = new Label();
            lblDomicilioCalleAlumno = new Label();
            lblNumeroCalleAlumno = new Label();
            lblTelefonoAlumno = new Label();
            lblEmailAlumno = new Label();
            lblApellidoAlumno = new Label();
            tpAlumnos = new TabPage();
            btnReporteAlumnos = new Button();
            label4 = new Label();
            cmbFiltroAlumnos = new ComboBox();
            label1 = new Label();
            grillaAlumnos = new DataGridView();
            tcABMAlumnos = new TabControl();
            ((System.ComponentModel.ISupportInitialize)error1).BeginInit();
            tpCarreras.SuspendLayout();
            pnlInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grillaAlumnosxCarrera).BeginInit();
            tpABMAlumnos.SuspendLayout();
            tpAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grillaAlumnos).BeginInit();
            tcABMAlumnos.SuspendLayout();
            SuspendLayout();
            // 
            // lblCalendario
            // 
            lblCalendario.AutoSize = true;
            lblCalendario.ForeColor = Color.Silver;
            lblCalendario.Location = new Point(925, 218);
            lblCalendario.Name = "lblCalendario";
            lblCalendario.Size = new Size(154, 15);
            lblCalendario.TabIndex = 79;
            lblCalendario.Text = "Ingrese fecha de inscripcion";
            // 
            // error1
            // 
            error1.ContainerControl = this;
            // 
            // tpCarreras
            // 
            tpCarreras.BackColor = Color.FromArgb(49, 66, 82);
            tpCarreras.Controls.Add(btnEliminarAlumnoCarrera);
            tpCarreras.Controls.Add(pnlInferior);
            tpCarreras.Controls.Add(btnModificarAlumnoCarrera);
            tpCarreras.Controls.Add(txtMatricula2);
            tpCarreras.Controls.Add(txtAñoCursadaAlumno);
            tpCarreras.Controls.Add(lblMatricula2);
            tpCarreras.Controls.Add(btnAgregarAlumnoCarrera);
            tpCarreras.Controls.Add(label3);
            tpCarreras.Controls.Add(cmbCarreraAlumno);
            tpCarreras.Controls.Add(lblAñoCursadaAlumno);
            tpCarreras.Controls.Add(lblCarreraAlumno);
            tpCarreras.Location = new Point(4, 24);
            tpCarreras.Name = "tpCarreras";
            tpCarreras.Padding = new Padding(3);
            tpCarreras.Size = new Size(842, 463);
            tpCarreras.TabIndex = 2;
            tpCarreras.Text = "Carreras";
            // 
            // btnEliminarAlumnoCarrera
            // 
            btnEliminarAlumnoCarrera.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnEliminarAlumnoCarrera.Font = new Font("Century Gothic", 11.25F);
            btnEliminarAlumnoCarrera.Image = Properties.Resources.Eliminar;
            btnEliminarAlumnoCarrera.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarAlumnoCarrera.Location = new Point(456, 175);
            btnEliminarAlumnoCarrera.Name = "btnEliminarAlumnoCarrera";
            btnEliminarAlumnoCarrera.Size = new Size(169, 39);
            btnEliminarAlumnoCarrera.TabIndex = 204;
            btnEliminarAlumnoCarrera.Text = "Eliminar";
            btnEliminarAlumnoCarrera.UseVisualStyleBackColor = true;
            btnEliminarAlumnoCarrera.Click += btnEliminarAlumnoCarrera_Click;
            // 
            // pnlInferior
            // 
            pnlInferior.Controls.Add(grillaAlumnosxCarrera);
            pnlInferior.Location = new Point(3, 236);
            pnlInferior.Name = "pnlInferior";
            pnlInferior.Size = new Size(836, 224);
            pnlInferior.TabIndex = 203;
            // 
            // grillaAlumnosxCarrera
            // 
            grillaAlumnosxCarrera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaAlumnosxCarrera.Location = new Point(76, -3);
            grillaAlumnosxCarrera.Name = "grillaAlumnosxCarrera";
            grillaAlumnosxCarrera.ReadOnly = true;
            grillaAlumnosxCarrera.Size = new Size(656, 224);
            grillaAlumnosxCarrera.TabIndex = 202;
            grillaAlumnosxCarrera.CellDoubleClick += grillaAlumnosxCarrera_CellDoubleClick;
            // 
            // btnModificarAlumnoCarrera
            // 
            btnModificarAlumnoCarrera.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnModificarAlumnoCarrera.Font = new Font("Century Gothic", 11.25F);
            btnModificarAlumnoCarrera.Image = Properties.Resources.Modificar;
            btnModificarAlumnoCarrera.ImageAlign = ContentAlignment.MiddleLeft;
            btnModificarAlumnoCarrera.Location = new Point(265, 175);
            btnModificarAlumnoCarrera.Name = "btnModificarAlumnoCarrera";
            btnModificarAlumnoCarrera.Size = new Size(158, 39);
            btnModificarAlumnoCarrera.TabIndex = 201;
            btnModificarAlumnoCarrera.Text = "Modificar";
            btnModificarAlumnoCarrera.UseVisualStyleBackColor = true;
            btnModificarAlumnoCarrera.Click += btnModificarAlumnoCarrera_Click;
            // 
            // txtMatricula2
            // 
            txtMatricula2.Location = new Point(156, 68);
            txtMatricula2.Name = "txtMatricula2";
            txtMatricula2.Size = new Size(81, 23);
            txtMatricula2.TabIndex = 200;
            // 
            // txtAñoCursadaAlumno
            // 
            txtAñoCursadaAlumno.Location = new Point(429, 115);
            txtAñoCursadaAlumno.Name = "txtAñoCursadaAlumno";
            txtAñoCursadaAlumno.Size = new Size(131, 23);
            txtAñoCursadaAlumno.TabIndex = 195;
            // 
            // lblMatricula2
            // 
            lblMatricula2.AutoSize = true;
            lblMatricula2.ForeColor = Color.White;
            lblMatricula2.Location = new Point(77, 71);
            lblMatricula2.Name = "lblMatricula2";
            lblMatricula2.Size = new Size(57, 15);
            lblMatricula2.TabIndex = 199;
            lblMatricula2.Text = "Matricula";
            // 
            // btnAgregarAlumnoCarrera
            // 
            btnAgregarAlumnoCarrera.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnAgregarAlumnoCarrera.Font = new Font("Century Gothic", 11.25F);
            btnAgregarAlumnoCarrera.Image = Properties.Resources.Agregar;
            btnAgregarAlumnoCarrera.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarAlumnoCarrera.Location = new Point(79, 175);
            btnAgregarAlumnoCarrera.Name = "btnAgregarAlumnoCarrera";
            btnAgregarAlumnoCarrera.Size = new Size(158, 39);
            btnAgregarAlumnoCarrera.TabIndex = 198;
            btnAgregarAlumnoCarrera.Text = "Agregar";
            btnAgregarAlumnoCarrera.UseVisualStyleBackColor = true;
            btnAgregarAlumnoCarrera.Click += btnAgregarAlumnoCarrera_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 255, 192);
            label3.Location = new Point(276, 20);
            label3.Name = "label3";
            label3.Size = new Size(278, 30);
            label3.TabIndex = 197;
            label3.Text = "Añadir alumno a una carrera";
            // 
            // cmbCarreraAlumno
            // 
            cmbCarreraAlumno.FormattingEnabled = true;
            cmbCarreraAlumno.Location = new Point(156, 112);
            cmbCarreraAlumno.Name = "cmbCarreraAlumno";
            cmbCarreraAlumno.Size = new Size(153, 23);
            cmbCarreraAlumno.TabIndex = 196;
            // 
            // lblAñoCursadaAlumno
            // 
            lblAñoCursadaAlumno.AutoSize = true;
            lblAñoCursadaAlumno.ForeColor = Color.White;
            lblAñoCursadaAlumno.Location = new Point(332, 118);
            lblAñoCursadaAlumno.Name = "lblAñoCursadaAlumno";
            lblAñoCursadaAlumno.Size = new Size(91, 15);
            lblAñoCursadaAlumno.TabIndex = 193;
            lblAñoCursadaAlumno.Text = "Año de Cursada";
            // 
            // lblCarreraAlumno
            // 
            lblCarreraAlumno.AutoSize = true;
            lblCarreraAlumno.ForeColor = Color.White;
            lblCarreraAlumno.Location = new Point(77, 115);
            lblCarreraAlumno.Name = "lblCarreraAlumno";
            lblCarreraAlumno.Size = new Size(45, 15);
            lblCarreraAlumno.TabIndex = 194;
            lblCarreraAlumno.Text = "Carrera";
            // 
            // tpABMAlumnos
            // 
            tpABMAlumnos.BackColor = Color.FromArgb(49, 66, 82);
            tpABMAlumnos.Controls.Add(btnLimpiar);
            tpABMAlumnos.Controls.Add(label2);
            tpABMAlumnos.Controls.Add(txtUsuarioAlumno);
            tpABMAlumnos.Controls.Add(txtContraseñaAlumno);
            tpABMAlumnos.Controls.Add(txtMatricula);
            tpABMAlumnos.Controls.Add(txtEmailAlumno);
            tpABMAlumnos.Controls.Add(txtTelefonoAlumno);
            tpABMAlumnos.Controls.Add(txtNumeroCalleAlumno);
            tpABMAlumnos.Controls.Add(txtNombreAlumno);
            tpABMAlumnos.Controls.Add(txtDomicilioCalleAlumno);
            tpABMAlumnos.Controls.Add(txtApellidoAlumno);
            tpABMAlumnos.Controls.Add(txtDniAlumno);
            tpABMAlumnos.Controls.Add(lblContraseñaAlumno);
            tpABMAlumnos.Controls.Add(lblUsuarioAlumno);
            tpABMAlumnos.Controls.Add(btnAgregarAlumno);
            tpABMAlumnos.Controls.Add(btnEliminarAlumno);
            tpABMAlumnos.Controls.Add(btnModificarAlumno);
            tpABMAlumnos.Controls.Add(lblMatricula);
            tpABMAlumnos.Controls.Add(lblNombreAlumno);
            tpABMAlumnos.Controls.Add(lblDniAlumno);
            tpABMAlumnos.Controls.Add(lblDomicilioCalleAlumno);
            tpABMAlumnos.Controls.Add(lblNumeroCalleAlumno);
            tpABMAlumnos.Controls.Add(lblTelefonoAlumno);
            tpABMAlumnos.Controls.Add(lblEmailAlumno);
            tpABMAlumnos.Controls.Add(lblApellidoAlumno);
            tpABMAlumnos.Location = new Point(4, 24);
            tpABMAlumnos.Name = "tpABMAlumnos";
            tpABMAlumnos.Padding = new Padding(3);
            tpABMAlumnos.Size = new Size(842, 463);
            tpABMAlumnos.TabIndex = 1;
            tpABMAlumnos.Text = "ABM";
            // 
            // btnLimpiar
            // 
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnLimpiar.Font = new Font("Century Gothic", 11.25F);
            btnLimpiar.Image = Properties.Resources.delete_4219;
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(594, 174);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(169, 39);
            btnLimpiar.TabIndex = 191;
            btnLimpiar.Text = "Limpiar ";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(192, 192, 0);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(15, 29);
            label2.Name = "label2";
            label2.Size = new Size(508, 16);
            label2.TabIndex = 190;
            label2.Text = "El campo de matricula se llena solamente si se va a modificar/eliminar algún alumno";
            // 
            // txtUsuarioAlumno
            // 
            txtUsuarioAlumno.Location = new Point(616, 96);
            txtUsuarioAlumno.Name = "txtUsuarioAlumno";
            txtUsuarioAlumno.Size = new Size(168, 23);
            txtUsuarioAlumno.TabIndex = 181;
            // 
            // txtContraseñaAlumno
            // 
            txtContraseñaAlumno.Location = new Point(616, 129);
            txtContraseñaAlumno.Name = "txtContraseñaAlumno";
            txtContraseñaAlumno.Size = new Size(168, 23);
            txtContraseñaAlumno.TabIndex = 180;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(78, 61);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(168, 23);
            txtMatricula.TabIndex = 165;
            // 
            // txtEmailAlumno
            // 
            txtEmailAlumno.Location = new Point(329, 99);
            txtEmailAlumno.Name = "txtEmailAlumno";
            txtEmailAlumno.Size = new Size(168, 23);
            txtEmailAlumno.TabIndex = 172;
            // 
            // txtTelefonoAlumno
            // 
            txtTelefonoAlumno.Location = new Point(329, 132);
            txtTelefonoAlumno.Name = "txtTelefonoAlumno";
            txtTelefonoAlumno.Size = new Size(168, 23);
            txtTelefonoAlumno.TabIndex = 171;
            // 
            // txtNumeroCalleAlumno
            // 
            txtNumeroCalleAlumno.Location = new Point(734, 64);
            txtNumeroCalleAlumno.Name = "txtNumeroCalleAlumno";
            txtNumeroCalleAlumno.Size = new Size(50, 23);
            txtNumeroCalleAlumno.TabIndex = 170;
            // 
            // txtNombreAlumno
            // 
            txtNombreAlumno.Location = new Point(78, 96);
            txtNombreAlumno.Name = "txtNombreAlumno";
            txtNombreAlumno.Size = new Size(168, 23);
            txtNombreAlumno.TabIndex = 166;
            // 
            // txtDomicilioCalleAlumno
            // 
            txtDomicilioCalleAlumno.Location = new Point(616, 64);
            txtDomicilioCalleAlumno.Name = "txtDomicilioCalleAlumno";
            txtDomicilioCalleAlumno.Size = new Size(85, 23);
            txtDomicilioCalleAlumno.TabIndex = 169;
            // 
            // txtApellidoAlumno
            // 
            txtApellidoAlumno.Location = new Point(78, 132);
            txtApellidoAlumno.Name = "txtApellidoAlumno";
            txtApellidoAlumno.Size = new Size(168, 23);
            txtApellidoAlumno.TabIndex = 167;
            // 
            // txtDniAlumno
            // 
            txtDniAlumno.Location = new Point(329, 64);
            txtDniAlumno.Name = "txtDniAlumno";
            txtDniAlumno.Size = new Size(168, 23);
            txtDniAlumno.TabIndex = 168;
            // 
            // lblContraseñaAlumno
            // 
            lblContraseñaAlumno.AutoSize = true;
            lblContraseñaAlumno.ForeColor = Color.White;
            lblContraseñaAlumno.Location = new Point(534, 132);
            lblContraseñaAlumno.Name = "lblContraseñaAlumno";
            lblContraseñaAlumno.Size = new Size(67, 15);
            lblContraseñaAlumno.TabIndex = 178;
            lblContraseñaAlumno.Text = "Contraseña";
            // 
            // lblUsuarioAlumno
            // 
            lblUsuarioAlumno.AutoSize = true;
            lblUsuarioAlumno.ForeColor = Color.White;
            lblUsuarioAlumno.Location = new Point(543, 99);
            lblUsuarioAlumno.Name = "lblUsuarioAlumno";
            lblUsuarioAlumno.Size = new Size(47, 15);
            lblUsuarioAlumno.TabIndex = 179;
            lblUsuarioAlumno.Text = "Usuario";
            // 
            // btnAgregarAlumno
            // 
            btnAgregarAlumno.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnAgregarAlumno.Font = new Font("Century Gothic", 11.25F);
            btnAgregarAlumno.Image = Properties.Resources.Agregar;
            btnAgregarAlumno.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarAlumno.Location = new Point(11, 173);
            btnAgregarAlumno.Name = "btnAgregarAlumno";
            btnAgregarAlumno.Size = new Size(161, 40);
            btnAgregarAlumno.TabIndex = 177;
            btnAgregarAlumno.Text = "Dar de alta";
            btnAgregarAlumno.UseVisualStyleBackColor = true;
            btnAgregarAlumno.Click += btnAgregarAlumno_Click_1;
            // 
            // btnEliminarAlumno
            // 
            btnEliminarAlumno.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnEliminarAlumno.Font = new Font("Century Gothic", 11.25F);
            btnEliminarAlumno.Image = Properties.Resources.Eliminar;
            btnEliminarAlumno.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarAlumno.Location = new Point(390, 173);
            btnEliminarAlumno.Name = "btnEliminarAlumno";
            btnEliminarAlumno.Size = new Size(169, 39);
            btnEliminarAlumno.TabIndex = 176;
            btnEliminarAlumno.Text = "Dar de baja";
            btnEliminarAlumno.UseVisualStyleBackColor = true;
            btnEliminarAlumno.Click += btnEliminarAlumno_Click;
            // 
            // btnModificarAlumno
            // 
            btnModificarAlumno.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnModificarAlumno.Font = new Font("Century Gothic", 11.25F);
            btnModificarAlumno.Image = Properties.Resources.Modificar;
            btnModificarAlumno.ImageAlign = ContentAlignment.MiddleLeft;
            btnModificarAlumno.Location = new Point(197, 173);
            btnModificarAlumno.Name = "btnModificarAlumno";
            btnModificarAlumno.Size = new Size(158, 39);
            btnModificarAlumno.TabIndex = 175;
            btnModificarAlumno.Text = "Modificar";
            btnModificarAlumno.UseVisualStyleBackColor = true;
            btnModificarAlumno.Click += btnModificarAlumno_Click;
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.ForeColor = Color.White;
            lblMatricula.Location = new Point(15, 64);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(57, 15);
            lblMatricula.TabIndex = 155;
            lblMatricula.Text = "Matricula";
            // 
            // lblNombreAlumno
            // 
            lblNombreAlumno.AutoSize = true;
            lblNombreAlumno.ForeColor = Color.White;
            lblNombreAlumno.Location = new Point(15, 96);
            lblNombreAlumno.Name = "lblNombreAlumno";
            lblNombreAlumno.Size = new Size(51, 15);
            lblNombreAlumno.TabIndex = 156;
            lblNombreAlumno.Text = "Nombre";
            // 
            // lblDniAlumno
            // 
            lblDniAlumno.AutoSize = true;
            lblDniAlumno.ForeColor = Color.White;
            lblDniAlumno.Location = new Point(272, 67);
            lblDniAlumno.Name = "lblDniAlumno";
            lblDniAlumno.Size = new Size(27, 15);
            lblDniAlumno.TabIndex = 157;
            lblDniAlumno.Text = "DNI";
            // 
            // lblDomicilioCalleAlumno
            // 
            lblDomicilioCalleAlumno.AutoSize = true;
            lblDomicilioCalleAlumno.ForeColor = Color.White;
            lblDomicilioCalleAlumno.Location = new Point(516, 64);
            lblDomicilioCalleAlumno.Name = "lblDomicilioCalleAlumno";
            lblDomicilioCalleAlumno.Size = new Size(85, 15);
            lblDomicilioCalleAlumno.TabIndex = 158;
            lblDomicilioCalleAlumno.Text = "Domicilio calle";
            // 
            // lblNumeroCalleAlumno
            // 
            lblNumeroCalleAlumno.AutoSize = true;
            lblNumeroCalleAlumno.ForeColor = Color.White;
            lblNumeroCalleAlumno.Location = new Point(707, 67);
            lblNumeroCalleAlumno.Name = "lblNumeroCalleAlumno";
            lblNumeroCalleAlumno.Size = new Size(21, 15);
            lblNumeroCalleAlumno.TabIndex = 159;
            lblNumeroCalleAlumno.Text = "N°";
            // 
            // lblTelefonoAlumno
            // 
            lblTelefonoAlumno.AutoSize = true;
            lblTelefonoAlumno.ForeColor = Color.White;
            lblTelefonoAlumno.Location = new Point(269, 135);
            lblTelefonoAlumno.Name = "lblTelefonoAlumno";
            lblTelefonoAlumno.Size = new Size(54, 15);
            lblTelefonoAlumno.TabIndex = 160;
            lblTelefonoAlumno.Text = "Telefono";
            // 
            // lblEmailAlumno
            // 
            lblEmailAlumno.AutoSize = true;
            lblEmailAlumno.ForeColor = Color.White;
            lblEmailAlumno.Location = new Point(272, 99);
            lblEmailAlumno.Name = "lblEmailAlumno";
            lblEmailAlumno.Size = new Size(36, 15);
            lblEmailAlumno.TabIndex = 161;
            lblEmailAlumno.Text = "Email";
            // 
            // lblApellidoAlumno
            // 
            lblApellidoAlumno.AutoSize = true;
            lblApellidoAlumno.ForeColor = Color.White;
            lblApellidoAlumno.Location = new Point(15, 132);
            lblApellidoAlumno.Name = "lblApellidoAlumno";
            lblApellidoAlumno.Size = new Size(51, 15);
            lblApellidoAlumno.TabIndex = 164;
            lblApellidoAlumno.Text = "Apellido";
            // 
            // tpAlumnos
            // 
            tpAlumnos.BackColor = Color.FromArgb(49, 66, 82);
            tpAlumnos.Controls.Add(btnReporteAlumnos);
            tpAlumnos.Controls.Add(label4);
            tpAlumnos.Controls.Add(cmbFiltroAlumnos);
            tpAlumnos.Controls.Add(label1);
            tpAlumnos.Controls.Add(grillaAlumnos);
            tpAlumnos.Location = new Point(4, 24);
            tpAlumnos.Name = "tpAlumnos";
            tpAlumnos.Padding = new Padding(3);
            tpAlumnos.Size = new Size(842, 463);
            tpAlumnos.TabIndex = 0;
            tpAlumnos.Text = "Alumnos";
            // 
            // btnReporteAlumnos
            // 
            btnReporteAlumnos.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReporteAlumnos.Location = new Point(8, 393);
            btnReporteAlumnos.Name = "btnReporteAlumnos";
            btnReporteAlumnos.Size = new Size(182, 62);
            btnReporteAlumnos.TabIndex = 194;
            btnReporteAlumnos.Text = "Generar reporte de listado de alumnos";
            btnReporteAlumnos.UseVisualStyleBackColor = true;
            btnReporteAlumnos.Click += btnReporteAlumnos_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(606, 32);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 193;
            label4.Text = "Filtrar por:";
            // 
            // cmbFiltroAlumnos
            // 
            cmbFiltroAlumnos.FormattingEnabled = true;
            cmbFiltroAlumnos.Location = new Point(673, 29);
            cmbFiltroAlumnos.Name = "cmbFiltroAlumnos";
            cmbFiltroAlumnos.Size = new Size(161, 23);
            cmbFiltroAlumnos.TabIndex = 192;
            cmbFiltroAlumnos.SelectedIndexChanged += cmbFiltroAlumnos_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 192, 0);
            label1.Location = new Point(8, 24);
            label1.Name = "label1";
            label1.Size = new Size(523, 25);
            label1.TabIndex = 191;
            label1.Text = "Haga doble click en el alumno para modificar/eliminar";
            // 
            // grillaAlumnos
            // 
            grillaAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaAlumnos.Location = new Point(8, 61);
            grillaAlumnos.Name = "grillaAlumnos";
            grillaAlumnos.ReadOnly = true;
            grillaAlumnos.Size = new Size(828, 326);
            grillaAlumnos.TabIndex = 0;
            grillaAlumnos.CellDoubleClick += grillaAlumnos_CellDoubleClick;
            // 
            // tcABMAlumnos
            // 
            tcABMAlumnos.Controls.Add(tpAlumnos);
            tcABMAlumnos.Controls.Add(tpABMAlumnos);
            tcABMAlumnos.Controls.Add(tpCarreras);
            tcABMAlumnos.Dock = DockStyle.Fill;
            tcABMAlumnos.Location = new Point(0, 0);
            tcABMAlumnos.Name = "tcABMAlumnos";
            tcABMAlumnos.SelectedIndex = 0;
            tcABMAlumnos.Size = new Size(850, 491);
            tcABMAlumnos.TabIndex = 80;
            // 
            // ABMAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(850, 491);
            ControlBox = false;
            Controls.Add(tcABMAlumnos);
            Controls.Add(lblCalendario);
            Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ABMAlumnos";
            Text = "ABMAlumnos";
            ((System.ComponentModel.ISupportInitialize)error1).EndInit();
            tpCarreras.ResumeLayout(false);
            tpCarreras.PerformLayout();
            pnlInferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grillaAlumnosxCarrera).EndInit();
            tpABMAlumnos.ResumeLayout(false);
            tpABMAlumnos.PerformLayout();
            tpAlumnos.ResumeLayout(false);
            tpAlumnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grillaAlumnos).EndInit();
            tcABMAlumnos.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCalendario;
        private ErrorProvider error1;
        private TabControl tcABMAlumnos;
        private TabPage tpAlumnos;
        private Button btnReporteAlumnos;
        private Label label4;
        private ComboBox cmbFiltroAlumnos;
        private Label label1;
        private DataGridView grillaAlumnos;
        private TabPage tpABMAlumnos;
        private Button btnLimpiar;
        private Label label2;
        private TextBox txtUsuarioAlumno;
        private TextBox txtContraseñaAlumno;
        private TextBox txtMatricula;
        private TextBox txtEmailAlumno;
        private TextBox txtTelefonoAlumno;
        private TextBox txtNumeroCalleAlumno;
        private TextBox txtNombreAlumno;
        private TextBox txtDomicilioCalleAlumno;
        private TextBox txtApellidoAlumno;
        private TextBox txtDniAlumno;
        private Label lblContraseñaAlumno;
        private Label lblUsuarioAlumno;
        private Button btnAgregarAlumno;
        private Button btnEliminarAlumno;
        private Button btnModificarAlumno;
        private Label lblMatricula;
        private Label lblNombreAlumno;
        private Label lblDniAlumno;
        private Label lblDomicilioCalleAlumno;
        private Label lblNumeroCalleAlumno;
        private Label lblTelefonoAlumno;
        private Label lblEmailAlumno;
        private Label lblApellidoAlumno;
        private TabPage tpCarreras;
        private Button btnEliminarAlumnoCarrera;
        private Panel pnlInferior;
        private DataGridView grillaAlumnosxCarrera;
        private Button btnModificarAlumnoCarrera;
        private TextBox txtMatricula2;
        private TextBox txtAñoCursadaAlumno;
        private Label lblMatricula2;
        private Button btnAgregarAlumnoCarrera;
        private Label label3;
        private ComboBox cmbCarreraAlumno;
        private Label lblAñoCursadaAlumno;
        private Label lblCarreraAlumno;
    }
}