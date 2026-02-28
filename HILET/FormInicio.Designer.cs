using HILET.Properties;

namespace HILET
{
    partial class FormInicio
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
            mAteriaToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            ajustesToolStripMenuItem = new ToolStripMenuItem();
            btnExamenes = new Button();
            btnMaterias = new Button();
            btnSalir = new Button();
            lblFecha = new Label();
            lblHora = new Label();
            btnMinimizar = new Button();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, ajustesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1070, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { examenesToolStripMenuItem, mAteriaToolStripMenuItem, salirToolStripMenuItem });
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(48, 20);
            inicioToolStripMenuItem.Text = "Inicio";
            // 
            // examenesToolStripMenuItem
            // 
            examenesToolStripMenuItem.Name = "examenesToolStripMenuItem";
            examenesToolStripMenuItem.Size = new Size(127, 22);
            examenesToolStripMenuItem.Text = "Examenes";
            // 
            // mAteriaToolStripMenuItem
            // 
            mAteriaToolStripMenuItem.Name = "mAteriaToolStripMenuItem";
            mAteriaToolStripMenuItem.Size = new Size(127, 22);
            mAteriaToolStripMenuItem.Text = "M aterias";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(127, 22);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // ajustesToolStripMenuItem
            // 
            ajustesToolStripMenuItem.Name = "ajustesToolStripMenuItem";
            ajustesToolStripMenuItem.Size = new Size(57, 20);
            ajustesToolStripMenuItem.Text = "Ajustes";
            ajustesToolStripMenuItem.Click += ajustesToolStripMenuItem_Click;
            // 
            // btnExamenes
            // 
            btnExamenes.BackColor = Color.White;
            btnExamenes.FlatStyle = FlatStyle.Popup;
            btnExamenes.Font = new Font("Segoe UI", 18F);
            btnExamenes.Image = Resources.Examenes2;
            btnExamenes.Location = new Point(60, 211);
            btnExamenes.Name = "btnExamenes";
            btnExamenes.Size = new Size(275, 130);
            btnExamenes.TabIndex = 1;
            btnExamenes.Text = "Examenes";
            btnExamenes.TextAlign = ContentAlignment.BottomCenter;
            btnExamenes.TextImageRelation = TextImageRelation.ImageAboveText;
            btnExamenes.UseVisualStyleBackColor = false;
            btnExamenes.Click += btnExamenes_Click_1;
            // 
            // btnMaterias
            // 
            btnMaterias.BackColor = Color.White;
            btnMaterias.FlatStyle = FlatStyle.Popup;
            btnMaterias.Font = new Font("Segoe UI", 18F);
            btnMaterias.Image = Resources.Materia1;
            btnMaterias.Location = new Point(392, 211);
            btnMaterias.Name = "btnMaterias";
            btnMaterias.Size = new Size(275, 130);
            btnMaterias.TabIndex = 3;
            btnMaterias.Text = "Materias";
            btnMaterias.TextAlign = ContentAlignment.BottomCenter;
            btnMaterias.TextImageRelation = TextImageRelation.ImageAboveText;
            btnMaterias.UseVisualStyleBackColor = false;
            btnMaterias.Click += btnMaterias_Click_1;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.White;
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.Font = new Font("Segoe UI", 18F);
            btnSalir.Image = Resources.cerrar_sesion;
            btnSalir.Location = new Point(721, 211);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(275, 130);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.TextAlign = ContentAlignment.BottomCenter;
            btnSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 20F);
            lblFecha.ForeColor = Color.White;
            lblFecha.Location = new Point(444, 70);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(80, 37);
            lblFecha.TabIndex = 7;
            lblFecha.Text = "fecha";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI", 20F);
            lblHora.ForeColor = Color.White;
            lblHora.Location = new Point(444, 117);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(71, 37);
            lblHora.TabIndex = 8;
            lblHora.Text = "hora";
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.BackColor = Color.LightGray;
            btnMinimizar.FlatAppearance.BorderColor = Color.White;
            btnMinimizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnMinimizar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMinimizar.Location = new Point(956, 39);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(50, 24);
            btnMinimizar.TabIndex = 10;
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
            button1.Location = new Point(1015, 39);
            button1.Name = "button1";
            button1.Size = new Size(43, 24);
            button1.TabIndex = 9;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 63, 97);
            ClientSize = new Size(1070, 526);
            Controls.Add(btnMinimizar);
            Controls.Add(button1);
            Controls.Add(lblHora);
            Controls.Add(lblFecha);
            Controls.Add(btnSalir);
            Controls.Add(btnMaterias);
            Controls.Add(btnExamenes);
            Controls.Add(menuStrip1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MaximumSize = new Size(1086, 565);
            MinimizeBox = false;
            MinimumSize = new Size(1086, 565);
            Name = "FormInicio";
            ShowIcon = false;
            Text = "Inicio";
            FormClosing += FormInicio_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private Button btnExamenes;
        private Button btnMaterias;
        private Button btnSalir;
        private Label lblFecha;
        private Label lblHora;
        private ToolStripMenuItem examenesToolStripMenuItem;
        private ToolStripMenuItem mAteriaToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem ajustesToolStripMenuItem;
        private Button btnMinimizar;
        private Button button1;
    }
}