using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Using...
using ProyGYM_BE;
using ProyGYM_BL;

namespace ProyGYM_GUI
{
    public partial class FrmLogin : Form
    {
        // Declaramos variableas de intentos y tiempo....
        Int16 intentos = 0;
        Int16 tiempo = 30;

        UsuarioBE objUsuarioBE = new UsuarioBE();
        UsuarioBL objUsuarioBL = new UsuarioBL();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() != "" & txtPassword.Text.Trim() != "")
            {
                // Codifique...
                //consultamos usuario 
                objUsuarioBE = objUsuarioBL.ConsultarUsuario(txtLogin.Text);
                if (objUsuarioBE.Login_Usuario == null) // si el usuario no existe
                {
                    MessageBox.Show("Usuario no Existe",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intentos += 1;
                    ValidaAccesos();
                }

                if (txtLogin.Text.Trim() == objUsuarioBE.Login_Usuario & txtPassword.Text.Trim() == objUsuarioBE.Pass_Usuario)
                {
                    // credenciales corectas
                    this.Hide();
                    timer1.Enabled = false;

                    //Registramos las credenciales
                    clsCredenciales.Usuario = objUsuarioBE.Login_Usuario;
                    clsCredenciales.Password = objUsuarioBE.Pass_Usuario;

                    //Lanzamos el MDI
                    MDIPrincipal objMDI = new MDIPrincipal();
                    objMDI.ShowDialog();
                }



                else
                {
                    MessageBox.Show("Usuario o Password incorrectos",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intentos += 1;
                    ValidaAccesos();

                }
            }
            else
            {
                MessageBox.Show("Usuario o Password obligatorios",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                intentos += 1;
                ValidaAccesos();
            }
        }

        private void ValidaAccesos()
        {
            if (intentos == 3)
            {
                MessageBox.Show("Lo sentimos,  sobrepaso el numero de intentos",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempo -= 1;
            this.Text = "Ingrese su login y contraseña. Le quedan...." + tiempo;
            if (tiempo == 0)
            {
                MessageBox.Show("Lo sentimos, sobrepaso el tiempo de espera",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Application.Exit();
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Enabled = false;
            Application.Exit();
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            // Para al pulsar Enter acceder al MDI...
            if (e.KeyCode == Keys.Enter)
            {
                btnIngresar.PerformClick();
            }
        }
    }
}
