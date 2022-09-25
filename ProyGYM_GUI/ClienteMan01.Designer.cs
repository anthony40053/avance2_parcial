
namespace ProyGYM_GUI
{
    partial class ClienteMan01
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
            this.dtgCliente = new System.Windows.Forms.DataGridView();
            this.Id_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Talla_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telf_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.NombreFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(910, 397);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActulizar
            // 
            this.btnActulizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActulizar.Location = new System.Drawing.Point(828, 397);
            this.btnActulizar.Name = "btnActulizar";
            this.btnActulizar.Size = new System.Drawing.Size(75, 23);
            this.btnActulizar.TabIndex = 20;
            this.btnActulizar.Text = "Actualizar";
            this.btnActulizar.UseVisualStyleBackColor = true;
            this.btnActulizar.Click += new System.EventHandler(this.btnActulizar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertar.Location = new System.Drawing.Point(746, 397);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 19;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // dtgCliente
            // 
            this.dtgCliente.AllowUserToAddRows = false;
            this.dtgCliente.AllowUserToDeleteRows = false;
            this.dtgCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Cliente,
            this.Dni_Cliente,
            this.Nombre_Cliente,
            this.Apellidos_Cliente,
            this.Talla_Cliente,
            this.Direccion_Cliente,
            this.Departamento,
            this.Provincia,
            this.Distrito,
            this.Telf_Cliente,
            this.Sexo,
            this.Fecha_Nacimiento,
            this.Estado});
            this.dtgCliente.Location = new System.Drawing.Point(12, 48);
            this.dtgCliente.Name = "dtgCliente";
            this.dtgCliente.ReadOnly = true;
            this.dtgCliente.RowHeadersVisible = false;
            this.dtgCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCliente.Size = new System.Drawing.Size(973, 336);
            this.dtgCliente.TabIndex = 2;
            this.dtgCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCliente_CellContentClick);
            this.dtgCliente.DoubleClick += new System.EventHandler(this.dtgCliente_DoubleClick);
            // 
            // Id_Cliente
            // 
            this.Id_Cliente.DataPropertyName = "Id_Cliente";
            this.Id_Cliente.HeaderText = "ID";
            this.Id_Cliente.Name = "Id_Cliente";
            // 
            // Dni_Cliente
            // 
            this.Dni_Cliente.DataPropertyName = "Dni_Cliente";
            this.Dni_Cliente.HeaderText = "DNI";
            this.Dni_Cliente.Name = "Dni_Cliente";
            // 
            // Nombre_Cliente
            // 
            this.Nombre_Cliente.DataPropertyName = "Nombre_Cliente";
            this.Nombre_Cliente.HeaderText = "Nombre";
            this.Nombre_Cliente.Name = "Nombre_Cliente";
            // 
            // Apellidos_Cliente
            // 
            this.Apellidos_Cliente.DataPropertyName = "Apellidos_Cliente";
            this.Apellidos_Cliente.HeaderText = "Apellidos";
            this.Apellidos_Cliente.Name = "Apellidos_Cliente";
            // 
            // Talla_Cliente
            // 
            this.Talla_Cliente.DataPropertyName = "Talla_Cliente";
            this.Talla_Cliente.HeaderText = "Talla";
            this.Talla_Cliente.Name = "Talla_Cliente";
            // 
            // Direccion_Cliente
            // 
            this.Direccion_Cliente.DataPropertyName = "Direccion_Cliente";
            this.Direccion_Cliente.HeaderText = "Direccion";
            this.Direccion_Cliente.Name = "Direccion_Cliente";
            // 
            // Departamento
            // 
            this.Departamento.DataPropertyName = "Departamento";
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.Name = "Departamento";
            // 
            // Provincia
            // 
            this.Provincia.DataPropertyName = "Provincia";
            this.Provincia.HeaderText = "Provincia";
            this.Provincia.Name = "Provincia";
            // 
            // Distrito
            // 
            this.Distrito.DataPropertyName = "Distrito";
            this.Distrito.HeaderText = "Distrito";
            this.Distrito.Name = "Distrito";
            // 
            // Telf_Cliente
            // 
            this.Telf_Cliente.DataPropertyName = "Telf_Cliente";
            this.Telf_Cliente.HeaderText = "Telefono";
            this.Telf_Cliente.Name = "Telf_Cliente";
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Sexo";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            // 
            // Fecha_Nacimiento
            // 
            this.Fecha_Nacimiento.DataPropertyName = "Fecha_Nacimiento";
            this.Fecha_Nacimiento.HeaderText = "Fecha de Nacimiento";
            this.Fecha_Nacimiento.Name = "Fecha_Nacimiento";
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Resultados :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblRegistros
            // 
            this.lblRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRegistros.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistros.Location = new System.Drawing.Point(130, 397);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(72, 20);
            this.lblRegistros.TabIndex = 16;
            this.lblRegistros.Click += new System.EventHandler(this.lblRegistros_Click);
            // 
            // NombreFiltro
            // 
            this.NombreFiltro.Location = new System.Drawing.Point(210, 12);
            this.NombreFiltro.Name = "NombreFiltro";
            this.NombreFiltro.Size = new System.Drawing.Size(231, 20);
            this.NombreFiltro.TabIndex = 15;
            this.NombreFiltro.TextChanged += new System.EventHandler(this.NombreFiltro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ingrese el Apellido del cliente :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ClienteMan01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 432);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActulizar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.dtgCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.NombreFiltro);
            this.Controls.Add(this.label1);
            this.Name = "ClienteMan01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Clientes";
            this.Load += new System.EventHandler(this.ClienteMan01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnActulizar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.DataGridView dtgCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.TextBox NombreFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Talla_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telf_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}