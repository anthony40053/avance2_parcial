using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyGYM_BL;
using System.Data;

namespace ProyGYM_SER_WEB.Consultas
{
    public partial class ConsultaRecepciones : System.Web.UI.Page
    {
        AsistenciaBL objAsistenciaBL = new AsistenciaBL();
        ClienteBL objClienteBL = new ClienteBL();
        RecepcionistaBL objRecepcionistaBL = new RecepcionistaBL();
        // Variable paginacion....
        String strText;
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                if (Page.IsPostBack == false)
                {

                    LlenarCombos();

                    //Llenamos la grilla, llamando al metodo con el flag en falso
                    Filtrar(false);

                }

            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }

        }

        private void LlenarCombos()
        {

            // Creamos un nuevo item de cliente
            DataTable dtCombos = new DataTable();
            DataRow drFila;

            // Llenamos la tabla de clientes
            dtCombos = objClienteBL.ListarCliente();
            // Creamos un nuevo item de cliente ....
            drFila = dtCombos.NewRow();
            drFila["Id_Cliente"] = "X";
            drFila["nomApe"] = "--Todos--";
            // Lo insertamos a la tabla de clientes en la posicion 0
            dtCombos.Rows.InsertAt(drFila, 0);
            // Enlazamos la lista al combo de clientes...
            cboCliente.DataSource = dtCombos;
            cboCliente.DataTextField = "nomApe";
            cboCliente.DataValueField = "Id_Cliente";
            cboCliente.DataBind();

            // Ahora lo mismo pero con el combo de vendedores....
            dtCombos = objRecepcionistaBL.ListarRecepcionista();
            drFila = dtCombos.NewRow();
            drFila["Id_Recep"] = "X";
            drFila["nomApe"] = "--Todos--";
            dtCombos.Rows.InsertAt(drFila, 0);
            cboRecepcionista.DataSource = dtCombos;
            cboRecepcionista.DataTextField = "nomApe";
            cboRecepcionista.DataValueField = "Id_Recep";
            cboRecepcionista.DataBind();
           
        }

        private void Filtrar(Boolean blnFlag)
        {
            Int16 pagina = 0;
            String estado;
            String codcli;
            String codven;

            // Tamaño de pagina : 50
            Int16 intsize = 50;
            Int16 intnumpag;

            // Configuramos los parametros ....
            if (cboCliente.SelectedValue == "X") // si eligio Todos
            {
                codcli = "";

            }
            else
            {
                codcli = cboCliente.SelectedValue;
            }

            if (cboRecepcionista.SelectedValue == "X") // si eligio todos
            {
                codven = "";
            }
            else
            {
                codven = cboRecepcionista.SelectedValue;
            }

            if (cboEstado.SelectedValue == "X") // si eligio todos
            {
                estado = "";
            }
            else
            {
                estado = cboEstado.SelectedValue;
            }

            // Si el flag este en verdadero es porque selecciono un numero de pagina del combo de paginas...
            if (blnFlag == true)
            {
                //Se obtiene el nro de pagina desde el dropdown menos 1

                strText = cboPaginas.SelectedItem.ToString();
                pagina = Convert.ToInt16(strText);
                pagina = Convert.ToInt16(pagina - 1);


            }
            else // caso contrario sera siempre la primera pagina
            {
                pagina = 0;

            }

            // Si el combo de paginas esta aun vacio , se carga todo sin filtros, obteniendo los primeros 50
            if (cboPaginas.Items.Count == 0)
            {
                grvAsistencia.DataSource = objAsistenciaBL.usp_ListarClientes_Paginacion("", "", "", 0);

            }
            else // caso contrario ya se genero un filtro, por eso se le pasan las variables del filtro al metodo
            {
                grvAsistencia.DataSource = objAsistenciaBL.usp_ListarClientes_Paginacion(codcli, codven, estado, pagina);

            }
            grvAsistencia.DataBind();

            // Obtenemos la cantidad de paginas...

            Int16 intNumReg;
            intNumReg = objAsistenciaBL.usp_NumPag_ListarClientes_Paginacion(codcli, codven, estado);


            //Se carga el numero de paginas
            String strValue = cboPaginas.Text;
            cboPaginas.Items.Clear();

            if (intNumReg == 0)
            {
                cboPaginas.Items.Add("0");
                cboPaginas.SelectedIndex = 0;

            }
            else
            {

                if (intNumReg % intsize == 0)
                {
                    intnumpag = Convert.ToInt16(intNumReg / intsize);

                }
                else
                {
                    intnumpag = Convert.ToInt16((intNumReg / intsize) + 1);
                }
                for (int indice = 1; indice <= intnumpag; indice = indice + 1)
                {
                    cboPaginas.Items.Add(indice.ToString());
                }

            }

            if (blnFlag == true)
            {
                cboPaginas.Text = strValue;
            }

        }

            protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                Filtrar(false);
            }
            catch (Exception ex)
            {

                lblMensaje.Text = ex.Message;
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void cboPaginas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cuando hay paginas se llama al metodo con el flag en verdadero
            Filtrar(true);
        }
    }
}