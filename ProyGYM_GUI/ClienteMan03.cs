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
    public partial class ClienteMan03 : Form
    {
        ClienteBL objClienteBL = new ClienteBL();
        ClienteBE objClienteBE = new ClienteBE();
        String stSexto;
        public ClienteMan03()
        {
            InitializeComponent();
        }


        private String _IdCliente;

        public String IdCliente
        {
            get { return _IdCliente; }
            set { _IdCliente = value; }

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

            objClienteBE.Id_cliente = lblId.Text.ToString();
            objClienteBE.Dni_cliente = mskDNI.Text.ToString();
            objClienteBE.Nombre_cliente = txbNombre.Text.ToString();
            objClienteBE.Apellido_cliente = txbApellidos.Text.ToString();
            objClienteBE.Foto_cliente = "";
            objClienteBE.Talla_cliente = Convert.ToInt16(txbTalla.Text);
            objClienteBE.Direccion_cliente = txbDireccion.Text.ToString();
            objClienteBE.Id_ubigeo = cbxDepartamento.SelectedValue.ToString() +
                cbxProvincia.SelectedValue.ToString() + cbxDistrito.SelectedValue.ToString();
            objClienteBE.Correo_cliente = txbCorreo.Text.ToString();
            objClienteBE.Telf_cliente = mskTelefono.Text.ToString();
            objClienteBE.Sexo_cliente = stSexto.ToString();
            objClienteBE.Fecha_Nacimiento = dtpFecha.Value;
            objClienteBE.Usu_ult_mod = clsCredenciales.Usuario;
            objClienteBE.Estado_cliente = Convert.ToInt16(chkActivo.Checked);

            if (objClienteBL.ActualizarCliente(objClienteBE) == true)
            {
                this.Close();
            }
            else
            {
                throw new Exception("No se inserto registro. Contacte con IT.");
            }
        }

        private void ClienteMan03_Load(object sender, EventArgs e)
        {
            try
            {
                // Codifique...
                //pasarle el codigo al metodo y que me devuelva toda la informacion

                //Mostramos los datos del proveedor que se desea actualizar...
                objClienteBE = objClienteBL.ConsultarCliente(this.IdCliente);
                //pintar los datos
                lblId.Text = objClienteBE.Id_cliente;
                mskDNI.Text = objClienteBE.Dni_cliente;
                txbNombre.Text = objClienteBE.Nombre_cliente;
                txbApellidos.Text = objClienteBE.Apellido_cliente;
                txbTalla.Text = objClienteBE.Talla_cliente.ToString();
                txbDireccion.Text = objClienteBE.Direccion_cliente.ToString();
                String id_Ubigeo = objClienteBE.Id_ubigeo;
                CargarUbigeo(id_Ubigeo.Substring(0, 2), id_Ubigeo.Substring(2, 2),
                    id_Ubigeo.Substring(4, 2));
                mskTelefono.Text = objClienteBE.Telf_cliente;
                dtpFecha.Value = objClienteBE.Fecha_Nacimiento.Date;
                txbCorreo.Text = objClienteBE.Correo_cliente;
                chkActivo.Checked = Convert.ToBoolean(objClienteBE.Estado_cliente);

                String st_sexo = objClienteBE.Sexo_cliente;
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
