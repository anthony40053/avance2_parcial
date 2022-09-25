using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyGYM_GUI
{
    public partial class MDIPrincipal : Form
    {
        SedeMan01 sede01;
        ClienteMan01 cli01;
        TrainerMan01 trai01;

        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void MDIPrincipal_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }

        void CuandoSeCierreSede(Object sender , EventArgs e)
        {
            sede01 = null;
        }
        void CuandoSeCierreCliente(Object sender, EventArgs e)
        {
            cli01 = null;
        }
        void CuandoSeCierreTrainer(Object sender, EventArgs e)
        {
            trai01 = null;
        }


        private void sedeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sede01 == null)
            {
                sede01 = new SedeMan01();
                sede01.MdiParent = this;
                sede01.FormClosed += new FormClosedEventHandler(CuandoSeCierreSede);
                sede01.Show();
            }
            
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cli01 == null)
            {
                cli01 = new ClienteMan01();
                cli01.MdiParent = this;
                cli01.FormClosed += new FormClosedEventHandler(CuandoSeCierreCliente);
                cli01.Show();
            }
        }

        private void trainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(trai01 == null)
            {
                trai01 = new TrainerMan01();
                trai01.MdiParent = this;
                trai01.FormClosed += new FormClosedEventHandler(CuandoSeCierreTrainer);
                trai01.Show();
            }
        }

        private void salidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mantenimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            //mostrar el usuario
            lblUsuario.Text = "Usuario :" + clsCredenciales.Usuario;
        }

        private void MDIPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult vrpta;
            vrpta = MessageBox.Show("Seguro de salir del aplicativo?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vrpta == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void MDIPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
