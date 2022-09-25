using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using ProyGYM_BE;
using ProyGYM_BL;

namespace ProyGYM_ConsultasWEB.Consultas
{
    public partial class ConsultaCliente : System.Web.UI.Page
    {
        Int16 estado;
        AsistenciaBL objAsistenciaBL = new AsistenciaBL();
        ClienteBL objClienteBL = new ClienteBL();
        ClienteBE objClienteBE = new ClienteBE();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tabla = objAsistenciaBL.usp_ListarClientesAsistenciaFechas(txtId.Text.Trim()
                    , Convert.ToDateTime(dtgInicio.Text.Trim()), Convert.ToDateTime(dtgFin.Text.Trim()));
                dtgAsistencia.DataSource = tabla;
                dtgAsistencia.DataBind();
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
            DataTable tabla = objAsistenciaBL.usp_ListarClientesAsistenciaFechas(txtId.Text.Trim()
                    , Convert.ToDateTime(dtgInicio.Text.Trim()), Convert.ToDateTime(dtgFin.Text.Trim()));
            dtgAsistencia.DataSource = tabla;
            dtgAsistencia.DataBind();


        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                // Codificamos la bosqueda del objeto Cliente
                objClienteBE = objClienteBL.ConsultarCliente(txtId.Text.Trim());
                if (objClienteBE.Dni_cliente == null)
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


                    lblMensaje.Text = "Error Cliente no existe";
                    mpMensaje.Show();
                }

                else
                {
                    lblDNI.Text = objClienteBE.Dni_cliente;
                    lblNombre.Text = objClienteBE.Nombre_cliente;
                    lblApellido.Text = objClienteBE.Apellido_cliente;
                    lblTalla.Text = objClienteBE.Talla_cliente.ToString();
                    lblDireccion.Text = objClienteBE.Direccion_cliente;
                    lblUbicacion.Text = objClienteBE.Departamento + "-" + objClienteBE.Provincia + "-" + objClienteBE.Distrito;
                    lblCorreo.Text = objClienteBE.Correo_cliente;
                    lblTelefono.Text = objClienteBE.Telf_cliente;
                    estado = objClienteBE.Estado_cliente;
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

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void dtgAsistencia_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dtgAsistencia.PageIndex = e.NewPageIndex;
            CargarDatos();
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}