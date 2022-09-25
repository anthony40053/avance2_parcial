
namespace ProyGYM_GUI
{
    partial class TrainerMan01
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
            this.dtgTrainer = new System.Windows.Forms.DataGridView();
            this.Id_Trainer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni_Trainer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Trainer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos_Trainer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Talla_Trainer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion_Trainer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telf_Trainer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.NombreFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTrainer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(910, 435);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 28;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActulizar
            // 
            this.btnActulizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActulizar.Location = new System.Drawing.Point(828, 435);
            this.btnActulizar.Name = "btnActulizar";
            this.btnActulizar.Size = new System.Drawing.Size(75, 23);
            this.btnActulizar.TabIndex = 27;
            this.btnActulizar.Text = "Actualizar";
            this.btnActulizar.UseVisualStyleBackColor = true;
            this.btnActulizar.Click += new System.EventHandler(this.btnActulizar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertar.Location = new System.Drawing.Point(746, 435);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 26;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // dtgTrainer
            // 
            this.dtgTrainer.AllowUserToAddRows = false;
            this.dtgTrainer.AllowUserToDeleteRows = false;
            this.dtgTrainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgTrainer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgTrainer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTrainer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Trainer,
            this.Dni_Trainer,
            this.Nombre_Trainer,
            this.Apellidos_Trainer,
            this.Talla_Trainer,
            this.Direccion_Trainer,
            this.Departamento,
            this.Provincia,
            this.Distrito,
            this.Telf_Trainer,
            this.Sexo,
            this.Fecha_Nacimiento,
            this.Estado});
            this.dtgTrainer.Location = new System.Drawing.Point(12, 69);
            this.dtgTrainer.Name = "dtgTrainer";
            this.dtgTrainer.ReadOnly = true;
            this.dtgTrainer.RowHeadersVisible = false;
            this.dtgTrainer.Size = new System.Drawing.Size(973, 346);
            this.dtgTrainer.TabIndex = 25;
            this.dtgTrainer.DoubleClick += new System.EventHandler(this.dtgTrainer_DoubleClick);
            // 
            // Id_Trainer
            // 
            this.Id_Trainer.DataPropertyName = "Id_Trainer";
            this.Id_Trainer.HeaderText = "ID";
            this.Id_Trainer.Name = "Id_Trainer";
            this.Id_Trainer.ReadOnly = true;
            // 
            // Dni_Trainer
            // 
            this.Dni_Trainer.DataPropertyName = "Dni_Trainer";
            this.Dni_Trainer.HeaderText = "DNI";
            this.Dni_Trainer.Name = "Dni_Trainer";
            this.Dni_Trainer.ReadOnly = true;
            // 
            // Nombre_Trainer
            // 
            this.Nombre_Trainer.DataPropertyName = "Nombre_Trainer";
            this.Nombre_Trainer.HeaderText = "Nombre";
            this.Nombre_Trainer.Name = "Nombre_Trainer";
            this.Nombre_Trainer.ReadOnly = true;
            // 
            // Apellidos_Trainer
            // 
            this.Apellidos_Trainer.DataPropertyName = "Apellidos_Trainer";
            this.Apellidos_Trainer.HeaderText = "Apellidos";
            this.Apellidos_Trainer.Name = "Apellidos_Trainer";
            this.Apellidos_Trainer.ReadOnly = true;
            // 
            // Talla_Trainer
            // 
            this.Talla_Trainer.DataPropertyName = "Talla_Trainer";
            this.Talla_Trainer.HeaderText = "Talla";
            this.Talla_Trainer.Name = "Talla_Trainer";
            this.Talla_Trainer.ReadOnly = true;
            // 
            // Direccion_Trainer
            // 
            this.Direccion_Trainer.DataPropertyName = "Direccion_Trainer";
            this.Direccion_Trainer.HeaderText = "Direccion";
            this.Direccion_Trainer.Name = "Direccion_Trainer";
            this.Direccion_Trainer.ReadOnly = true;
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
            // Telf_Trainer
            // 
            this.Telf_Trainer.DataPropertyName = "Telf_Trainer";
            this.Telf_Trainer.HeaderText = "Telefono";
            this.Telf_Trainer.Name = "Telf_Trainer";
            this.Telf_Trainer.ReadOnly = true;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Sexo";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            // 
            // Fecha_Nacimiento
            // 
            this.Fecha_Nacimiento.DataPropertyName = "Fecha_Nacimiento";
            this.Fecha_Nacimiento.HeaderText = "Fecha de Nacimiento";
            this.Fecha_Nacimiento.Name = "Fecha_Nacimiento";
            this.Fecha_Nacimiento.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // lblRegistros
            // 
            this.lblRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRegistros.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistros.Location = new System.Drawing.Point(99, 438);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(72, 20);
            this.lblRegistros.TabIndex = 24;
            this.lblRegistros.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblRegistros.Click += new System.EventHandler(this.lblRegistros_Click);
            // 
            // NombreFiltro
            // 
            this.NombreFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NombreFiltro.Location = new System.Drawing.Point(180, 31);
            this.NombreFiltro.Name = "NombreFiltro";
            this.NombreFiltro.Size = new System.Drawing.Size(655, 20);
            this.NombreFiltro.TabIndex = 23;
            this.NombreFiltro.TextChanged += new System.EventHandler(this.NombreFiltro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ingrese el Apellido del Trainer :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Resultados :";
            // 
            // TrainerMan01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 473);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActulizar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.dtgTrainer);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.NombreFiltro);
            this.Controls.Add(this.label1);
            this.Name = "TrainerMan01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrainerMan01";
            this.Load += new System.EventHandler(this.TrainerMan01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTrainer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnActulizar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.DataGridView dtgTrainer;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.TextBox NombreFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Trainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni_Trainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Trainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos_Trainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Talla_Trainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion_Trainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telf_Trainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}