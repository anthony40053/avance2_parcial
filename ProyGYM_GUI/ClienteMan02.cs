using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Agregamos
using ProyGYM_BE;
using ProyGYM_BL;

namespace ProyGYM_GUI
{
    public partial class ClienteMan02 : Form
    {
        ClienteBE objClienteBE = new ClienteBE();
        ClienteBL objClienteBL = new ClienteBL();
        
        String stSexto;

        public ClienteMan02()
        {
            InitializeComponent();
        }
        private void CargarUbigeo(String IdDepa, String IdProv, String IdDist)
        {
            UbigeoBL objUbigeoBL = new UbigeoBL();

            cbxDepartamento.DataSource = objUbigeoBL.Ubigeo_Departamentos();
            cbxDepartamento.ValueMember = "IdDepa";
            cbxDepartamento.DisplayMember = "Departamento";
            cbxDepartamento.SelectedValue = IdDepa;

            cbxProvincia.DataSource = objUbigeoBL.Ubigeo_ProvinciasDepartamento(IdDepa);
            cbxProvincia.ValueMember = "IdProv";
            cbxProvincia.DisplayMember = "Provincia";
            cbxProvincia.SelectedValue = IdProv;

            cbxDistrito.DataSource = objUbigeoBL.Ubigeo_DistritosProvinciaDepartamento(IdDepa, IdProv);
            cbxDistrito.ValueMember = "IdDist";
            cbxDistrito.DisplayMember = "Distrito";
            cbxDistrito.SelectedValue = IdDist;



        }

        private void ClienteMan02_Load(object sender, EventArgs e)
        {
            try
            {
                CargarUbigeo("14", "01", "01");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);

            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbxDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cbxDepartamento.SelectedValue.ToString(), "01", "01");
        }

        private void cbxProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cbxDepartamento.SelectedValue.ToString(), cbxProvincia.SelectedValue.ToString(), "01");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                

                if (mskDNI.MaskFull == false) // Si no llenaste la mascara
                {
                    throw new Exception("El DNI debe tener 8 caracteres");

                }
                if (optFemenino.Checked == true)
                {
                    stSexto = "F";
                }

                else if (optMasculino.Checked == true)
                {
                    stSexto = "M";
                }

                else
                {
                    stSexto = " ";
                }

                objClienteBE.Id_cliente = "";
                objClienteBE.Dni_cliente = mskDNI.Text.ToString();
                objClienteBE.Nombre_cliente = txbNombre.Text.ToString();
                objClienteBE.Apellido_cliente = txtApellidos.Text.ToString();
                objClienteBE.Foto_cliente = "";
                objClienteBE.Talla_cliente = Convert.ToInt16(txbTalla.Text);
                objClienteBE.Direccion_cliente = txbDireccion.Text.ToString();
                objClienteBE.Id_ubigeo = cbxDepartamento.SelectedValue.ToString() +
                    cbxProvincia.SelectedValue.ToString() + cbxDistrito.SelectedValue.ToString();
                objClienteBE.Correo_cliente = txbCorreo.Text.ToString();
                objClienteBE.Telf_cliente = mskTelefono.Text.ToString();
                objClienteBE.Sexo_cliente = stSexto.ToString();
                objClienteBE.Fecha_Nacimiento = dtpFecha.Value;
                objClienteBE.Usu_registro = clsCredenciales.Usuario;
                objClienteBE.Estado_cliente = Convert.ToInt16(chkActivo.Checked);

                

                if (objClienteBL.InsertarCliente(objClienteBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se inserto registro. Contacte con IT.");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }
        }

        private void optFemenino_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void optMasculino_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
        }
    }
}
