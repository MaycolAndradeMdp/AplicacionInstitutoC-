namespace HILET
{
    partial class frmConfirmacion
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
            label1 = new Label();
            btnAcceder = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 BlkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 28);
            label1.Name = "label1";
            label1.Size = new Size(263, 19);
            label1.TabIndex = 0;
            label1.Text = "Confirme para seguir con la operaciòn";
            // 
            // btnAcceder
            // 
            btnAcceder.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            btnAcceder.FlatStyle = FlatStyle.Flat;
            btnAcceder.Image = Properties.Resources.Aceptar;
            btnAcceder.ImageAlign = ContentAlignment.MiddleLeft;
            btnAcceder.Location = new Point(12, 67);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(147, 37);
            btnAcceder.TabIndex = 1;
            btnAcceder.Text = "ACEPTAR";
            btnAcceder.UseVisualStyleBackColor = true;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.MouseOverBackColor = Color.Maroon;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.Cancelar;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(198, 67);
            button1.Name = "button1";
            button1.Size = new Size(149, 37);
            button1.TabIndex = 2;
            button1.Text = "CANCELAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmConfirmacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 116);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(btnAcceder);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(375, 155);
            MinimizeBox = false;
            MinimumSize = new Size(375, 155);
            Name = "frmConfirmacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Confirmaciòn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAcceder;
        private Button button1;
    }
}