using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Agregar...
using ProyGYM_BE;
using ProyGYM_BL;

namespace ProyGYM_GUI
{
    public partial class TrainerMan03 : Form
    {
        TrainerBL objTrainerBL = new TrainerBL();
        TrainerBE objTrainerBE = new TrainerBE();
        String stSexto;
        public TrainerMan03()
        {
            InitializeComponent();
        }

        private String _IdTrainer;

        public String IdTrainer
        {
            get { return _IdTrainer; }
            set { _IdTrainer = value; }

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

            objTrainerBE.Id_trainer = lblId.Text.ToString();
            objTrainerBE.Dni_trainer = mskDNI.Text.ToString();
            objTrainerBE.Nombre_trainer = txbNombre.Text.ToString();
            objTrainerBE.Apellido_trainer = txbApellidos.Text.ToString();
            objTrainerBE.Foto_trainer = "";
            objTrainerBE.Talla_trainer = Convert.ToInt16(txbTalla.Text);
            objTrainerBE.Direccion_trainer = txbDireccion.Text.ToString();
            objTrainerBE.Id_ubigeo = cbxDepartamento.SelectedValue.ToString() +
                cbxProvincia.SelectedValue.ToString() + cbxDistrito.SelectedValue.ToString();
            objTrainerBE.Correo_trainer = txbCorreo.Text.ToString();
            objTrainerBE.Telf_trainer = mskTelefono.Text.ToString();
            objTrainerBE.Sexo_trainer = stSexto.ToString();
            objTrainerBE.Fecha_Nacimiento = dtpFecha.Value;
            objTrainerBE.Usu_ult_mod = clsCredenciales.Usuario;
            objTrainerBE.Estado_trainer = Convert.ToInt16(chkActivo.Checked);

            if (objTrainerBL.ActualizarTrainer(objTrainerBE) == true)
            {
                this.Close();
            }
            else
            {
                throw new Exception("No se inserto registro. Contacte con IT.");
            }
        }

        private void TrainerMan03_Load(object sender, EventArgs e)
        {
            try
            {
                // Codifique...
                //pasarle el codigo al metodo y que me devuelva toda la informacion

                //Mostramos los datos del proveedor que se desea actualizar...
                objTrainerBE = objTrainerBL.ConsultarTrainer(this.IdTrainer);
                //pintar los datos
                lblId.Text = objTrainerBE.Id_trainer;
                mskDNI.Text = objTrainerBE.Dni_trainer;
                txbNombre.Text = objTrainerBE.Nombre_trainer;
                txbApellidos.Text = objTrainerBE.Apellido_trainer;
                txbTalla.Text = objTrainerBE.Talla_trainer.ToString();
                txbDireccion.Text = objTrainerBE.Direccion_trainer.ToString();
                String id_Ubigeo = objTrainerBE.Id_ubigeo;
                CargarUbigeo(id_Ubigeo.Substring(0, 2), id_Ubigeo.Substring(2, 2),
                    id_Ubigeo.Substring(4, 2));
                mskTelefono.Text = objTrainerBE.Telf_trainer;
                dtpFecha.Value = objTrainerBE.Fecha_Nacimiento.Date;
                txbCorreo.Text = objTrainerBE.Correo_trainer;
                chkActivo.Checked = Convert.ToBoolean(objTrainerBE.Estado_trainer);

                String st_sexo = objTrainerBE.Sexo_trainer;
                if (st_sexo.Equals("Femenino"))
                {
                    optFemenino.Checked = true;
                }

                else if (st_sexo.Equals("Masculino"))
                {
                    optMasculino.Checked = true;
                }
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
