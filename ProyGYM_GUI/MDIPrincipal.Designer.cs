
namespace ProyGYM_GUI
{
    partial class MDIPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sedeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarTrainerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientosToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.salidaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sedeToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.trainerToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Image = global::ProyGYM_GUI.Properties.Resources.Display2;
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            this.mantenimientosToolStripMenuItem.Click += new System.EventHandler(this.mantenimientosToolStripMenuItem_Click);
            // 
            // sedeToolStripMenuItem
            // 
            this.sedeToolStripMenuItem.Image = global::ProyGYM_GUI.Properties.Resources.Home2;
            this.sedeToolStripMenuItem.Name = "sedeToolStripMenuItem";
            this.sedeToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.sedeToolStripMenuItem.Text = "Sede";
            this.sedeToolStripMenuItem.Click += new System.EventHandler(this.sedeToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Image = global::ProyGYM_GUI.Properties.Resources.user1;
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // trainerToolStripMenuItem
            // 
            this.trainerToolStripMenuItem.Image = global::ProyGYM_GUI.Properties.Resources.dude4;
            this.trainerToolStripMenuItem.Name = "trainerToolStripMenuItem";
            this.trainerToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.trainerToolStripMenuItem.Text = "Trainer";
            this.trainerToolStripMenuItem.Click += new System.EventHandler(this.trainerToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarClienteToolStripMenuItem,
            this.consultarTrainerToolStripMenuItem});
            this.consultarToolStripMenuItem.Image = global::ProyGYM_GUI.Properties.Resources.GuardarVarios;
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // consultarClienteToolStripMenuItem
            // 
            this.consultarClienteToolStripMenuItem.Image = global::ProyGYM_GUI.Properties.Resources.id_card;
            this.consultarClienteToolStripMenuItem.Name = "consultarClienteToolStripMenuItem";
            this.consultarClienteToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.consultarClienteToolStripMenuItem.Text = "Consultar Cliente";
            // 
            // consultarTrainerToolStripMenuItem
            // 
            this.consultarTrainerToolStripMenuItem.Image = global::ProyGYM_GUI.Properties.Resources.dude4;
            this.consultarTrainerToolStripMenuItem.Name = "consultarTrainerToolStripMenuItem";
            this.consultarTrainerToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.consultarTrainerToolStripMenuItem.Text = "Consultar Trainer";
            // 
            // salidaToolStripMenuItem
            // 
            this.salidaToolStripMenuItem.Image = global::ProyGYM_GUI.Properties.Resources.Cancelar;
            this.salidaToolStripMenuItem.Name = "salidaToolStripMenuItem";
            this.salidaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.salidaToolStripMenuItem.Text = "Salida";
            this.salidaToolStripMenuItem.Click += new System.EventHandler(this.salidaToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl1,
            this.lblUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl1.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(50, 17);
            this.lbl1.Text = "Usuario:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(19, 17);
            this.lblUsuario.Text = "....";
            // 
            // MDIPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyGYM_GUI.Properties.Resources.Fondo_de_Día_luminoso;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDIPrincipal";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MDIPrincipal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MDIPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.MDIPrincipal_Load);
            this.Resize += new System.EventHandler(this.MDIPrincipal_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sedeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarTrainerToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
    }
}