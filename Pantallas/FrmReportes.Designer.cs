namespace Pantallas
{
    partial class FrmReportes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.plVentas = new System.Windows.Forms.Panel();
            this.dgvReportesVentas = new System.Windows.Forms.DataGridView();
            this.plInformes = new System.Windows.Forms.Panel();
            this.rbRegistros = new System.Windows.Forms.RadioButton();
            this.rbUsuarios = new System.Windows.Forms.RadioButton();
            this.rbVentas = new System.Windows.Forms.RadioButton();
            this.rbPresupuestos = new System.Windows.Forms.RadioButton();
            this.rbProductos = new System.Windows.Forms.RadioButton();
            this.rbClientes = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnJson = new System.Windows.Forms.Button();
            this.btnCsv = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlTitle.SuspendLayout();
            this.plVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportesVentas)).BeginInit();
            this.plInformes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.label1);
            this.pnlTitle.Controls.Add(this.btnVolver);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1083, 122);
            this.pnlTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(462, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "REPORTES";
            // 
            // btnVolver
            // 
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Image = global::Pantallas.Properties.Resources.deshacer;
            this.btnVolver.Location = new System.Drawing.Point(12, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnVolver.Size = new System.Drawing.Size(156, 82);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // plVentas
            // 
            this.plVentas.Controls.Add(this.dgvReportesVentas);
            this.plVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.plVentas.Location = new System.Drawing.Point(0, 122);
            this.plVentas.Name = "plVentas";
            this.plVentas.Size = new System.Drawing.Size(1083, 436);
            this.plVentas.TabIndex = 1;
            // 
            // dgvReportesVentas
            // 
            this.dgvReportesVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReportesVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReportesVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.dgvReportesVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReportesVentas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReportesVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReportesVentas.Location = new System.Drawing.Point(0, 0);
            this.dgvReportesVentas.Name = "dgvReportesVentas";
            this.dgvReportesVentas.ReadOnly = true;
            this.dgvReportesVentas.RowHeadersVisible = false;
            this.dgvReportesVentas.RowTemplate.Height = 25;
            this.dgvReportesVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReportesVentas.Size = new System.Drawing.Size(1083, 436);
            this.dgvReportesVentas.TabIndex = 0;
            // 
            // plInformes
            // 
            this.plInformes.Controls.Add(this.rbRegistros);
            this.plInformes.Controls.Add(this.rbUsuarios);
            this.plInformes.Controls.Add(this.rbVentas);
            this.plInformes.Controls.Add(this.rbPresupuestos);
            this.plInformes.Controls.Add(this.rbProductos);
            this.plInformes.Controls.Add(this.rbClientes);
            this.plInformes.Controls.Add(this.panel2);
            this.plInformes.Controls.Add(this.panel3);
            this.plInformes.Controls.Add(this.panel1);
            this.plInformes.Controls.Add(this.label3);
            this.plInformes.Controls.Add(this.btnJson);
            this.plInformes.Controls.Add(this.btnCsv);
            this.plInformes.Controls.Add(this.label2);
            this.plInformes.Dock = System.Windows.Forms.DockStyle.Top;
            this.plInformes.Location = new System.Drawing.Point(0, 558);
            this.plInformes.Name = "plInformes";
            this.plInformes.Size = new System.Drawing.Size(1083, 615);
            this.plInformes.TabIndex = 2;
            // 
            // rbRegistros
            // 
            this.rbRegistros.AutoSize = true;
            this.rbRegistros.Location = new System.Drawing.Point(579, 274);
            this.rbRegistros.Name = "rbRegistros";
            this.rbRegistros.Size = new System.Drawing.Size(118, 26);
            this.rbRegistros.TabIndex = 5;
            this.rbRegistros.TabStop = true;
            this.rbRegistros.Text = "Registros";
            this.rbRegistros.UseVisualStyleBackColor = true;
            // 
            // rbUsuarios
            // 
            this.rbUsuarios.AutoSize = true;
            this.rbUsuarios.Location = new System.Drawing.Point(331, 274);
            this.rbUsuarios.Name = "rbUsuarios";
            this.rbUsuarios.Size = new System.Drawing.Size(108, 26);
            this.rbUsuarios.TabIndex = 5;
            this.rbUsuarios.TabStop = true;
            this.rbUsuarios.Text = "Usuarios";
            this.rbUsuarios.UseVisualStyleBackColor = true;
            // 
            // rbVentas
            // 
            this.rbVentas.AutoSize = true;
            this.rbVentas.Location = new System.Drawing.Point(860, 209);
            this.rbVentas.Name = "rbVentas";
            this.rbVentas.Size = new System.Drawing.Size(88, 26);
            this.rbVentas.TabIndex = 5;
            this.rbVentas.TabStop = true;
            this.rbVentas.Text = "Ventas";
            this.rbVentas.UseVisualStyleBackColor = true;
            // 
            // rbPresupuestos
            // 
            this.rbPresupuestos.AutoSize = true;
            this.rbPresupuestos.Location = new System.Drawing.Point(579, 209);
            this.rbPresupuestos.Name = "rbPresupuestos";
            this.rbPresupuestos.Size = new System.Drawing.Size(148, 26);
            this.rbPresupuestos.TabIndex = 5;
            this.rbPresupuestos.TabStop = true;
            this.rbPresupuestos.Text = "Presupuestos";
            this.rbPresupuestos.UseVisualStyleBackColor = true;
            // 
            // rbProductos
            // 
            this.rbProductos.AutoSize = true;
            this.rbProductos.Location = new System.Drawing.Point(331, 209);
            this.rbProductos.Name = "rbProductos";
            this.rbProductos.Size = new System.Drawing.Size(118, 26);
            this.rbProductos.TabIndex = 5;
            this.rbProductos.TabStop = true;
            this.rbProductos.Text = "Productos";
            this.rbProductos.UseVisualStyleBackColor = true;
            // 
            // rbClientes
            // 
            this.rbClientes.AutoSize = true;
            this.rbClientes.Location = new System.Drawing.Point(40, 209);
            this.rbClientes.Name = "rbClientes";
            this.rbClientes.Size = new System.Drawing.Size(108, 26);
            this.rbClientes.TabIndex = 5;
            this.rbClientes.TabStop = true;
            this.rbClientes.Text = "Clientes";
            this.rbClientes.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(12, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1058, 3);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(13, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1058, 3);
            this.panel3.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 3);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Seleccione lo que quiera exportar:";
            // 
            // btnJson
            // 
            this.btnJson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJson.Location = new System.Drawing.Point(566, 349);
            this.btnJson.Name = "btnJson";
            this.btnJson.Size = new System.Drawing.Size(161, 56);
            this.btnJson.TabIndex = 2;
            this.btnJson.Text = "JSON";
            this.btnJson.UseVisualStyleBackColor = true;
            this.btnJson.Click += new System.EventHandler(this.btnJson_Click);
            // 
            // btnCsv
            // 
            this.btnCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCsv.Location = new System.Drawing.Point(331, 349);
            this.btnCsv.Name = "btnCsv";
            this.btnCsv.Size = new System.Drawing.Size(161, 56);
            this.btnCsv.TabIndex = 2;
            this.btnCsv.Text = "CSV";
            this.btnCsv.UseVisualStyleBackColor = true;
            this.btnCsv.Click += new System.EventHandler(this.btnCsv_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(445, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "EXPORTAR";
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1100, 864);
            this.Controls.Add(this.plInformes);
            this.Controls.Add(this.plVentas);
            this.Controls.Add(this.pnlTitle);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmReportes";
            this.Text = "FrmReportes";
            this.Load += new System.EventHandler(this.FrmReportes_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.plVentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportesVentas)).EndInit();
            this.plInformes.ResumeLayout(false);
            this.plInformes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlTitle;
        private Button btnVolver;
        private Label label1;
        private Panel plVentas;
        private DataGridView dgvReportesVentas;
        private Panel plInformes;
        private Panel panel2;
        private Panel panel1;
        private Label label3;
        private Button btnJson;
        private Button btnCsv;
        private Label label2;
        private RadioButton rbRegistros;
        private RadioButton rbUsuarios;
        private RadioButton rbVentas;
        private RadioButton rbPresupuestos;
        private RadioButton rbProductos;
        private RadioButton rbClientes;
        private Panel panel3;
    }
}