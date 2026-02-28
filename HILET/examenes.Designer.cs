namespace HILET
{
    partial class examenes
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
            menuStrip1 = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            examenesToolStripMenuItem = new ToolStripMenuItem();
            materiasToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            btnInicio = new Button();
            btnPdf = new Button();
            dtgExamenes = new DataGridView();
            btnMinimizar = new Button();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgExamenes).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1070, 24);
            menuStrip1.TabIndex = 0;
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
            examenesToolStripMenuItem.Click += examenesToolStripMenuItem_Click;
            // 
            // materiasToolStripMenuItem
            // 
            materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            materiasToolStripMenuItem.Size = new Size(151, 22);
            materiasToolStripMenuItem.Text = "Exportar a PDF";
            materiasToolStripMenuItem.Click += materiasToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(151, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.White;
            btnInicio.FlatStyle = FlatStyle.Popup;
            btnInicio.Font = new Font("Segoe UI", 18F);
            btnInicio.Image = Properties.Resources.inicio;
            btnInicio.Location = new Point(66, 116);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(275, 130);
            btnInicio.TabIndex = 3;
            btnInicio.Text = "Inicio";
            btnInicio.TextAlign = ContentAlignment.BottomCenter;
            btnInicio.TextImageRelation = TextImageRelation.ImageAboveText;
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click_1;
            // 
            // btnPdf
            // 
            btnPdf.BackColor = Color.White;
            btnPdf.FlatStyle = FlatStyle.Popup;
            btnPdf.Font = new Font("Segoe UI", 18F);
            btnPdf.Image = Properties.Resources.Examenes2;
            btnPdf.Location = new Point(66, 305);
            btnPdf.Name = "btnPdf";
            btnPdf.Size = new Size(275, 130);
            btnPdf.TabIndex = 3;
            btnPdf.Text = "Exportar";
            btnPdf.TextAlign = ContentAlignment.BottomCenter;
            btnPdf.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPdf.UseVisualStyleBackColor = false;
            btnPdf.Click += btnPdf_Click;
            // 
            // dtgExamenes
            // 
            dtgExamenes.BackgroundColor = Color.FromArgb(33, 63, 97);
            dtgExamenes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgExamenes.Location = new Point(391, 27);
            dtgExamenes.Name = "dtgExamenes";
            dtgExamenes.Size = new Size(539, 487);
            dtgExamenes.TabIndex = 4;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.BackColor = Color.LightGray;
            btnMinimizar.FlatAppearance.BorderColor = Color.White;
            btnMinimizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnMinimizar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMinimizar.Location = new Point(956, 36);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(50, 24);
            btnMinimizar.TabIndex = 12;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.LightGray;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button1.Location = new Point(1015, 36);
            button1.Name = "button1";
            button1.Size = new Size(43, 24);
            button1.TabIndex = 11;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // examenes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 63, 97);
            ClientSize = new Size(1070, 526);
            Controls.Add(btnMinimizar);
            Controls.Add(button1);
            Controls.Add(dtgExamenes);
            Controls.Add(btnPdf);
            Controls.Add(btnInicio);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "examenes";
            Text = "E";
            FormClosing += examenes_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgExamenes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem examenesToolStripMenuItem;
        private ToolStripMenuItem materiasToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private Button btnInicio;
        private Button btnPdf;
        private DataGridView dtgExamenes;
        private Button btnMinimizar;
        private Button button1;
    }
}