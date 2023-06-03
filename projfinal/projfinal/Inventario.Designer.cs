namespace projfinal
{
    partial class Inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btregreso = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbimagen = new System.Windows.Forms.Label();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.Folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textbuscar = new System.Windows.Forms.TextBox();
            this.lbbuscar = new System.Windows.Forms.Label();
            this.btlimpiar = new System.Windows.Forms.Button();
            this.bteliminar = new System.Windows.Forms.Button();
            this.lbproductos = new System.Windows.Forms.Label();
            this.btmodificar = new System.Windows.Forms.Button();
            this.btagragar = new System.Windows.Forms.Button();
            this.textcantidad = new System.Windows.Forms.TextBox();
            this.textprecio = new System.Windows.Forms.TextBox();
            this.textnombre = new System.Windows.Forms.TextBox();
            this.textid = new System.Windows.Forms.TextBox();
            this.lbcantidad = new System.Windows.Forms.Label();
            this.lbprecio = new System.Windows.Forms.Label();
            this.lbnombre = new System.Windows.Forms.Label();
            this.lbid = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.bteliP = new System.Windows.Forms.Button();
            this.tpagar = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.textefectivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btpagar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btagragarproducto = new System.Windows.Forms.Button();
            this.textcambio = new System.Windows.Forms.TextBox();
            this.nudcantidadp = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudcantidadp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.btregreso);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1274, 32);
            this.panel1.TabIndex = 0;
            // 
            // btregreso
            // 
            this.btregreso.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btregreso.FlatAppearance.BorderSize = 0;
            this.btregreso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btregreso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btregreso.Font = new System.Drawing.Font("Yellowtail", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btregreso.Location = new System.Drawing.Point(1196, 0);
            this.btregreso.Name = "btregreso";
            this.btregreso.Size = new System.Drawing.Size(75, 26);
            this.btregreso.TabIndex = 23;
            this.btregreso.Text = "Regresar";
            this.btregreso.UseVisualStyleBackColor = true;
            this.btregreso.Click += new System.EventHandler(this.btregreso_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(9, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 407);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PowderBlue;
            this.panel3.Controls.Add(this.lbimagen);
            this.panel3.Controls.Add(this.pnlImage);
            this.panel3.Controls.Add(this.dgvProductos);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.btlimpiar);
            this.panel3.Controls.Add(this.bteliminar);
            this.panel3.Controls.Add(this.lbproductos);
            this.panel3.Controls.Add(this.btmodificar);
            this.panel3.Controls.Add(this.btagragar);
            this.panel3.Controls.Add(this.textcantidad);
            this.panel3.Controls.Add(this.textprecio);
            this.panel3.Controls.Add(this.textnombre);
            this.panel3.Controls.Add(this.textid);
            this.panel3.Controls.Add(this.lbcantidad);
            this.panel3.Controls.Add(this.lbprecio);
            this.panel3.Controls.Add(this.lbnombre);
            this.panel3.Controls.Add(this.lbid);
            this.panel3.Location = new System.Drawing.Point(12, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(607, 383);
            this.panel3.TabIndex = 0;
            // 
            // lbimagen
            // 
            this.lbimagen.AutoSize = true;
            this.lbimagen.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbimagen.Font = new System.Drawing.Font("Yellowtail", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbimagen.ForeColor = System.Drawing.Color.Magenta;
            this.lbimagen.Location = new System.Drawing.Point(377, 111);
            this.lbimagen.Name = "lbimagen";
            this.lbimagen.Size = new System.Drawing.Size(54, 17);
            this.lbimagen.TabIndex = 22;
            this.lbimagen.Text = "IMAGEN";
            // 
            // pnlImage
            // 
            this.pnlImage.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlImage.Controls.Add(this.pbImage);
            this.pnlImage.Location = new System.Drawing.Point(454, 52);
            this.pnlImage.Margin = new System.Windows.Forms.Padding(2);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(139, 125);
            this.pnlImage.TabIndex = 21;
            // 
            // pbImage
            // 
            this.pbImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbImage.Image = ((System.Drawing.Image)(resources.GetObject("pbImage.Image")));
            this.pbImage.Location = new System.Drawing.Point(10, 12);
            this.pbImage.Margin = new System.Windows.Forms.Padding(2);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(118, 105);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            this.pbImage.Click += new System.EventHandler(this.pbImage_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToOrderColumns = true;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Folio,
            this.Nombre,
            this.Precio,
            this.Cantidad,
            this.Imagen});
            this.dgvProductos.Location = new System.Drawing.Point(13, 229);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(580, 137);
            this.dgvProductos.TabIndex = 20;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // Folio
            // 
            this.Folio.HeaderText = "Folio";
            this.Folio.MinimumWidth = 6;
            this.Folio.Name = "Folio";
            this.Folio.ReadOnly = true;
            this.Folio.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Imagen
            // 
            this.Imagen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Imagen.MinimumWidth = 6;
            this.Imagen.Name = "Imagen";
            this.Imagen.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Controls.Add(this.textbuscar);
            this.panel4.Controls.Add(this.lbbuscar);
            this.panel4.Location = new System.Drawing.Point(248, 183);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(345, 38);
            this.panel4.TabIndex = 19;
            // 
            // textbuscar
            // 
            this.textbuscar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textbuscar.Font = new System.Drawing.Font("Yellowtail", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbuscar.Location = new System.Drawing.Point(142, 6);
            this.textbuscar.Name = "textbuscar";
            this.textbuscar.Size = new System.Drawing.Size(188, 25);
            this.textbuscar.TabIndex = 22;
            this.textbuscar.TextChanged += new System.EventHandler(this.textbuscar_TextChanged);
            // 
            // lbbuscar
            // 
            this.lbbuscar.AutoSize = true;
            this.lbbuscar.Font = new System.Drawing.Font("Yellowtail", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbuscar.ForeColor = System.Drawing.Color.Magenta;
            this.lbbuscar.Location = new System.Drawing.Point(6, 10);
            this.lbbuscar.Name = "lbbuscar";
            this.lbbuscar.Size = new System.Drawing.Size(133, 17);
            this.lbbuscar.TabIndex = 21;
            this.lbbuscar.Text = "BUSCAR PRODUCTO";
            // 
            // btlimpiar
            // 
            this.btlimpiar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btlimpiar.FlatAppearance.BorderSize = 0;
            this.btlimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btlimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btlimpiar.Font = new System.Drawing.Font("Yellowtail", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlimpiar.Location = new System.Drawing.Point(110, 198);
            this.btlimpiar.Name = "btlimpiar";
            this.btlimpiar.Size = new System.Drawing.Size(107, 26);
            this.btlimpiar.TabIndex = 18;
            this.btlimpiar.Text = "Limpiar Campos";
            this.btlimpiar.UseVisualStyleBackColor = true;
            this.btlimpiar.Click += new System.EventHandler(this.btlimpiar_Click);
            // 
            // bteliminar
            // 
            this.bteliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.bteliminar.FlatAppearance.BorderSize = 0;
            this.bteliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.bteliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.bteliminar.Font = new System.Drawing.Font("Yellowtail", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteliminar.Location = new System.Drawing.Point(240, 151);
            this.bteliminar.Name = "bteliminar";
            this.bteliminar.Size = new System.Drawing.Size(75, 26);
            this.bteliminar.TabIndex = 17;
            this.bteliminar.Text = "Eliminar";
            this.bteliminar.UseVisualStyleBackColor = true;
            this.bteliminar.Click += new System.EventHandler(this.bteliminar_Click);
            // 
            // lbproductos
            // 
            this.lbproductos.AutoSize = true;
            this.lbproductos.Font = new System.Drawing.Font("Yellowtail", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbproductos.Location = new System.Drawing.Point(6, 9);
            this.lbproductos.Name = "lbproductos";
            this.lbproductos.Size = new System.Drawing.Size(347, 41);
            this.lbproductos.TabIndex = 16;
            this.lbproductos.Text = "ALTA DE PRODUCTOS";
            // 
            // btmodificar
            // 
            this.btmodificar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btmodificar.FlatAppearance.BorderSize = 0;
            this.btmodificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btmodificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btmodificar.Font = new System.Drawing.Font("Yellowtail", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmodificar.Location = new System.Drawing.Point(240, 119);
            this.btmodificar.Name = "btmodificar";
            this.btmodificar.Size = new System.Drawing.Size(75, 26);
            this.btmodificar.TabIndex = 15;
            this.btmodificar.Text = "Modificar";
            this.btmodificar.UseVisualStyleBackColor = true;
            this.btmodificar.Click += new System.EventHandler(this.btmodificar_Click);
            // 
            // btagragar
            // 
            this.btagragar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btagragar.FlatAppearance.BorderSize = 0;
            this.btagragar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btagragar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btagragar.Font = new System.Drawing.Font("Yellowtail", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btagragar.Location = new System.Drawing.Point(240, 87);
            this.btagragar.Name = "btagragar";
            this.btagragar.Size = new System.Drawing.Size(75, 26);
            this.btagragar.TabIndex = 14;
            this.btagragar.Text = "Agregar";
            this.btagragar.UseVisualStyleBackColor = true;
            this.btagragar.Click += new System.EventHandler(this.btagragar_Click);
            // 
            // textcantidad
            // 
            this.textcantidad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textcantidad.Font = new System.Drawing.Font("Yellowtail", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcantidad.Location = new System.Drawing.Point(83, 167);
            this.textcantidad.Name = "textcantidad";
            this.textcantidad.Size = new System.Drawing.Size(151, 25);
            this.textcantidad.TabIndex = 12;
            // 
            // textprecio
            // 
            this.textprecio.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textprecio.Font = new System.Drawing.Font("Yellowtail", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textprecio.Location = new System.Drawing.Point(83, 135);
            this.textprecio.Name = "textprecio";
            this.textprecio.Size = new System.Drawing.Size(151, 25);
            this.textprecio.TabIndex = 11;
            // 
            // textnombre
            // 
            this.textnombre.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textnombre.Font = new System.Drawing.Font("Yellowtail", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnombre.Location = new System.Drawing.Point(83, 103);
            this.textnombre.Name = "textnombre";
            this.textnombre.Size = new System.Drawing.Size(151, 25);
            this.textnombre.TabIndex = 10;
            // 
            // textid
            // 
            this.textid.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textid.Font = new System.Drawing.Font("Yellowtail", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textid.Location = new System.Drawing.Point(83, 71);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(151, 25);
            this.textid.TabIndex = 9;
            // 
            // lbcantidad
            // 
            this.lbcantidad.AutoSize = true;
            this.lbcantidad.Font = new System.Drawing.Font("Yellowtail", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcantidad.ForeColor = System.Drawing.Color.Magenta;
            this.lbcantidad.Location = new System.Drawing.Point(10, 171);
            this.lbcantidad.Name = "lbcantidad";
            this.lbcantidad.Size = new System.Drawing.Size(70, 17);
            this.lbcantidad.TabIndex = 8;
            this.lbcantidad.Text = "CANTIDAD";
            // 
            // lbprecio
            // 
            this.lbprecio.AutoSize = true;
            this.lbprecio.Font = new System.Drawing.Font("Yellowtail", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprecio.ForeColor = System.Drawing.Color.Magenta;
            this.lbprecio.Location = new System.Drawing.Point(10, 139);
            this.lbprecio.Name = "lbprecio";
            this.lbprecio.Size = new System.Drawing.Size(54, 17);
            this.lbprecio.TabIndex = 7;
            this.lbprecio.Text = "PRECIO";
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSize = true;
            this.lbnombre.Font = new System.Drawing.Font("Yellowtail", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnombre.ForeColor = System.Drawing.Color.Magenta;
            this.lbnombre.Location = new System.Drawing.Point(10, 107);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(61, 17);
            this.lbnombre.TabIndex = 6;
            this.lbnombre.Text = "NOMBRE";
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Font = new System.Drawing.Font("Yellowtail", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbid.ForeColor = System.Drawing.Color.Magenta;
            this.lbid.Location = new System.Drawing.Point(10, 75);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(22, 17);
            this.lbid.TabIndex = 5;
            this.lbid.Text = "ID";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(647, 43);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(612, 407);
            this.panel5.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.PowderBlue;
            this.panel6.Controls.Add(this.bteliP);
            this.panel6.Controls.Add(this.tpagar);
            this.panel6.Controls.Add(this.dataGridView1);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.textefectivo);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.btpagar);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.btagragarproducto);
            this.panel6.Controls.Add(this.textcambio);
            this.panel6.Controls.Add(this.nudcantidadp);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(12, 13);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(579, 383);
            this.panel6.TabIndex = 0;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // bteliP
            // 
            this.bteliP.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.bteliP.FlatAppearance.BorderSize = 0;
            this.bteliP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.bteliP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.bteliP.Font = new System.Drawing.Font("Yellowtail", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteliP.Location = new System.Drawing.Point(434, 52);
            this.bteliP.Name = "bteliP";
            this.bteliP.Size = new System.Drawing.Size(121, 26);
            this.bteliP.TabIndex = 41;
            this.bteliP.Text = "Eliminar Producto";
            this.bteliP.UseVisualStyleBackColor = true;
            this.bteliP.Click += new System.EventHandler(this.bteliP_Click);
            // 
            // tpagar
            // 
            this.tpagar.AutoSize = true;
            this.tpagar.BackColor = System.Drawing.Color.White;
            this.tpagar.ForeColor = System.Drawing.Color.Black;
            this.tpagar.Location = new System.Drawing.Point(167, 347);
            this.tpagar.Name = "tpagar";
            this.tpagar.Size = new System.Drawing.Size(10, 13);
            this.tpagar.TabIndex = 40;
            this.tpagar.Text = "-";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(14, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(541, 183);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Folio";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "CantidadP";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "SubTotal";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Cntidad Producto";
            // 
            // textefectivo
            // 
            this.textefectivo.Location = new System.Drawing.Point(344, 311);
            this.textefectivo.Name = "textefectivo";
            this.textefectivo.Size = new System.Drawing.Size(120, 20);
            this.textefectivo.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Efectivo";
            // 
            // btpagar
            // 
            this.btpagar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btpagar.FlatAppearance.BorderSize = 0;
            this.btpagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btpagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btpagar.Font = new System.Drawing.Font("Yellowtail", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpagar.Location = new System.Drawing.Point(480, 324);
            this.btpagar.Name = "btpagar";
            this.btpagar.Size = new System.Drawing.Size(75, 26);
            this.btpagar.TabIndex = 35;
            this.btpagar.Text = "Pagar";
            this.btpagar.UseVisualStyleBackColor = true;
            this.btpagar.Click += new System.EventHandler(this.btpagar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Total Pagar $:";
            // 
            // btagragarproducto
            // 
            this.btagragarproducto.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btagragarproducto.FlatAppearance.BorderSize = 0;
            this.btagragarproducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btagragarproducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btagragarproducto.Font = new System.Drawing.Font("Yellowtail", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btagragarproducto.Location = new System.Drawing.Point(257, 45);
            this.btagragarproducto.Name = "btagragarproducto";
            this.btagragarproducto.Size = new System.Drawing.Size(138, 26);
            this.btagragarproducto.TabIndex = 31;
            this.btagragarproducto.Text = "Agregar Producto";
            this.btagragarproducto.UseVisualStyleBackColor = true;
            this.btagragarproducto.Click += new System.EventHandler(this.btagragarproducto_Click);
            // 
            // textcambio
            // 
            this.textcambio.Location = new System.Drawing.Point(344, 344);
            this.textcambio.Name = "textcambio";
            this.textcambio.Size = new System.Drawing.Size(120, 20);
            this.textcambio.TabIndex = 30;
            // 
            // nudcantidadp
            // 
            this.nudcantidadp.Location = new System.Drawing.Point(120, 50);
            this.nudcantidadp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudcantidadp.Name = "nudcantidadp";
            this.nudcantidadp.Size = new System.Drawing.Size(120, 20);
            this.nudcantidadp.TabIndex = 29;
            this.nudcantidadp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Cambio";
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1274, 461);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudcantidadp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbcantidad;
        private System.Windows.Forms.Label lbprecio;
        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.TextBox textcantidad;
        private System.Windows.Forms.TextBox textprecio;
        private System.Windows.Forms.TextBox textnombre;
        private System.Windows.Forms.Label lbproductos;
        private System.Windows.Forms.Button btmodificar;
        private System.Windows.Forms.Button btagragar;
        private System.Windows.Forms.Button btlimpiar;
        private System.Windows.Forms.Button bteliminar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textbuscar;
        private System.Windows.Forms.Label lbbuscar;
        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label lbimagen;
        private System.Windows.Forms.Button btregreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Folio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewImageColumn Imagen;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btpagar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btagragarproducto;
        private System.Windows.Forms.TextBox textcambio;
        private System.Windows.Forms.NumericUpDown nudcantidadp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textefectivo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tpagar;
        private System.Windows.Forms.Button bteliP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}