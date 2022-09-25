using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using ProyGYM_BE;
using ProyGYM_BL;

namespace ProyGYM_SER_WEB.Consultas
{
    public partial class ConsultaTrainer : System.Web.UI.Page
    {
        Int16 estado;
        AsistenciaBL objAsistenciaBL = new AsistenciaBL();
        TrainerBE objTrainerBE = new TrainerBE();
        TrainerBL objTrainerBL = new TrainerBL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            // Codificamos la bosqueda del objeto Cliente
            objTrainerBE = objTrainerBL.ConsultarTrainer(txtId.Text.Trim());
            try
            {
                if (objTrainerBE.Dni_trainer == null)
                {
                    lblDNI.Text = "";
                    lblNombre.Text = "";
                    lblApellido.Text = "";
                    lblTalla.Text = "";
                    lblDireccion.Text = "";
                    lblUbicacion.Text = "";
                    lblCorreo.Text = "";
                    lblTelefono.Text = "";
                    lblEstado.Text = "";

                    
                    lblMensaje.Text = "Error Trainer no existe";
                    mpMensaje.Show();
                }

                else
                {
                    lblDNI.Text = objTrainerBE.Dni_trainer;
                    lblNombre.Text = objTrainerBE.Nombre_trainer;
                    lblApellido.Text = objTrainerBE.Apellido_trainer;
                    lblTalla.Text = objTrainerBE.Talla_trainer.ToString();
                    lblDireccion.Text = objTrainerBE.Direccion_trainer;
                    lblUbicacion.Text = objTrainerBE.Departamento + "-" + objTrainerBE.Provincia + "-" + objTrainerBE.Distrito;
                    lblCorreo.Text = objTrainerBE.Correo_trainer;
                    lblTelefono.Text = objTrainerBE.Telf_trainer;
                    estado = objTrainerBE.Estado_trainer;
                    if (estado == 1)
                    {
                        lblEstado.Text = "Activo";
                    }
                    else
                    {
                        lblEstado.Text = "Inactivo";
                    }



                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
                mpMensaje.Show();
            }
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tabla = objAsistenciaBL.usp_ListarTrainersAsistenciaFechas(txtId.Text.Trim()
                    , Convert.ToDateTime(dtgInicio.Text.Trim()), Convert.ToDateTime(dtgFin.Text.Trim()));
                dtgAsistenciaTrainer.DataSource = tabla;
                dtgAsistenciaTrainer.DataBind();
                lblMensaje.Text = "lista cargada";

            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
                mpMensaje.Show();
            }
        }

        private void CargarDatos()
        {
            DataTable tabla = objAsistenciaBL.usp_ListarTrainersAsistenciaFechas(txtId.Text.Trim()
                    , Convert.ToDateTime(dtgInicio.Text.Trim()), Convert.ToDateTime(dtgFin.Text.Trim()));
            dtgAsistenciaTrainer.DataSource = tabla;
            dtgAsistenciaTrainer.DataBind();

            
        }

        protected void dtgAsistenciaTrainer_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            
        }

        protected void dtgAsistenciaTrainer_PageIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void dtgAsistenciaTrainer_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dtgAsistenciaTrainer.PageIndex = e.NewPageIndex;
            CargarDatos();
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}