namespace HILET
{
    partial class Materias
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
            dtgMaterias = new DataGridView();
            btnPdf = new Button();
            btnInicio = new Button();
            menuStrip1 = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            examenesToolStripMenuItem = new ToolStripMenuItem();
            materiasToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            btnSalir = new Button();
            btnMinimizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgMaterias).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dtgMaterias
            // 
            dtgMaterias.BackgroundColor = Color.FromArgb(33, 63, 97);
            dtgMaterias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgMaterias.Location = new Point(448, 46);
            dtgMaterias.Name = "dtgMaterias";
            dtgMaterias.Size = new Size(400, 446);
            dtgMaterias.TabIndex = 8;
            // 
            // btnPdf
            // 
            btnPdf.BackColor = Color.White;
            btnPdf.FlatStyle = FlatStyle.Popup;
            btnPdf.Font = new Font("Segoe UI", 18F);
            btnPdf.Image = Properties.Resources.Examenes2;
            btnPdf.Location = new Point(65, 279);
            btnPdf.Name = "btnPdf";
            btnPdf.Size = new Size(275, 130);
            btnPdf.TabIndex = 6;
            btnPdf.Text = "Exportar";
            btnPdf.TextAlign = ContentAlignment.BottomCenter;
            btnPdf.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPdf.UseVisualStyleBackColor = false;
            btnPdf.Click += btnPdf_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.White;
            btnInicio.FlatStyle = FlatStyle.Popup;
            btnInicio.Font = new Font("Segoe UI", 18F);
            btnInicio.Image = Properties.Resources.inicio;
            btnInicio.Location = new Point(65, 89);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(275, 130);
            btnInicio.TabIndex = 7;
            btnInicio.Text = "Inicio";
            btnInicio.TextAlign = ContentAlignment.BottomCenter;
            btnInicio.TextImageRelation = TextImageRelation.ImageAboveText;
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click_1;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1070, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { examenesToolStripMenuItem, materiasToolStripMenuItem, salirToolStripMenuItem });
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(50, 20);
            inicioToolStripMenuItem.Text = "Menu";
            // 
            // examenesToolStripMenuItem
            // 
            examenesToolStripMenuItem.Name = "examenesToolStripMenuItem";
            examenesToolStripMenuItem.Size = new Size(151, 22);
            examenesToolStripMenuItem.Text = "Inicio";
            // 
            // materiasToolStripMenuItem
            // 
            materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            materiasToolStripMenuItem.Size = new Size(151, 22);
            materiasToolStripMenuItem.Text = "Exportar a PDF";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(151, 22);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.LightGray;
            btnSalir.FlatAppearance.BorderColor = Color.White;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnSalir.Location = new Point(1015, 37);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(43, 24);
            btnSalir.TabIndex = 9;
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
            btnMinimizar.Location = new Point(959, 37);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(50, 24);
            btnMinimizar.TabIndex = 35;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // Materias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 63, 97);
            ClientSize = new Size(1070, 526);
            Controls.Add(btnMinimizar);
            Controls.Add(btnSalir);
            Controls.Add(dtgMaterias);
            Controls.Add(btnPdf);
            Controls.Add(btnInicio);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Materias";
            Text = "Materias";
            ((System.ComponentModel.ISupportInitialize)dtgMaterias).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgMaterias;
        private Button btnPdf;
        private Button btnInicio;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem examenesToolStripMenuItem;
        private ToolStripMenuItem materiasToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private Button btnSalir;
        private Button btnMinimizar;
    }
}