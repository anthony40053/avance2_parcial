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
    public partial class TrainerMan02 : Form
    {
        TrainerBE objTrainerBE = new TrainerBE();
        TrainerBL objTrainerBL = new TrainerBL();

        String stSexto;

        public TrainerMan02()
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

                objTrainerBE.Id_trainer = "";
                objTrainerBE.Dni_trainer = mskDNI.Text.ToString();
                objTrainerBE.Nombre_trainer = txbNombre.Text.ToString();
                objTrainerBE.Apellido_trainer = txtApellidos.Text.ToString();
                objTrainerBE.Foto_trainer = "";
                objTrainerBE.Talla_trainer = Convert.ToInt16(txbTalla.Text);
                objTrainerBE.Direccion_trainer = txbDireccion.Text.ToString();
                objTrainerBE.Id_ubigeo = cbxDepartamento.SelectedValue.ToString() +
                    cbxProvincia.SelectedValue.ToString() + cbxDistrito.SelectedValue.ToString();
                objTrainerBE.Correo_trainer = txbCorreo.Text.ToString();
                objTrainerBE.Telf_trainer = mskTelefono.Text.ToString();
                objTrainerBE.Sexo_trainer = stSexto.ToString();
                objTrainerBE.Fecha_Nacimiento = dtpFecha.Value;
                objTrainerBE.Usu_registro = clsCredenciales.Usuario;
                objTrainerBE.Estado_trainer = Convert.ToInt16(chkActivo.Checked);



                if (objTrainerBL.InsertarTrainer(objTrainerBE) == true)
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

        private void cbxDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
           CargarUbigeo(cbxDepartamento.SelectedValue.ToString(), "01", "01");
        }

        private void cbxProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cbxDepartamento.SelectedValue.ToString(), cbxProvincia.SelectedValue.ToString(), "01");
        }

        private void TrainerMan02_Load(object sender, EventArgs e)
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

        private void btnCargar_Click(object sender, EventArgs e)
        {
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
