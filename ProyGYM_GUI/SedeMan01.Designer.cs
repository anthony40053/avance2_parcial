
namespace ProyGYM_GUI
{
    partial class SedeMan01
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnActulizar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.dtgSede = new System.Windows.Forms.DataGridView();
            this.Id_Sede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dir_Sede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Des_Sede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.NombreFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSede)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(766, 477);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 29;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActulizar
            // 
            this.btnActulizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActulizar.Location = new System.Drawing.Point(685, 477);
            this.btnActulizar.Name = "btnActulizar";
            this.btnActulizar.Size = new System.Drawing.Size(75, 23);
            this.btnActulizar.TabIndex = 28;
            this.btnActulizar.Text = "Actualizar";
            this.btnActulizar.UseVisualStyleBackColor = true;
            this.btnActulizar.Click += new System.EventHandler(this.btnActulizar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertar.Location = new System.Drawing.Point(604, 477);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 27;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // dtgSede
            // 
            this.dtgSede.AllowUserToAddRows = false;
            this.dtgSede.AllowUserToDeleteRows = false;
            this.dtgSede.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgSede.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgSede.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSede.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Sede,
            this.Dir_Sede,
            this.Des_Sede,
            this.Departamento,
            this.Provincia,
            this.Distrito,
            this.Estado});
            this.dtgSede.Location = new System.Drawing.Point(12, 73);
            this.dtgSede.Name = "dtgSede";
            this.dtgSede.ReadOnly = true;
            this.dtgSede.RowHeadersVisible = false;
            this.dtgSede.Size = new System.Drawing.Size(829, 397);
            this.dtgSede.TabIndex = 26;
            this.dtgSede.DoubleClick += new System.EventHandler(this.dtgSede_DoubleClick);
            // 
            // Id_Sede
            // 
            this.Id_Sede.DataPropertyName = "Id_Sede";
            this.Id_Sede.HeaderText = "ID";
            this.Id_Sede.Name = "Id_Sede";
            this.Id_Sede.ReadOnly = true;
            // 
            // Dir_Sede
            // 
            this.Dir_Sede.DataPropertyName = "Dir_Sede";
            this.Dir_Sede.HeaderText = "Direccion";
            this.Dir_Sede.Name = "Dir_Sede";
            this.Dir_Sede.ReadOnly = true;
            // 
            // Des_Sede
            // 
            this.Des_Sede.DataPropertyName = "Des_Sede";
            this.Des_Sede.HeaderText = "Descripcion";
            this.Des_Sede.Name = "Des_Sede";
            this.Des_Sede.ReadOnly = true;
            // 
            // Departamento
            // 
            this.Departamento.DataPropertyName = "Departamento";
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.Name = "Departamento";
            this.Departamento.ReadOnly = true;
            // 
            // Provincia
            // 
            this.Provincia.DataPropertyName = "Provincia";
            this.Provincia.HeaderText = "Provincia";
            this.Provincia.Name = "Provincia";
            this.Provincia.ReadOnly = true;
            // 
            // Distrito
            // 
            this.Distrito.DataPropertyName = "Distrito";
            this.Distrito.HeaderText = "Distrito";
            this.Distrito.Name = "Distrito";
            this.Distrito.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 484);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Resultados :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblRegistros
            // 
            this.lblRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRegistros.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistros.Location = new System.Drawing.Point(79, 480);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(72, 20);
            this.lblRegistros.TabIndex = 24;
            this.lblRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRegistros.Click += new System.EventHandler(this.lblRegistros_Click);
            // 
            // NombreFiltro
            // 
            this.NombreFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NombreFiltro.Location = new System.Drawing.Point(156, 37);
            this.NombreFiltro.Name = "NombreFiltro";
            this.NombreFiltro.Size = new System.Drawing.Size(331, 20);
            this.NombreFiltro.TabIndex = 23;
            this.NombreFiltro.TextChanged += new System.EventHandler(this.NombreFiltro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ingrese el ID de sede :";
            // 
            // SedeMan01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 515);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActulizar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.dtgSede);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.NombreFiltro);
            this.Controls.Add(this.label1);
            this.Name = "SedeMan01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de sedes";
            this.Load += new System.EventHandler(this.SedeMan01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSede)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnActulizar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.DataGridView dtgSede;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.TextBox NombreFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Sede;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dir_Sede;
        private System.Windows.Forms.DataGridViewTextBoxColumn Des_Sede;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}