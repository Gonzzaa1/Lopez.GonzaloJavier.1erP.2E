namespace Pantallas
{
    partial class FrmAdministracion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbAdministracion = new System.Windows.Forms.GroupBox();
            this.btnCancelSol = new System.Windows.Forms.Button();
            this.btnConfirmSol = new System.Windows.Forms.Button();
            this.btnSolicitarCambios = new System.Windows.Forms.Button();
            this.btnEditPass = new System.Windows.Forms.Button();
            this.cbRoles = new System.Windows.Forms.ComboBox();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlCambiarContraseña = new System.Windows.Forms.Panel();
            this.cbShowPass = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtNewPassRep = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtLastPass = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlBotonera = new System.Windows.Forms.Panel();
            this.txtSolicitudesMod = new System.Windows.Forms.TextBox();
            this.lblSolicitudes = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSolis = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.pnlListado = new System.Windows.Forms.Panel();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.pnlTitle.SuspendLayout();
            this.gbAdministracion.SuspendLayout();
            this.pnlCambiarContraseña.SuspendLayout();
            this.pnlBotonera.SuspendLayout();
            this.pnlListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(399, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "ADMINISTRACION";
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.btnGuardar);
            this.pnlTitle.Controls.Add(this.button1);
            this.pnlTitle.Controls.Add(this.label1);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1100, 83);
            this.pnlTitle.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = global::Pantallas.Properties.Resources.disco;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(945, 12);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(130, 56);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Pantallas.Properties.Resources.deshacer;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(130, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "VOLVER";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbAdministracion
            // 
            this.gbAdministracion.Controls.Add(this.btnCancelSol);
            this.gbAdministracion.Controls.Add(this.btnConfirmSol);
            this.gbAdministracion.Controls.Add(this.btnSolicitarCambios);
            this.gbAdministracion.Controls.Add(this.btnEditPass);
            this.gbAdministracion.Controls.Add(this.cbRoles);
            this.gbAdministracion.Controls.Add(this.btnNo);
            this.gbAdministracion.Controls.Add(this.btnOk);
            this.gbAdministracion.Controls.Add(this.txtCorreo);
            this.gbAdministracion.Controls.Add(this.txtApellido);
            this.gbAdministracion.Controls.Add(this.txtNombre);
            this.gbAdministracion.Controls.Add(this.txtContraseña);
            this.gbAdministracion.Controls.Add(this.txtUsuario);
            this.gbAdministracion.Controls.Add(this.label7);
            this.gbAdministracion.Controls.Add(this.label6);
            this.gbAdministracion.Controls.Add(this.label5);
            this.gbAdministracion.Controls.Add(this.label4);
            this.gbAdministracion.Controls.Add(this.label3);
            this.gbAdministracion.Controls.Add(this.label2);
            this.gbAdministracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbAdministracion.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbAdministracion.ForeColor = System.Drawing.Color.White;
            this.gbAdministracion.Location = new System.Drawing.Point(0, 83);
            this.gbAdministracion.Name = "gbAdministracion";
            this.gbAdministracion.Size = new System.Drawing.Size(1100, 224);
            this.gbAdministracion.TabIndex = 2;
            this.gbAdministracion.TabStop = false;
            // 
            // btnCancelSol
            // 
            this.btnCancelSol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelSol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelSol.Location = new System.Drawing.Point(889, 174);
            this.btnCancelSol.Name = "btnCancelSol";
            this.btnCancelSol.Size = new System.Drawing.Size(135, 32);
            this.btnCancelSol.TabIndex = 4;
            this.btnCancelSol.Text = "Cancelar";
            this.btnCancelSol.UseVisualStyleBackColor = true;
            this.btnCancelSol.Visible = false;
            this.btnCancelSol.Click += new System.EventHandler(this.btnCancelSol_Click);
            // 
            // btnConfirmSol
            // 
            this.btnConfirmSol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmSol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmSol.Location = new System.Drawing.Point(665, 174);
            this.btnConfirmSol.Name = "btnConfirmSol";
            this.btnConfirmSol.Size = new System.Drawing.Size(135, 32);
            this.btnConfirmSol.TabIndex = 4;
            this.btnConfirmSol.Text = "Confirmar";
            this.btnConfirmSol.UseVisualStyleBackColor = true;
            this.btnConfirmSol.Visible = false;
            this.btnConfirmSol.Click += new System.EventHandler(this.btnConfirmSol_Click);
            // 
            // btnSolicitarCambios
            // 
            this.btnSolicitarCambios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSolicitarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolicitarCambios.Location = new System.Drawing.Point(703, 174);
            this.btnSolicitarCambios.Name = "btnSolicitarCambios";
            this.btnSolicitarCambios.Size = new System.Drawing.Size(288, 32);
            this.btnSolicitarCambios.TabIndex = 4;
            this.btnSolicitarCambios.Text = "Solicitar Modificacion";
            this.btnSolicitarCambios.UseVisualStyleBackColor = true;
            this.btnSolicitarCambios.Click += new System.EventHandler(this.btnSolicitarCambios_Click);
            // 
            // btnEditPass
            // 
            this.btnEditPass.FlatAppearance.BorderSize = 0;
            this.btnEditPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPass.Image = global::Pantallas.Properties.Resources.editar;
            this.btnEditPass.Location = new System.Drawing.Point(461, 76);
            this.btnEditPass.Name = "btnEditPass";
            this.btnEditPass.Size = new System.Drawing.Size(44, 32);
            this.btnEditPass.TabIndex = 3;
            this.btnEditPass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditPass.UseVisualStyleBackColor = true;
            this.btnEditPass.Click += new System.EventHandler(this.btnEditPass_Click);
            // 
            // cbRoles
            // 
            this.cbRoles.FormattingEnabled = true;
            this.cbRoles.Location = new System.Drawing.Point(247, 125);
            this.cbRoles.Name = "cbRoles";
            this.cbRoles.Size = new System.Drawing.Size(208, 32);
            this.cbRoles.TabIndex = 2;
            // 
            // btnNo
            // 
            this.btnNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.Image = global::Pantallas.Properties.Resources.circulo_cruzado;
            this.btnNo.Location = new System.Drawing.Point(582, 169);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(63, 43);
            this.btnNo.TabIndex = 0;
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Visible = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Image = global::Pantallas.Properties.Resources.caja;
            this.btnOk.Location = new System.Drawing.Point(475, 169);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(63, 43);
            this.btnOk.TabIndex = 0;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Visible = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCorreo.Enabled = false;
            this.txtCorreo.Location = new System.Drawing.Point(665, 125);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(359, 32);
            this.txtCorreo.TabIndex = 1;
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(665, 76);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(359, 32);
            this.txtApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(665, 28);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(359, 32);
            this.txtNombre.TabIndex = 1;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Enabled = false;
            this.txtContraseña.Location = new System.Drawing.Point(247, 76);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(208, 32);
            this.txtContraseña.TabIndex = 1;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(247, 28);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(208, 32);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(539, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Correo";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(539, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(539, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Rol";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuario";
            // 
            // pnlCambiarContraseña
            // 
            this.pnlCambiarContraseña.Controls.Add(this.cbShowPass);
            this.pnlCambiarContraseña.Controls.Add(this.btnCancelar);
            this.pnlCambiarContraseña.Controls.Add(this.btnConfirmar);
            this.pnlCambiarContraseña.Controls.Add(this.txtNewPassRep);
            this.pnlCambiarContraseña.Controls.Add(this.txtNewPass);
            this.pnlCambiarContraseña.Controls.Add(this.txtLastPass);
            this.pnlCambiarContraseña.Controls.Add(this.label10);
            this.pnlCambiarContraseña.Controls.Add(this.label9);
            this.pnlCambiarContraseña.Controls.Add(this.label8);
            this.pnlCambiarContraseña.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCambiarContraseña.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlCambiarContraseña.ForeColor = System.Drawing.Color.White;
            this.pnlCambiarContraseña.Location = new System.Drawing.Point(0, 307);
            this.pnlCambiarContraseña.Name = "pnlCambiarContraseña";
            this.pnlCambiarContraseña.Size = new System.Drawing.Size(1100, 180);
            this.pnlCambiarContraseña.TabIndex = 3;
            // 
            // cbShowPass
            // 
            this.cbShowPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbShowPass.AutoSize = true;
            this.cbShowPass.Location = new System.Drawing.Point(734, 50);
            this.cbShowPass.Name = "cbShowPass";
            this.cbShowPass.Size = new System.Drawing.Size(257, 28);
            this.cbShowPass.TabIndex = 3;
            this.cbShowPass.Text = "Mostrar Contraseñas";
            this.cbShowPass.UseVisualStyleBackColor = true;
            this.cbShowPass.CheckedChanged += new System.EventHandler(this.cbShowPass_CheckedChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Location = new System.Drawing.Point(889, 101);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 45);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirmar.Location = new System.Drawing.Point(734, 101);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(135, 45);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtNewPassRep
            // 
            this.txtNewPassRep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNewPassRep.Location = new System.Drawing.Point(400, 114);
            this.txtNewPassRep.Name = "txtNewPassRep";
            this.txtNewPassRep.Size = new System.Drawing.Size(279, 32);
            this.txtNewPassRep.TabIndex = 1;
            this.txtNewPassRep.TextChanged += new System.EventHandler(this.txtNewPassRep_TextChanged);
            // 
            // txtNewPass
            // 
            this.txtNewPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNewPass.Location = new System.Drawing.Point(400, 65);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(279, 32);
            this.txtNewPass.TabIndex = 1;
            this.txtNewPass.TextChanged += new System.EventHandler(this.txtNewPass_TextChanged);
            // 
            // txtLastPass
            // 
            this.txtLastPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLastPass.Location = new System.Drawing.Point(400, 16);
            this.txtLastPass.Name = "txtLastPass";
            this.txtLastPass.Size = new System.Drawing.Size(279, 32);
            this.txtLastPass.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(87, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(298, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "Repetir Nueva contraseña";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(87, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(202, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Contraseña Nueva";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(87, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(238, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Contraseña Anterior";
            // 
            // pnlBotonera
            // 
            this.pnlBotonera.Controls.Add(this.txtSolicitudesMod);
            this.pnlBotonera.Controls.Add(this.lblSolicitudes);
            this.pnlBotonera.Controls.Add(this.txtBuscar);
            this.pnlBotonera.Controls.Add(this.btnBuscar);
            this.pnlBotonera.Controls.Add(this.btnSolis);
            this.pnlBotonera.Controls.Add(this.btnEdit);
            this.pnlBotonera.Controls.Add(this.btnBaja);
            this.pnlBotonera.Controls.Add(this.btnAlta);
            this.pnlBotonera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotonera.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlBotonera.ForeColor = System.Drawing.Color.White;
            this.pnlBotonera.Location = new System.Drawing.Point(0, 487);
            this.pnlBotonera.Name = "pnlBotonera";
            this.pnlBotonera.Size = new System.Drawing.Size(1100, 76);
            this.pnlBotonera.TabIndex = 4;
            // 
            // txtSolicitudesMod
            // 
            this.txtSolicitudesMod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSolicitudesMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtSolicitudesMod.Enabled = false;
            this.txtSolicitudesMod.ForeColor = System.Drawing.Color.White;
            this.txtSolicitudesMod.Location = new System.Drawing.Point(607, 22);
            this.txtSolicitudesMod.Name = "txtSolicitudesMod";
            this.txtSolicitudesMod.Size = new System.Drawing.Size(47, 32);
            this.txtSolicitudesMod.TabIndex = 3;
            this.txtSolicitudesMod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSolicitudesMod.TextChanged += new System.EventHandler(this.txtSolicitudesMod_TextChanged);
            // 
            // lblSolicitudes
            // 
            this.lblSolicitudes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSolicitudes.AutoSize = true;
            this.lblSolicitudes.Location = new System.Drawing.Point(274, 25);
            this.lblSolicitudes.Name = "lblSolicitudes";
            this.lblSolicitudes.Size = new System.Drawing.Size(334, 24);
            this.lblSolicitudes.TabIndex = 2;
            this.lblSolicitudes.Text = "Solicitudes de modificacion";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Location = new System.Drawing.Point(762, 21);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PlaceholderText = "Buscar usuario";
            this.txtBuscar.Size = new System.Drawing.Size(257, 32);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = global::Pantallas.Properties.Resources.busqueda;
            this.btnBuscar.Location = new System.Drawing.Point(1025, 15);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(63, 43);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSolis
            // 
            this.btnSolis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSolis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolis.Image = global::Pantallas.Properties.Resources.acercarse;
            this.btnSolis.Location = new System.Drawing.Point(663, 15);
            this.btnSolis.Name = "btnSolis";
            this.btnSolis.Size = new System.Drawing.Size(63, 43);
            this.btnSolis.TabIndex = 0;
            this.btnSolis.UseVisualStyleBackColor = true;
            this.btnSolis.Click += new System.EventHandler(this.btnSolis_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = global::Pantallas.Properties.Resources.editar;
            this.btnEdit.Location = new System.Drawing.Point(184, 15);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(63, 43);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Enabled = false;
            this.btnBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaja.Image = global::Pantallas.Properties.Resources.borrar_usuario;
            this.btnBaja.Location = new System.Drawing.Point(96, 16);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(63, 43);
            this.btnBaja.TabIndex = 0;
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlta.Image = global::Pantallas.Properties.Resources.agregar_usuario;
            this.btnAlta.Location = new System.Drawing.Point(12, 16);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(63, 43);
            this.btnAlta.TabIndex = 0;
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // pnlListado
            // 
            this.pnlListado.Controls.Add(this.dgvUsers);
            this.pnlListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListado.Location = new System.Drawing.Point(0, 563);
            this.pnlListado.Name = "pnlListado";
            this.pnlListado.Size = new System.Drawing.Size(1100, 301);
            this.pnlListado.TabIndex = 5;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.Location = new System.Drawing.Point(0, 0);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvUsers.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsers.RowTemplate.Height = 25;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(1100, 301);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentDoubleClick);
            // 
            // FrmAdministracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1100, 864);
            this.Controls.Add(this.pnlListado);
            this.Controls.Add(this.pnlBotonera);
            this.Controls.Add(this.pnlCambiarContraseña);
            this.Controls.Add(this.gbAdministracion);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdministracion";
            this.Text = "FrmAdministracion";
            this.Load += new System.EventHandler(this.FrmAdministracion_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.gbAdministracion.ResumeLayout(false);
            this.gbAdministracion.PerformLayout();
            this.pnlCambiarContraseña.ResumeLayout(false);
            this.pnlCambiarContraseña.PerformLayout();
            this.pnlBotonera.ResumeLayout(false);
            this.pnlBotonera.PerformLayout();
            this.pnlListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Label label1;
        private Panel pnlTitle;
        private GroupBox gbAdministracion;
        private TextBox txtCorreo;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel pnlCambiarContraseña;
        private CheckBox cbShowPass;
        private Button btnCancelar;
        private Button btnConfirmar;
        private TextBox txtNewPassRep;
        private TextBox txtNewPass;
        private TextBox txtLastPass;
        private Label label10;
        private Label label9;
        private Label label8;
        private Panel pnlBotonera;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Button btnSolis;
        private Button btnEdit;
        private Button btnBaja;
        private Button btnAlta;
        private Panel pnlListado;
        private DataGridView dgvUsers;
        private ComboBox cbRoles;
        private Button btnEditPass;
        private Button btnSolicitarCambios;
        private TextBox txtSolicitudesMod;
        private Label lblSolicitudes;
        private Button btnCancelSol;
        private Button btnConfirmSol;
        private Button btnNo;
        private Button btnOk;
        private Button btnGuardar;
        private Button button1;
    }
}