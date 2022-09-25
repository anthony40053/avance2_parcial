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
    public partial class SedeMan03 : Form
    {
        SedeBL objSedeBL = new SedeBL();
        SedeBE objSedeBE = new SedeBE();
        int stEstado;
        public SedeMan03()
        {
            InitializeComponent();
        }

        private String _IdSede;

        public String IdSede
        {
            get { return _IdSede; }
            set { _IdSede = value; }

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

        private void SedeMan03_Load(object sender, EventArgs e)
        {
            try
            {
                // Codifique...
                //pasarle el codigo al metodo y que me devuelva toda la informacion

                //Mostramos los datos del proveedor que se desea actualizar...
                objSedeBE = objSedeBL.ConsultarSede(this.IdSede);
                //pintar los datos
                lblID.Text = objSedeBE.Id_Sede;
                txbDireccion.Text = objSedeBE.Dir_Sede.ToString();
                txbDescripcion.Text = objSedeBE.Des_Sede.ToString();
                String id_Ubigeo = objSedeBE.Id_ubigeo;
                CargarUbigeo(id_Ubigeo.Substring(0, 2), id_Ubigeo.Substring(2, 2),
                    id_Ubigeo.Substring(4, 2));
                

                stEstado = objSedeBE.Estado_Sede;
                if (stEstado == 1)
                {
                    optInactivo.Checked = true;
                }

                else if (stEstado == 2)
                {
                    optActivo.Checked = true;
                }
                else
                {
                    optConstruccion.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

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

                objSedeBE.Id_Sede = lblID.Text.ToString();
                objSedeBE.Dir_Sede = txbDireccion.Text.ToString();
                objSedeBE.Des_Sede = txbDescripcion.Text.ToString();
                objSedeBE.Id_ubigeo = cbxDepartamento.SelectedValue.ToString() +
                    cbxProvincia.SelectedValue.ToString() + cbxDistrito.SelectedValue.ToString();
                objSedeBE.Usu_ult_mod = clsCredenciales.Usuario;
                objSedeBE.Estado_Sede = Convert.ToInt16(stEstado);



                if (objSedeBL.ActualizarSede(objSedeBE) == true)
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
    }
}
