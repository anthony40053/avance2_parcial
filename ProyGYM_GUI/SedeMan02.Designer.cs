
namespace ProyGYM_GUI
{
    partial class SedeMan02
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
            this.grpDatos1 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optConstruccion = new System.Windows.Forms.RadioButton();
            this.optActivo = new System.Windows.Forms.RadioButton();
            this.optInactivo = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.cbxDistrito = new System.Windows.Forms.ComboBox();
            this.cbxProvincia = new System.Windows.Forms.ComboBox();
            this.cbxDepartamento = new System.Windows.Forms.ComboBox();
            this.txbDireccion = new System.Windows.Forms.TextBox();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpDatos1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatos1
            // 
            this.grpDatos1.Controls.Add(this.groupBox1);
            this.grpDatos1.Controls.Add(this.btnCancelar);
            this.grpDatos1.Controls.Add(this.btnGrabar);
            this.grpDatos1.Controls.Add(this.cbxDistrito);
            this.grpDatos1.Controls.Add(this.cbxProvincia);
            this.grpDatos1.Controls.Add(this.cbxDepartamento);
            this.grpDatos1.Controls.Add(this.txbDireccion);
            this.grpDatos1.Controls.Add(this.txbDescripcion);
            this.grpDatos1.Controls.Add(this.label8);
            this.grpDatos1.Controls.Add(this.label7);
            this.grpDatos1.Controls.Add(this.label6);
            this.grpDatos1.Controls.Add(this.label5);
            this.grpDatos1.Controls.Add(this.label2);
            this.grpDatos1.Location = new System.Drawing.Point(12, 12);
            this.grpDatos1.Name = "grpDatos1";
            this.grpDatos1.Size = new System.Drawing.Size(345, 356);
            this.grpDatos1.TabIndex = 2;
            this.grpDatos1.TabStop = false;
            this.grpDatos1.Text = "Ingrese sus Datos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optConstruccion);
            this.groupBox1.Controls.Add(this.optActivo);
            this.groupBox1.Controls.Add(this.optInactivo);
            this.groupBox1.Location = new System.Drawing.Point(10, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 57);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado";
            // 
            // optConstruccion
            // 
            this.optConstruccion.AutoSize = true;
            this.optConstruccion.Location = new System.Drawing.Point(228, 20);
            this.optConstruccion.Name = "optConstruccion";
            this.optConstruccion.Size = new System.Drawing.Size(86, 17);
            this.optConstruccion.TabIndex = 2;
            this.optConstruccion.TabStop = true;
            this.optConstruccion.Text = "construccion";
            this.optConstruccion.UseVisualStyleBackColor = true;
            // 
            // optActivo
            // 
            this.optActivo.AutoSize = true;
            this.optActivo.Location = new System.Drawing.Point(118, 20);
            this.optActivo.Name = "optActivo";
            this.optActivo.Size = new System.Drawing.Size(57, 17);
            this.optActivo.TabIndex = 1;
            this.optActivo.TabStop = true;
            this.optActivo.Text = "abierto";
            this.optActivo.UseVisualStyleBackColor = true;
            // 
            // optInactivo
            // 
            this.optInactivo.AutoSize = true;
            this.optInactivo.Location = new System.Drawing.Point(7, 20);
            this.optInactivo.Name = "optInactivo";
            this.optInactivo.Size = new System.Drawing.Size(61, 17);
            this.optInactivo.TabIndex = 0;
            this.optInactivo.TabStop = true;
            this.optInactivo.Text = "cerrado";
            this.optInactivo.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(262, 297);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(181, 297);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 6;
            this.btnGrabar.Text = "grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // cbxDistrito
            // 
            this.cbxDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDistrito.FormattingEnabled = true;
            this.cbxDistrito.Location = new System.Drawing.Point(128, 147);
            this.cbxDistrito.Name = "cbxDistrito";
            this.cbxDistrito.Size = new System.Drawing.Size(209, 21);
            this.cbxDistrito.TabIndex = 4;
            // 
            // cbxProvincia
            // 
            this.cbxProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProvincia.FormattingEnabled = true;
            this.cbxProvincia.Location = new System.Drawing.Point(128, 117);
            this.cbxProvincia.Name = "cbxProvincia";
            this.cbxProvincia.Size = new System.Drawing.Size(209, 21);
            this.cbxProvincia.TabIndex = 3;
            this.cbxProvincia.SelectionChangeCommitted += new System.EventHandler(this.cbxProvincia_SelectionChangeCommitted);
            // 
            // cbxDepartamento
            // 
            this.cbxDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDepartamento.FormattingEnabled = true;
            this.cbxDepartamento.Location = new System.Drawing.Point(128, 87);
            this.cbxDepartamento.Name = "cbxDepartamento";
            this.cbxDepartamento.Size = new System.Drawing.Size(209, 21);
            this.cbxDepartamento.TabIndex = 2;
            this.cbxDepartamento.SelectionChangeCommitted += new System.EventHandler(this.cbxDepartamento_SelectionChangeCommitted);
            // 
            // txbDireccion
            // 
            this.txbDireccion.Location = new System.Drawing.Point(128, 27);
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(209, 20);
            this.txbDireccion.TabIndex = 0;
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Location = new System.Drawing.Point(128, 53);
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(209, 20);
            this.txbDescripcion.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Distrito  :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Provincia  :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Departamento  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Direccion  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descripcion  :";
            // 
            // SedeMan02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 379);
            this.Controls.Add(this.grpDatos1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SedeMan02";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insertar Sede";
            this.Load += new System.EventHandler(this.SedeMan02_Load);
            this.grpDatos1.ResumeLayout(false);
            this.grpDatos1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatos1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.ComboBox cbxDistrito;
        private System.Windows.Forms.ComboBox cbxProvincia;
        private System.Windows.Forms.ComboBox cbxDepartamento;
        private System.Windows.Forms.TextBox txbDireccion;
        private System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optConstruccion;
        private System.Windows.Forms.RadioButton optActivo;
        private System.Windows.Forms.RadioButton optInactivo;
    }
}