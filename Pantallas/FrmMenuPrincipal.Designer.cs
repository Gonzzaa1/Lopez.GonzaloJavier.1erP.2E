namespace Pantallas
{
    partial class FrmMenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.picMin = new System.Windows.Forms.PictureBox();
            this.picRest = new System.Windows.Forms.PictureBox();
            this.picMax = new System.Windows.Forms.PictureBox();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlBotonera = new System.Windows.Forms.Panel();
            this.btnAdministracion = new System.Windows.Forms.Button();
            this.pnlReportes = new System.Windows.Forms.Panel();
            this.btnRVentas = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.pnlClientes = new System.Windows.Forms.Panel();
            this.btnCGestionar = new System.Windows.Forms.Button();
            this.btnCBuscar = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.pnlProductos = new System.Windows.Forms.Panel();
            this.btnSolicitudStock = new System.Windows.Forms.Button();
            this.btnPConsultar = new System.Windows.Forms.Button();
            this.btnPBuscar = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.pnlVentas = new System.Windows.Forms.Panel();
            this.btnSolicitudes = new System.Windows.Forms.Button();
            this.btnVEstado = new System.Windows.Forms.Button();
            this.btnVPedido = new System.Windows.Forms.Button();
            this.btnVPresu = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.pnlInfoUser = new System.Windows.Forms.Panel();
            this.lblHoraLogo = new System.Windows.Forms.Label();
            this.pnlLine2 = new System.Windows.Forms.Panel();
            this.pnlLine1 = new System.Windows.Forms.Panel();
            this.txtRol = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblMain2 = new System.Windows.Forms.Label();
            this.lblMain1 = new System.Windows.Forms.Label();
            this.hora = new System.Windows.Forms.Timer(this.components);
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlBotonera.SuspendLayout();
            this.pnlReportes.SuspendLayout();
            this.pnlClientes.SuspendLayout();
            this.pnlProductos.SuspendLayout();
            this.pnlVentas.SuspendLayout();
            this.pnlInfoUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTitle.Controls.Add(this.picMin);
            this.pnlTitle.Controls.Add(this.picRest);
            this.pnlTitle.Controls.Add(this.picMax);
            this.pnlTitle.Controls.Add(this.picCerrar);
            this.pnlTitle.Controls.Add(this.pictureBox1);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1440, 36);
            this.pnlTitle.TabIndex = 0;
            this.pnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // picMin
            // 
            this.picMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMin.Image = global::Pantallas.Properties.Resources.menos;
            this.picMin.Location = new System.Drawing.Point(1300, 8);
            this.picMin.Name = "picMin";
            this.picMin.Size = new System.Drawing.Size(26, 21);
            this.picMin.TabIndex = 2;
            this.picMin.TabStop = false;
            this.picMin.Click += new System.EventHandler(this.picMin_Click);
            // 
            // picRest
            // 
            this.picRest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picRest.Image = global::Pantallas.Properties.Resources.cuadrado;
            this.picRest.Location = new System.Drawing.Point(1347, 8);
            this.picRest.Name = "picRest";
            this.picRest.Size = new System.Drawing.Size(32, 21);
            this.picRest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRest.TabIndex = 2;
            this.picRest.TabStop = false;
            this.picRest.Visible = false;
            this.picRest.Click += new System.EventHandler(this.picRest_Click);
            // 
            // picMax
            // 
            this.picMax.Image = global::Pantallas.Properties.Resources.expandir;
            this.picMax.Location = new System.Drawing.Point(1347, 8);
            this.picMax.Name = "picMax";
            this.picMax.Size = new System.Drawing.Size(32, 21);
            this.picMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMax.TabIndex = 2;
            this.picMax.TabStop = false;
            this.picMax.Click += new System.EventHandler(this.picMax_Click);
            // 
            // picCerrar
            // 
            this.picCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picCerrar.Image = global::Pantallas.Properties.Resources.cruz;
            this.picCerrar.Location = new System.Drawing.Point(1395, 7);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(32, 22);
            this.picCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCerrar.TabIndex = 2;
            this.picCerrar.TabStop = false;
            this.picCerrar.Click += new System.EventHandler(this.picCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Pantallas.Properties.Resources.Logo_Title_bar;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pnlBotonera
            // 
            this.pnlBotonera.AutoScroll = true;
            this.pnlBotonera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(204)))));
            this.pnlBotonera.Controls.Add(this.btnAdministracion);
            this.pnlBotonera.Controls.Add(this.pnlReportes);
            this.pnlBotonera.Controls.Add(this.btnReportes);
            this.pnlBotonera.Controls.Add(this.pnlClientes);
            this.pnlBotonera.Controls.Add(this.btnClientes);
            this.pnlBotonera.Controls.Add(this.pnlProductos);
            this.pnlBotonera.Controls.Add(this.btnProductos);
            this.pnlBotonera.Controls.Add(this.pnlVentas);
            this.pnlBotonera.Controls.Add(this.btnVentas);
            this.pnlBotonera.Controls.Add(this.btnCerrarSesion);
            this.pnlBotonera.Controls.Add(this.pnlInfoUser);
            this.pnlBotonera.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBotonera.Location = new System.Drawing.Point(0, 36);
            this.pnlBotonera.Name = "pnlBotonera";
            this.pnlBotonera.Size = new System.Drawing.Size(340, 864);
            this.pnlBotonera.TabIndex = 1;
            // 
            // btnAdministracion
            // 
            this.btnAdministracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdministracion.FlatAppearance.BorderSize = 0;
            this.btnAdministracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnAdministracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministracion.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdministracion.ForeColor = System.Drawing.Color.White;
            this.btnAdministracion.Image = global::Pantallas.Properties.Resources.ajustes;
            this.btnAdministracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministracion.Location = new System.Drawing.Point(0, 877);
            this.btnAdministracion.Name = "btnAdministracion";
            this.btnAdministracion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdministracion.Size = new System.Drawing.Size(323, 50);
            this.btnAdministracion.TabIndex = 12;
            this.btnAdministracion.Text = "ADMINISTRACION";
            this.btnAdministracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdministracion.UseVisualStyleBackColor = true;
            this.btnAdministracion.Click += new System.EventHandler(this.btnAdministracion_Click);
            // 
            // pnlReportes
            // 
            this.pnlReportes.Controls.Add(this.btnRVentas);
            this.pnlReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReportes.Location = new System.Drawing.Point(0, 837);
            this.pnlReportes.Name = "pnlReportes";
            this.pnlReportes.Size = new System.Drawing.Size(323, 40);
            this.pnlReportes.TabIndex = 11;
            // 
            // btnRVentas
            // 
            this.btnRVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(225)))));
            this.btnRVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRVentas.FlatAppearance.BorderSize = 0;
            this.btnRVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnRVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRVentas.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRVentas.ForeColor = System.Drawing.Color.White;
            this.btnRVentas.Location = new System.Drawing.Point(0, 0);
            this.btnRVentas.Name = "btnRVentas";
            this.btnRVentas.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnRVentas.Size = new System.Drawing.Size(323, 40);
            this.btnRVentas.TabIndex = 0;
            this.btnRVentas.Text = "Estadisticas Ventas";
            this.btnRVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRVentas.UseVisualStyleBackColor = false;
            this.btnRVentas.Click += new System.EventHandler(this.btnRVentas_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Image = global::Pantallas.Properties.Resources.grafico_histograma;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 787);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReportes.Size = new System.Drawing.Size(323, 50);
            this.btnReportes.TabIndex = 10;
            this.btnReportes.Text = "REPORTES";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // pnlClientes
            // 
            this.pnlClientes.Controls.Add(this.btnCGestionar);
            this.pnlClientes.Controls.Add(this.btnCBuscar);
            this.pnlClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlClientes.Location = new System.Drawing.Point(0, 707);
            this.pnlClientes.Name = "pnlClientes";
            this.pnlClientes.Size = new System.Drawing.Size(323, 80);
            this.pnlClientes.TabIndex = 7;
            // 
            // btnCGestionar
            // 
            this.btnCGestionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(225)))));
            this.btnCGestionar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCGestionar.FlatAppearance.BorderSize = 0;
            this.btnCGestionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnCGestionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCGestionar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCGestionar.ForeColor = System.Drawing.Color.White;
            this.btnCGestionar.Location = new System.Drawing.Point(0, 40);
            this.btnCGestionar.Name = "btnCGestionar";
            this.btnCGestionar.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnCGestionar.Size = new System.Drawing.Size(323, 40);
            this.btnCGestionar.TabIndex = 1;
            this.btnCGestionar.Text = "Gestionar Cliente";
            this.btnCGestionar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCGestionar.UseVisualStyleBackColor = false;
            this.btnCGestionar.Click += new System.EventHandler(this.btnCGestionar_Click);
            // 
            // btnCBuscar
            // 
            this.btnCBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(225)))));
            this.btnCBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCBuscar.FlatAppearance.BorderSize = 0;
            this.btnCBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnCBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCBuscar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCBuscar.ForeColor = System.Drawing.Color.White;
            this.btnCBuscar.Location = new System.Drawing.Point(0, 0);
            this.btnCBuscar.Name = "btnCBuscar";
            this.btnCBuscar.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnCBuscar.Size = new System.Drawing.Size(323, 40);
            this.btnCBuscar.TabIndex = 0;
            this.btnCBuscar.Text = "Buscar Cliente";
            this.btnCBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCBuscar.UseVisualStyleBackColor = false;
            this.btnCBuscar.Click += new System.EventHandler(this.btnCBuscar_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Image = global::Pantallas.Properties.Resources.usuarios_alt;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 657);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(323, 50);
            this.btnClientes.TabIndex = 6;
            this.btnClientes.Text = "CLIENTES";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // pnlProductos
            // 
            this.pnlProductos.Controls.Add(this.btnSolicitudStock);
            this.pnlProductos.Controls.Add(this.btnPConsultar);
            this.pnlProductos.Controls.Add(this.btnPBuscar);
            this.pnlProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProductos.Location = new System.Drawing.Point(0, 537);
            this.pnlProductos.Name = "pnlProductos";
            this.pnlProductos.Size = new System.Drawing.Size(323, 120);
            this.pnlProductos.TabIndex = 5;
            // 
            // btnSolicitudStock
            // 
            this.btnSolicitudStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(225)))));
            this.btnSolicitudStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSolicitudStock.FlatAppearance.BorderSize = 0;
            this.btnSolicitudStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnSolicitudStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolicitudStock.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSolicitudStock.ForeColor = System.Drawing.Color.White;
            this.btnSolicitudStock.Location = new System.Drawing.Point(0, 80);
            this.btnSolicitudStock.Name = "btnSolicitudStock";
            this.btnSolicitudStock.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnSolicitudStock.Size = new System.Drawing.Size(323, 40);
            this.btnSolicitudStock.TabIndex = 2;
            this.btnSolicitudStock.Text = "Solicitudes Stock";
            this.btnSolicitudStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSolicitudStock.UseVisualStyleBackColor = false;
            this.btnSolicitudStock.Click += new System.EventHandler(this.btnSolicitudStock_Click);
            // 
            // btnPConsultar
            // 
            this.btnPConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(225)))));
            this.btnPConsultar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPConsultar.FlatAppearance.BorderSize = 0;
            this.btnPConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnPConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPConsultar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPConsultar.ForeColor = System.Drawing.Color.White;
            this.btnPConsultar.Location = new System.Drawing.Point(0, 40);
            this.btnPConsultar.Name = "btnPConsultar";
            this.btnPConsultar.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnPConsultar.Size = new System.Drawing.Size(323, 40);
            this.btnPConsultar.TabIndex = 1;
            this.btnPConsultar.Text = "Gestion Productos";
            this.btnPConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPConsultar.UseVisualStyleBackColor = false;
            this.btnPConsultar.Click += new System.EventHandler(this.btnPConsultar_Click);
            // 
            // btnPBuscar
            // 
            this.btnPBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(225)))));
            this.btnPBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPBuscar.FlatAppearance.BorderSize = 0;
            this.btnPBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnPBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPBuscar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPBuscar.ForeColor = System.Drawing.Color.White;
            this.btnPBuscar.Location = new System.Drawing.Point(0, 0);
            this.btnPBuscar.Name = "btnPBuscar";
            this.btnPBuscar.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnPBuscar.Size = new System.Drawing.Size(323, 40);
            this.btnPBuscar.TabIndex = 0;
            this.btnPBuscar.Text = "Buscar Prodructo";
            this.btnPBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPBuscar.UseVisualStyleBackColor = false;
            this.btnPBuscar.Click += new System.EventHandler(this.btnPBuscar_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Image = global::Pantallas.Properties.Resources.tienda;
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(0, 487);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProductos.Size = new System.Drawing.Size(323, 50);
            this.btnProductos.TabIndex = 4;
            this.btnProductos.Text = "PRODUCTO";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // pnlVentas
            // 
            this.pnlVentas.Controls.Add(this.btnSolicitudes);
            this.pnlVentas.Controls.Add(this.btnVEstado);
            this.pnlVentas.Controls.Add(this.btnVPedido);
            this.pnlVentas.Controls.Add(this.btnVPresu);
            this.pnlVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVentas.Location = new System.Drawing.Point(0, 327);
            this.pnlVentas.Name = "pnlVentas";
            this.pnlVentas.Size = new System.Drawing.Size(323, 160);
            this.pnlVentas.TabIndex = 3;
            // 
            // btnSolicitudes
            // 
            this.btnSolicitudes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(225)))));
            this.btnSolicitudes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSolicitudes.FlatAppearance.BorderSize = 0;
            this.btnSolicitudes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnSolicitudes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolicitudes.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSolicitudes.ForeColor = System.Drawing.Color.White;
            this.btnSolicitudes.Location = new System.Drawing.Point(0, 120);
            this.btnSolicitudes.Name = "btnSolicitudes";
            this.btnSolicitudes.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnSolicitudes.Size = new System.Drawing.Size(323, 40);
            this.btnSolicitudes.TabIndex = 3;
            this.btnSolicitudes.Text = "Solicitudes";
            this.btnSolicitudes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSolicitudes.UseVisualStyleBackColor = false;
            this.btnSolicitudes.Click += new System.EventHandler(this.btnSolicitudes_Click);
            // 
            // btnVEstado
            // 
            this.btnVEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(225)))));
            this.btnVEstado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVEstado.FlatAppearance.BorderSize = 0;
            this.btnVEstado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnVEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVEstado.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVEstado.ForeColor = System.Drawing.Color.White;
            this.btnVEstado.Location = new System.Drawing.Point(0, 80);
            this.btnVEstado.Name = "btnVEstado";
            this.btnVEstado.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnVEstado.Size = new System.Drawing.Size(323, 40);
            this.btnVEstado.TabIndex = 2;
            this.btnVEstado.Text = "Consultar Estado";
            this.btnVEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVEstado.UseVisualStyleBackColor = false;
            this.btnVEstado.Click += new System.EventHandler(this.btnVEstado_Click);
            // 
            // btnVPedido
            // 
            this.btnVPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(225)))));
            this.btnVPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVPedido.FlatAppearance.BorderSize = 0;
            this.btnVPedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnVPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVPedido.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVPedido.ForeColor = System.Drawing.Color.White;
            this.btnVPedido.Location = new System.Drawing.Point(0, 40);
            this.btnVPedido.Name = "btnVPedido";
            this.btnVPedido.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnVPedido.Size = new System.Drawing.Size(323, 40);
            this.btnVPedido.TabIndex = 1;
            this.btnVPedido.Text = "Generar Pedido";
            this.btnVPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVPedido.UseVisualStyleBackColor = false;
            this.btnVPedido.Click += new System.EventHandler(this.btnVPedido_Click);
            // 
            // btnVPresu
            // 
            this.btnVPresu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(225)))));
            this.btnVPresu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVPresu.FlatAppearance.BorderSize = 0;
            this.btnVPresu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnVPresu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVPresu.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVPresu.ForeColor = System.Drawing.Color.White;
            this.btnVPresu.Location = new System.Drawing.Point(0, 0);
            this.btnVPresu.Name = "btnVPresu";
            this.btnVPresu.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnVPresu.Size = new System.Drawing.Size(323, 40);
            this.btnVPresu.TabIndex = 0;
            this.btnVPresu.Text = "Generar Presupuesto";
            this.btnVPresu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVPresu.UseVisualStyleBackColor = false;
            this.btnVPresu.Click += new System.EventHandler(this.btnVPresu_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.Image = global::Pantallas.Properties.Resources.carrito_de_compras;
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(0, 277);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnVentas.Size = new System.Drawing.Size(323, 50);
            this.btnVentas.TabIndex = 2;
            this.btnVentas.Text = "VENTAS";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Image = global::Pantallas.Properties.Resources.salida_32x32;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 927);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCerrarSesion.Size = new System.Drawing.Size(323, 50);
            this.btnCerrarSesion.TabIndex = 1;
            this.btnCerrarSesion.Text = "CERRAR SESION";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // pnlInfoUser
            // 
            this.pnlInfoUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pnlInfoUser.Controls.Add(this.lblHoraLogo);
            this.pnlInfoUser.Controls.Add(this.pnlLine2);
            this.pnlInfoUser.Controls.Add(this.pnlLine1);
            this.pnlInfoUser.Controls.Add(this.txtRol);
            this.pnlInfoUser.Controls.Add(this.txtUsuario);
            this.pnlInfoUser.Controls.Add(this.label2);
            this.pnlInfoUser.Controls.Add(this.label1);
            this.pnlInfoUser.Controls.Add(this.pictureBox3);
            this.pnlInfoUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfoUser.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlInfoUser.Location = new System.Drawing.Point(0, 0);
            this.pnlInfoUser.Name = "pnlInfoUser";
            this.pnlInfoUser.Size = new System.Drawing.Size(323, 277);
            this.pnlInfoUser.TabIndex = 0;
            // 
            // lblHoraLogo
            // 
            this.lblHoraLogo.AutoSize = true;
            this.lblHoraLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(204)))));
            this.lblHoraLogo.Location = new System.Drawing.Point(36, 160);
            this.lblHoraLogo.Name = "lblHoraLogo";
            this.lblHoraLogo.Size = new System.Drawing.Size(82, 24);
            this.lblHoraLogo.TabIndex = 6;
            this.lblHoraLogo.Text = "label3";
            // 
            // pnlLine2
            // 
            this.pnlLine2.BackColor = System.Drawing.Color.White;
            this.pnlLine2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLine2.Location = new System.Drawing.Point(0, 276);
            this.pnlLine2.Name = "pnlLine2";
            this.pnlLine2.Size = new System.Drawing.Size(323, 1);
            this.pnlLine2.TabIndex = 5;
            // 
            // pnlLine1
            // 
            this.pnlLine1.BackColor = System.Drawing.Color.White;
            this.pnlLine1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLine1.Location = new System.Drawing.Point(0, 196);
            this.pnlLine1.Name = "pnlLine1";
            this.pnlLine1.Size = new System.Drawing.Size(323, 1);
            this.pnlLine1.TabIndex = 4;
            // 
            // txtRol
            // 
            this.txtRol.AutoSize = true;
            this.txtRol.ForeColor = System.Drawing.Color.White;
            this.txtRol.Location = new System.Drawing.Point(124, 241);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(82, 24);
            this.txtRol.TabIndex = 3;
            this.txtRol.Text = "label3";
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoSize = true;
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.Location = new System.Drawing.Point(122, 209);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(82, 24);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rol ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(204)))));
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox3.Image = global::Pantallas.Properties.Resources.PCMaker_Logo_Vertical_Color;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(323, 196);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::Pantallas.Properties.Resources.PCMaker_Logo_Vertical_con_eslogan_en_blanco;
            this.pictureBox2.Location = new System.Drawing.Point(381, 241);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(462, 405);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.Controls.Add(this.lblMain2);
            this.pnlMain.Controls.Add(this.lblMain1);
            this.pnlMain.Controls.Add(this.pictureBox2);
            this.pnlMain.Location = new System.Drawing.Point(340, 36);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1100, 864);
            this.pnlMain.TabIndex = 2;
            // 
            // lblMain2
            // 
            this.lblMain2.AutoSize = true;
            this.lblMain2.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMain2.ForeColor = System.Drawing.Color.White;
            this.lblMain2.Location = new System.Drawing.Point(271, 131);
            this.lblMain2.Name = "lblMain2";
            this.lblMain2.Size = new System.Drawing.Size(683, 41);
            this.lblMain2.TabIndex = 5;
            this.lblMain2.Text = "A LA NUEVA FORMA DE CREAR HISTORIAS";
            // 
            // lblMain1
            // 
            this.lblMain1.AutoSize = true;
            this.lblMain1.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMain1.ForeColor = System.Drawing.Color.White;
            this.lblMain1.Location = new System.Drawing.Point(490, 46);
            this.lblMain1.Name = "lblMain1";
            this.lblMain1.Size = new System.Drawing.Size(227, 41);
            this.lblMain1.TabIndex = 4;
            this.lblMain1.Text = "BIENVENIDOS";
            // 
            // hora
            // 
            this.hora.Enabled = true;
            this.hora.Tick += new System.EventHandler(this.hora_Tick);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1440, 900);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlBotonera);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenuPrincipal";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.pnlTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlBotonera.ResumeLayout(false);
            this.pnlReportes.ResumeLayout(false);
            this.pnlClientes.ResumeLayout(false);
            this.pnlProductos.ResumeLayout(false);
            this.pnlVentas.ResumeLayout(false);
            this.pnlInfoUser.ResumeLayout(false);
            this.pnlInfoUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlTitle;
        private PictureBox pictureBox1;
        private Panel pnlBotonera;
        private PictureBox picMin;
        private PictureBox picMax;
        private PictureBox picCerrar;
        private PictureBox picRest;
        private PictureBox pictureBox2;
        private Panel pnlMain;
        private Label lblMain2;
        private Label lblMain1;
        private System.Windows.Forms.Timer hora;
        private Panel pnlInfoUser;
        private PictureBox pictureBox3;
        private Label txtRol;
        private Label txtUsuario;
        private Label label2;
        private Label label1;
        private Panel pnlLine2;
        private Panel pnlLine1;
        private Button btnCerrarSesion;
        private Button btnAdministracion;
        private Panel pnlReportes;
        private Button btnReportes;
        private Panel pnlClientes;
        private Button btnClientes;
        private Panel pnlProductos;
        private Button btnProductos;
        private Panel pnlVentas;
        private Button btnVentas;
        private Button btnVEstado;
        private Button btnVPedido;
        private Button btnVPresu;
        private Button btnRVentas;
        private Button btnCGestionar;
        private Button btnCBuscar;
        private Button btnPConsultar;
        private Button btnPBuscar;
        private Button btnSolicitudes;
        public Label lblHoraLogo;
        private Button btnSolicitudStock;
    }
}