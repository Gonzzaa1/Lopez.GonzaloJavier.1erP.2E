namespace Pantallas
{
    partial class FrmProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gbBuscarProducto = new System.Windows.Forms.GroupBox();
            this.rtbProducto = new System.Windows.Forms.RichTextBox();
            this.pnlProducto = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.pnlMarca = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.pnlCategoria = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pnlBotonera = new System.Windows.Forms.Panel();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.cbBuscarProducto = new System.Windows.Forms.ComboBox();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlStockInfo = new System.Windows.Forms.Panel();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.cbMarcaProducto = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStockProducto = new System.Windows.Forms.TextBox();
            this.cbCargaCategoria = new System.Windows.Forms.ComboBox();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.pnlLista = new System.Windows.Forms.Panel();
            this.pnlTitle.SuspendLayout();
            this.gbBuscarProducto.SuspendLayout();
            this.pnlProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlMarca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlBotonera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.pnlStockInfo.SuspendLayout();
            this.pnlDatos.SuspendLayout();
            this.pnlLista.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.label1);
            this.pnlTitle.Controls.Add(this.button1);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1100, 122);
            this.pnlTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(429, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "PRODUCTOS";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Pantallas.Properties.Resources.deshacer;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(17, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(156, 82);
            this.button1.TabIndex = 0;
            this.button1.Text = "VOLVER";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbBuscarProducto
            // 
            this.gbBuscarProducto.Controls.Add(this.rtbProducto);
            this.gbBuscarProducto.Controls.Add(this.pnlProducto);
            this.gbBuscarProducto.Controls.Add(this.pnlMarca);
            this.gbBuscarProducto.Controls.Add(this.pnlCategoria);
            this.gbBuscarProducto.Controls.Add(this.btnBuscar);
            this.gbBuscarProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbBuscarProducto.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbBuscarProducto.Location = new System.Drawing.Point(0, 122);
            this.gbBuscarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.gbBuscarProducto.Name = "gbBuscarProducto";
            this.gbBuscarProducto.Padding = new System.Windows.Forms.Padding(4);
            this.gbBuscarProducto.Size = new System.Drawing.Size(1100, 360);
            this.gbBuscarProducto.TabIndex = 1;
            this.gbBuscarProducto.TabStop = false;
            // 
            // rtbProducto
            // 
            this.rtbProducto.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbProducto.Location = new System.Drawing.Point(604, 30);
            this.rtbProducto.Name = "rtbProducto";
            this.rtbProducto.Size = new System.Drawing.Size(473, 307);
            this.rtbProducto.TabIndex = 7;
            this.rtbProducto.Text = "";
            // 
            // pnlProducto
            // 
            this.pnlProducto.Controls.Add(this.pictureBox3);
            this.pnlProducto.Controls.Add(this.label4);
            this.pnlProducto.Controls.Add(this.cbProducto);
            this.pnlProducto.Location = new System.Drawing.Point(17, 242);
            this.pnlProducto.Name = "pnlProducto";
            this.pnlProducto.Size = new System.Drawing.Size(410, 100);
            this.pnlProducto.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Pantallas.Properties.Resources.flecha_derecha;
            this.pictureBox3.Location = new System.Drawing.Point(21, 48);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 37);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "SELECCIONE PRODUCTO";
            // 
            // cbProducto
            // 
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(84, 55);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(295, 30);
            this.cbProducto.TabIndex = 0;
            // 
            // pnlMarca
            // 
            this.pnlMarca.Controls.Add(this.label3);
            this.pnlMarca.Controls.Add(this.pictureBox2);
            this.pnlMarca.Controls.Add(this.cbMarca);
            this.pnlMarca.Location = new System.Drawing.Point(17, 136);
            this.pnlMarca.Name = "pnlMarca";
            this.pnlMarca.Size = new System.Drawing.Size(410, 100);
            this.pnlMarca.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "SELECCIONE MARCA";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Pantallas.Properties.Resources.flecha_derecha;
            this.pictureBox2.Location = new System.Drawing.Point(22, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 37);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // cbMarca
            // 
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(85, 54);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(295, 30);
            this.cbMarca.TabIndex = 0;
            this.cbMarca.TextChanged += new System.EventHandler(this.cbMarca_TextChanged);
            // 
            // pnlCategoria
            // 
            this.pnlCategoria.Controls.Add(this.label2);
            this.pnlCategoria.Controls.Add(this.cbCategoria);
            this.pnlCategoria.Controls.Add(this.pictureBox1);
            this.pnlCategoria.Location = new System.Drawing.Point(17, 30);
            this.pnlCategoria.Name = "pnlCategoria";
            this.pnlCategoria.Size = new System.Drawing.Size(410, 100);
            this.pnlCategoria.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "SELECCIONE CATEGORIA";
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(85, 57);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(295, 30);
            this.cbCategoria.TabIndex = 0;
            this.cbCategoria.TextChanged += new System.EventHandler(this.cbCategoria_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pantallas.Properties.Resources.flecha_derecha;
            this.pictureBox1.Location = new System.Drawing.Point(22, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 37);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = global::Pantallas.Properties.Resources.busqueda;
            this.btnBuscar.Location = new System.Drawing.Point(454, 297);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(40, 40);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pnlBotonera
            // 
            this.pnlBotonera.Controls.Add(this.btnBuscarProducto);
            this.pnlBotonera.Controls.Add(this.cbBuscarProducto);
            this.pnlBotonera.Controls.Add(this.btnEliminarProducto);
            this.pnlBotonera.Controls.Add(this.btnAgregarProducto);
            this.pnlBotonera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotonera.Location = new System.Drawing.Point(0, 482);
            this.pnlBotonera.Name = "pnlBotonera";
            this.pnlBotonera.Size = new System.Drawing.Size(1100, 76);
            this.pnlBotonera.TabIndex = 2;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.Image = global::Pantallas.Properties.Resources.busqueda;
            this.btnBuscarProducto.Location = new System.Drawing.Point(1002, 16);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(75, 45);
            this.btnBuscarProducto.TabIndex = 3;
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // cbBuscarProducto
            // 
            this.cbBuscarProducto.FormattingEnabled = true;
            this.cbBuscarProducto.Location = new System.Drawing.Point(604, 24);
            this.cbBuscarProducto.Name = "cbBuscarProducto";
            this.cbBuscarProducto.Size = new System.Drawing.Size(364, 30);
            this.cbBuscarProducto.TabIndex = 2;
            this.cbBuscarProducto.TextChanged += new System.EventHandler(this.cbBuscarProducto_TextChanged);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProducto.Image = global::Pantallas.Properties.Resources.eliminar_documento;
            this.btnEliminarProducto.Location = new System.Drawing.Point(102, 16);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(75, 45);
            this.btnEliminarProducto.TabIndex = 1;
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Visible = false;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Image = global::Pantallas.Properties.Resources.agregar_documento;
            this.btnAgregarProducto.Location = new System.Drawing.Point(17, 16);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(75, 45);
            this.btnAgregarProducto.TabIndex = 0;
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductos.Location = new System.Drawing.Point(0, 0);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos.RowTemplate.Height = 25;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(1100, 60);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(371, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "*DOBLE CLICK EN EL PRODUCTO PARA SOLICITAR MAS STOCK";
            // 
            // pnlStockInfo
            // 
            this.pnlStockInfo.Controls.Add(this.label5);
            this.pnlStockInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStockInfo.Location = new System.Drawing.Point(0, 833);
            this.pnlStockInfo.Name = "pnlStockInfo";
            this.pnlStockInfo.Size = new System.Drawing.Size(1100, 31);
            this.pnlStockInfo.TabIndex = 3;
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.cbMarcaProducto);
            this.pnlDatos.Controls.Add(this.btnCancelar);
            this.pnlDatos.Controls.Add(this.btnAceptar);
            this.pnlDatos.Controls.Add(this.label10);
            this.pnlDatos.Controls.Add(this.label9);
            this.pnlDatos.Controls.Add(this.label8);
            this.pnlDatos.Controls.Add(this.label7);
            this.pnlDatos.Controls.Add(this.label6);
            this.pnlDatos.Controls.Add(this.txtStockProducto);
            this.pnlDatos.Controls.Add(this.cbCargaCategoria);
            this.pnlDatos.Controls.Add(this.txtPrecioProducto);
            this.pnlDatos.Controls.Add(this.txtNombreProducto);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDatos.Location = new System.Drawing.Point(0, 558);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(1100, 215);
            this.pnlDatos.TabIndex = 4;
            // 
            // cbMarcaProducto
            // 
            this.cbMarcaProducto.FormattingEnabled = true;
            this.cbMarcaProducto.Location = new System.Drawing.Point(185, 138);
            this.cbMarcaProducto.Name = "cbMarcaProducto";
            this.cbMarcaProducto.Size = new System.Drawing.Size(394, 30);
            this.cbMarcaProducto.TabIndex = 9;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = global::Pantallas.Properties.Resources.circulo_cruzado;
            this.btnCancelar.Location = new System.Drawing.Point(873, 146);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 45);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Image = global::Pantallas.Properties.Resources.caja;
            this.btnAceptar.Location = new System.Drawing.Point(760, 146);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 45);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(680, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 22);
            this.label10.TabIndex = 7;
            this.label10.Text = "STOCK";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(70, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 22);
            this.label9.TabIndex = 7;
            this.label9.Text = "CATEGORIA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(670, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "PRECIO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(95, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 22);
            this.label7.TabIndex = 7;
            this.label7.Text = "MARCA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "NOMBRE";
            // 
            // txtStockProducto
            // 
            this.txtStockProducto.Location = new System.Drawing.Point(761, 89);
            this.txtStockProducto.Name = "txtStockProducto";
            this.txtStockProducto.Size = new System.Drawing.Size(187, 30);
            this.txtStockProducto.TabIndex = 4;
            // 
            // cbCargaCategoria
            // 
            this.cbCargaCategoria.FormattingEnabled = true;
            this.cbCargaCategoria.Location = new System.Drawing.Point(185, 37);
            this.cbCargaCategoria.Name = "cbCargaCategoria";
            this.cbCargaCategoria.Size = new System.Drawing.Size(394, 30);
            this.cbCargaCategoria.TabIndex = 3;
            this.cbCargaCategoria.TextChanged += new System.EventHandler(this.cbCargaCategoria_TextChanged);
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(760, 37);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(188, 30);
            this.txtPrecioProducto.TabIndex = 2;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(185, 89);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(394, 30);
            this.txtNombreProducto.TabIndex = 0;
            // 
            // pnlLista
            // 
            this.pnlLista.Controls.Add(this.dgvProductos);
            this.pnlLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLista.Location = new System.Drawing.Point(0, 773);
            this.pnlLista.Name = "pnlLista";
            this.pnlLista.Size = new System.Drawing.Size(1100, 60);
            this.pnlLista.TabIndex = 5;
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1100, 864);
            this.Controls.Add(this.pnlLista);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.pnlStockInfo);
            this.Controls.Add(this.pnlBotonera);
            this.Controls.Add(this.gbBuscarProducto);
            this.Controls.Add(this.pnlTitle);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmProducto";
            this.Text = "FrmProducto";
            this.Load += new System.EventHandler(this.FrmProducto_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.gbBuscarProducto.ResumeLayout(false);
            this.pnlProducto.ResumeLayout(false);
            this.pnlProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlMarca.ResumeLayout(false);
            this.pnlMarca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlCategoria.ResumeLayout(false);
            this.pnlCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlBotonera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.pnlStockInfo.ResumeLayout(false);
            this.pnlStockInfo.PerformLayout();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.pnlLista.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlTitle;
        private Button button1;
        private Label label1;
        private GroupBox gbBuscarProducto;
        private Panel pnlProducto;
        private PictureBox pictureBox3;
        private Label label4;
        private ComboBox cbProducto;
        private Panel pnlMarca;
        private Label label3;
        private PictureBox pictureBox2;
        private ComboBox cbMarca;
        private Panel pnlCategoria;
        private Label label2;
        private ComboBox cbCategoria;
        private PictureBox pictureBox1;
        private Button btnBuscar;
        private Panel pnlBotonera;
        private Label label5;
        private DataGridView dgvProductos;
        private Panel pnlStockInfo;
        private Panel pnlDatos;
        private Button btnEliminarProducto;
        private Button btnAgregarProducto;
        private RichTextBox rtbProducto;
        private Button btnBuscarProducto;
        private ComboBox cbBuscarProducto;
        private Panel pnlLista;
        private TextBox txtStockProducto;
        private ComboBox cbCargaCategoria;
        private TextBox txtPrecioProducto;
        private TextBox txtNombreProducto;
        private Button btnCancelar;
        private Button btnAceptar;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private ComboBox cbMarcaProducto;
    }
}