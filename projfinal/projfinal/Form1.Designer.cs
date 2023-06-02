namespace projfinal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mostar = new System.Windows.Forms.CheckBox();
            this.Registrarse = new System.Windows.Forms.Button();
            this.noregistro = new System.Windows.Forms.Label();
            this.ingresar = new System.Windows.Forms.Button();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.cerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 31);
            this.panel1.TabIndex = 0;
            // 
            // cerrar
            // 
            this.cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar.Image = global::projfinal.Properties.Resources.ceraar_2;
            this.cerrar.Location = new System.Drawing.Point(223, 3);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(28, 24);
            this.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cerrar.TabIndex = 1;
            this.cerrar.TabStop = false;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(22, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 326);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PowderBlue;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.mostar);
            this.panel3.Controls.Add(this.Registrarse);
            this.panel3.Controls.Add(this.noregistro);
            this.panel3.Controls.Add(this.ingresar);
            this.panel3.Controls.Add(this.contraseña);
            this.panel3.Controls.Add(this.usuario);
            this.panel3.Location = new System.Drawing.Point(15, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(177, 294);
            this.panel3.TabIndex = 0;
            // 
            // mostar
            // 
            this.mostar.AutoSize = true;
            this.mostar.Font = new System.Drawing.Font("Yellowtail", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostar.Location = new System.Drawing.Point(114, 132);
            this.mostar.Name = "mostar";
            this.mostar.Size = new System.Drawing.Size(51, 18);
            this.mostar.TabIndex = 7;
            this.mostar.Text = "mostar";
            this.mostar.UseVisualStyleBackColor = true;
            this.mostar.CheckedChanged += new System.EventHandler(this.mostar_CheckedChanged);
            // 
            // Registrarse
            // 
            this.Registrarse.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Registrarse.FlatAppearance.BorderSize = 0;
            this.Registrarse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Registrarse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Registrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registrarse.Font = new System.Drawing.Font("Yellowtail", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrarse.Location = new System.Drawing.Point(59, 236);
            this.Registrarse.Name = "Registrarse";
            this.Registrarse.Size = new System.Drawing.Size(58, 24);
            this.Registrarse.TabIndex = 6;
            this.Registrarse.Text = "Registrarse";
            this.Registrarse.UseVisualStyleBackColor = false;
            this.Registrarse.Click += new System.EventHandler(this.Registrarse_Click);
            // 
            // noregistro
            // 
            this.noregistro.AutoSize = true;
            this.noregistro.Font = new System.Drawing.Font("Yellowtail", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noregistro.Location = new System.Drawing.Point(45, 219);
            this.noregistro.Name = "noregistro";
            this.noregistro.Size = new System.Drawing.Size(88, 14);
            this.noregistro.TabIndex = 5;
            this.noregistro.Text = "¿No esta Registrado?";
            // 
            // ingresar
            // 
            this.ingresar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ingresar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.ingresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ingresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ingresar.Font = new System.Drawing.Font("Yellowtail", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresar.Location = new System.Drawing.Point(48, 161);
            this.ingresar.Name = "ingresar";
            this.ingresar.Size = new System.Drawing.Size(85, 31);
            this.ingresar.TabIndex = 4;
            this.ingresar.Text = "Ingresar";
            this.ingresar.UseVisualStyleBackColor = false;
            this.ingresar.Click += new System.EventHandler(this.ingresar_Click);
            // 
            // contraseña
            // 
            this.contraseña.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contraseña.Font = new System.Drawing.Font("Yellowtail", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseña.Location = new System.Drawing.Point(12, 104);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(153, 22);
            this.contraseña.TabIndex = 3;
            this.contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.contraseña.Enter += new System.EventHandler(this.contraseña_Enter);
            this.contraseña.Leave += new System.EventHandler(this.contraseña_Leave);
            // 
            // usuario
            // 
            this.usuario.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usuario.Font = new System.Drawing.Font("Yellowtail", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.Location = new System.Drawing.Point(12, 47);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(153, 22);
            this.usuario.TabIndex = 2;
            this.usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.usuario.Enter += new System.EventHandler(this.usuario_Enter);
            this.usuario.Leave += new System.EventHandler(this.usuario_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yellowtail", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ingrese Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yellowtail", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ingrese Contraseña";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(253, 399);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox cerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Button ingresar;
        private System.Windows.Forms.Label noregistro;
        private System.Windows.Forms.Button Registrarse;
        private System.Windows.Forms.CheckBox mostar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

