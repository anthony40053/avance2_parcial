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
    public partial class SedeMan02 : Form
    {
        SedeBE objSedeBE = new SedeBE();
        SedeBL objSedeBL = new SedeBL();

        int stEstado;

        public SedeMan02()
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


                
                if (optInactivo.Checked == true)
                {
                    stEstado = 2;
                }

                else if (optActivo.Checked == true)
                {
                    stEstado = 1;
                }

                else
                {
                    stEstado = 3;
                }

      
                objSedeBE.Dir_Sede = txbDireccion.Text.ToString();
                objSedeBE.Des_Sede = txbDescripcion.Text.ToString();
                objSedeBE.Id_ubigeo = cbxDepartamento.SelectedValue.ToString() +
                    cbxProvincia.SelectedValue.ToString() + cbxDistrito.SelectedValue.ToString();
           
                objSedeBE.Usu_registro = clsCredenciales.Usuario;
                objSedeBE.Estado_Sede = Convert.ToInt16(stEstado);



                if (objSedeBL.InsertarSede(objSedeBE) == true)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SedeMan02_Load(object sender, EventArgs e)
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

        private void cbxDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cbxDepartamento.SelectedValue.ToString(), "01", "01");
        }

        private void cbxProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cbxDepartamento.SelectedValue.ToString(), cbxProvincia.SelectedValue.ToString(), "01");
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
