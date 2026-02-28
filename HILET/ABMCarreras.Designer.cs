namespace HILET
{
    partial class ABMCarreras
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
            tpCarreras = new TabPage();
            label1 = new Label();
            label2 = new Label();
            grillaCarreras = new DataGridView();
            btnEliminarCarreras = new Button();
            btnModificarCarreras = new Button();
            btnAgregarCarreras = new Button();
            txtDuracionCarrera = new TextBox();
            txtResolucionCarrera = new TextBox();
            txtCarreraNombre = new TextBox();
            txtIdCarrera = new TextBox();
            lblDuracionCarrera = new Label();
            lblResolucionCarrera = new Label();
            lblCarreraNombre = new Label();
            lblIdCarrera = new Label();
            tcReportesCarrera = new TabControl();
            error1 = new ErrorProvider(components);
            btnReporteCarreras = new Button();
            tpCarreras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grillaCarreras).BeginInit();
            tcReportesCarrera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)error1).BeginInit();
            SuspendLayout();
            // 
            // tpCarreras
            // 
            tpCarreras.BackColor = Color.FromArgb(49, 66, 82);
            tpCarreras.Controls.Add(btnReporteCarreras);
            tpCarreras.Controls.Add(label1);
            tpCarreras.Controls.Add(label2);
            tpCarreras.Controls.Add(grillaCarreras);
            tpCarreras.Controls.Add(btnEliminarCarreras);
            tpCarreras.Controls.Add(btnModificarCarreras);
            tpCarreras.Controls.Add(btnAgregarCarreras);
            tpCarreras.Controls.Add(txtDuracionCarrera);
            tpCarreras.Controls.Add(txtResolucionCarrera);
            tpCarreras.Controls.Add(txtCarreraNombre);
            tpCarreras.Controls.Add(txtIdCarrera);
            tpCarreras.Controls.Add(lblDuracionCarrera);
            tpCarreras.Controls.Add(lblResolucionCarrera);
            tpCarreras.Controls.Add(lblCarreraNombre);
            tpCarreras.Controls.Add(lblIdCarrera);
            tpCarreras.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tpCarreras.ForeColor = Color.Black;
            tpCarreras.Location = new Point(4, 24);
            tpCarreras.Name = "tpCarreras";
            tpCarreras.Padding = new Padding(3);
            tpCarreras.Size = new Size(842, 463);
            tpCarreras.TabIndex = 0;
            tpCarreras.Text = "Carreras";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 192, 0);
            label1.Location = new Point(8, 12);
            label1.Name = "label1";
            label1.Size = new Size(521, 25);
            label1.TabIndex = 192;
            label1.Text = "Haga doble click en la carrera para modificar/eliminar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(192, 192, 0);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(22, 337);
            label2.Name = "label2";
            label2.Size = new Size(472, 16);
            label2.TabIndex = 191;
            label2.Text = "El campo de Id se llena solamente si se va a modificar/eliminar alguna carrera";
            // 
            // grillaCarreras
            // 
            grillaCarreras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaCarreras.Location = new Point(19, 49);
            grillaCarreras.Name = "grillaCarreras";
            grillaCarreras.ReadOnly = true;
            grillaCarreras.Size = new Size(437, 279);
            grillaCarreras.TabIndex = 133;
            grillaCarreras.CellContentClick += grillaCarreras_CellContentClick;
            grillaCarreras.CellDoubleClick += grillaCarreras_CellDoubleClick;
            // 
            // btnEliminarCarreras
            // 
            btnEliminarCarreras.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnEliminarCarreras.Font = new Font("Century Gothic", 11.25F);
            btnEliminarCarreras.ForeColor = Color.Black;
            btnEliminarCarreras.Image = Properties.Resources.Eliminar;
            btnEliminarCarreras.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarCarreras.Location = new Point(471, 255);
            btnEliminarCarreras.Name = "btnEliminarCarreras";
            btnEliminarCarreras.Size = new Size(152, 48);
            btnEliminarCarreras.TabIndex = 81;
            btnEliminarCarreras.Text = "Eliminar";
            btnEliminarCarreras.UseVisualStyleBackColor = true;
            btnEliminarCarreras.Click += btnEliminarCarreras_Click;
            // 
            // btnModificarCarreras
            // 
            btnModificarCarreras.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnModificarCarreras.Font = new Font("Century Gothic", 11.25F);
            btnModificarCarreras.ForeColor = Color.Black;
            btnModificarCarreras.Image = Properties.Resources.Modificar;
            btnModificarCarreras.ImageAlign = ContentAlignment.MiddleLeft;
            btnModificarCarreras.Location = new Point(471, 164);
            btnModificarCarreras.Name = "btnModificarCarreras";
            btnModificarCarreras.Size = new Size(152, 48);
            btnModificarCarreras.TabIndex = 80;
            btnModificarCarreras.Text = "Modificar";
            btnModificarCarreras.UseVisualStyleBackColor = true;
            btnModificarCarreras.Click += btnModificarCarreras_Click;
            // 
            // btnAgregarCarreras
            // 
            btnAgregarCarreras.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnAgregarCarreras.Font = new Font("Century Gothic", 11.25F);
            btnAgregarCarreras.ForeColor = Color.Black;
            btnAgregarCarreras.Image = Properties.Resources.Agregar;
            btnAgregarCarreras.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarCarreras.Location = new Point(471, 71);
            btnAgregarCarreras.Name = "btnAgregarCarreras";
            btnAgregarCarreras.Size = new Size(152, 48);
            btnAgregarCarreras.TabIndex = 78;
            btnAgregarCarreras.Text = "Agregar";
            btnAgregarCarreras.UseVisualStyleBackColor = true;
            btnAgregarCarreras.Click += btnAgregarCarreras_Click;
            // 
            // txtDuracionCarrera
            // 
            txtDuracionCarrera.ForeColor = Color.Black;
            txtDuracionCarrera.Location = new Point(337, 422);
            txtDuracionCarrera.Name = "txtDuracionCarrera";
            txtDuracionCarrera.Size = new Size(145, 22);
            txtDuracionCarrera.TabIndex = 7;
            // 
            // txtResolucionCarrera
            // 
            txtResolucionCarrera.ForeColor = Color.Black;
            txtResolucionCarrera.Location = new Point(97, 422);
            txtResolucionCarrera.Name = "txtResolucionCarrera";
            txtResolucionCarrera.Size = new Size(145, 22);
            txtResolucionCarrera.TabIndex = 5;
            // 
            // txtCarreraNombre
            // 
            txtCarreraNombre.ForeColor = Color.Black;
            txtCarreraNombre.Location = new Point(337, 377);
            txtCarreraNombre.Name = "txtCarreraNombre";
            txtCarreraNombre.Size = new Size(145, 22);
            txtCarreraNombre.TabIndex = 3;
            // 
            // txtIdCarrera
            // 
            txtIdCarrera.ForeColor = Color.Black;
            txtIdCarrera.Location = new Point(97, 377);
            txtIdCarrera.Name = "txtIdCarrera";
            txtIdCarrera.Size = new Size(145, 22);
            txtIdCarrera.TabIndex = 1;
            // 
            // lblDuracionCarrera
            // 
            lblDuracionCarrera.AutoSize = true;
            lblDuracionCarrera.ForeColor = Color.White;
            lblDuracionCarrera.Location = new Point(268, 425);
            lblDuracionCarrera.Name = "lblDuracionCarrera";
            lblDuracionCarrera.Size = new Size(54, 14);
            lblDuracionCarrera.TabIndex = 6;
            lblDuracionCarrera.Text = "Duracion";
            // 
            // lblResolucionCarrera
            // 
            lblResolucionCarrera.AutoSize = true;
            lblResolucionCarrera.ForeColor = Color.White;
            lblResolucionCarrera.Location = new Point(18, 425);
            lblResolucionCarrera.Name = "lblResolucionCarrera";
            lblResolucionCarrera.Size = new Size(64, 14);
            lblResolucionCarrera.TabIndex = 4;
            lblResolucionCarrera.Text = "Resolucion";
            // 
            // lblCarreraNombre
            // 
            lblCarreraNombre.AutoSize = true;
            lblCarreraNombre.ForeColor = Color.White;
            lblCarreraNombre.Location = new Point(268, 380);
            lblCarreraNombre.Name = "lblCarreraNombre";
            lblCarreraNombre.Size = new Size(50, 14);
            lblCarreraNombre.TabIndex = 2;
            lblCarreraNombre.Text = "Nombre";
            // 
            // lblIdCarrera
            // 
            lblIdCarrera.AutoSize = true;
            lblIdCarrera.ForeColor = Color.White;
            lblIdCarrera.Location = new Point(60, 377);
            lblIdCarrera.Name = "lblIdCarrera";
            lblIdCarrera.Size = new Size(18, 14);
            lblIdCarrera.TabIndex = 0;
            lblIdCarrera.Text = "Id";
            // 
            // tcReportesCarrera
            // 
            tcReportesCarrera.Controls.Add(tpCarreras);
            tcReportesCarrera.Dock = DockStyle.Fill;
            tcReportesCarrera.Location = new Point(0, 0);
            tcReportesCarrera.Name = "tcReportesCarrera";
            tcReportesCarrera.SelectedIndex = 0;
            tcReportesCarrera.Size = new Size(850, 491);
            tcReportesCarrera.TabIndex = 0;
            // 
            // error1
            // 
            error1.ContainerControl = this;
            // 
            // btnReporteCarreras
            // 
            btnReporteCarreras.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReporteCarreras.Location = new Point(653, 398);
            btnReporteCarreras.Name = "btnReporteCarreras";
            btnReporteCarreras.Size = new Size(171, 57);
            btnReporteCarreras.TabIndex = 193;
            btnReporteCarreras.Text = "Generar reporte de Carreras";
            btnReporteCarreras.UseVisualStyleBackColor = true;
            btnReporteCarreras.Click += btnReporteCarreras_Click;
            // 
            // ABMCarreras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(850, 491);
            ControlBox = false;
            Controls.Add(tcReportesCarrera);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ABMCarreras";
            Text = "ABMCarreras";
            tpCarreras.ResumeLayout(false);
            tpCarreras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grillaCarreras).EndInit();
            tcReportesCarrera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)error1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBox2;
        private TextBox textBox3;
        private TabPage tpCarreras;
        private DataGridView grillaCarreras;
        private Button btnEliminarCarreras;
        private Button btnModificarCarreras;
        private Button btnAgregarCarreras;
        private TextBox txtDuracionCarrera;
        private TextBox txtResolucionCarrera;
        private TextBox txtCarreraNombre;
        private TextBox txtIdCarrera;
        private Label lblDuracionCarrera;
        private Label lblResolucionCarrera;
        private Label lblCarreraNombre;
        private Label lblIdCarrera;
        private TabControl tcReportesCarrera;
        private Label label2;
        private ErrorProvider error1;
        private Label label1;
        private Button btnReporteCarreras;
    }
}