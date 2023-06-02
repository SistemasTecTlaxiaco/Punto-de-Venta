namespace projfinal
{
    partial class Registro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cerrar2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.guardar = new System.Windows.Forms.Button();
            this.contraseña2 = new System.Windows.Forms.TextBox();
            this.usuario2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.cerrar2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 32);
            this.panel1.TabIndex = 0;
            // 
            // cerrar2
            // 
            this.cerrar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar2.Image = global::projfinal.Properties.Resources.ceraar_2;
            this.cerrar2.Location = new System.Drawing.Point(222, 5);
            this.cerrar2.Name = "cerrar2";
            this.cerrar2.Size = new System.Drawing.Size(28, 24);
            this.cerrar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cerrar2.TabIndex = 2;
            this.cerrar2.TabStop = false;
            this.cerrar2.Click += new System.EventHandler(this.cerrar2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(22, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 329);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PowderBlue;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.guardar);
            this.panel3.Controls.Add(this.contraseña2);
            this.panel3.Controls.Add(this.usuario2);
            this.panel3.Location = new System.Drawing.Point(16, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(175, 297);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yellowtail", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "REGISTRO";
            // 
            // guardar
            // 
            this.guardar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.guardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.guardar.FlatAppearance.BorderSize = 0;
            this.guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardar.Font = new System.Drawing.Font("Yellowtail", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar.Location = new System.Drawing.Point(50, 208);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(85, 31);
            this.guardar.TabIndex = 8;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = false;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // contraseña2
            // 
            this.contraseña2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.contraseña2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contraseña2.Font = new System.Drawing.Font("Yellowtail", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseña2.Location = new System.Drawing.Point(12, 148);
            this.contraseña2.Name = "contraseña2";
            this.contraseña2.Size = new System.Drawing.Size(153, 22);
            this.contraseña2.TabIndex = 7;
            this.contraseña2.Text = "Ingrese Contraseña";
            this.contraseña2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // usuario2
            // 
            this.usuario2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.usuario2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usuario2.Font = new System.Drawing.Font("Yellowtail", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario2.Location = new System.Drawing.Point(12, 82);
            this.usuario2.Name = "usuario2";
            this.usuario2.Size = new System.Drawing.Size(153, 22);
            this.usuario2.TabIndex = 6;
            this.usuario2.Text = "Ingrese Usuario";
            this.usuario2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(253, 400);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cerrar2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox cerrar2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.TextBox contraseña2;
        private System.Windows.Forms.TextBox usuario2;
        private System.Windows.Forms.Label label2;
    }
}