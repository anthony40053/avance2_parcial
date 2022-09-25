using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//agregando
using ProyGYM_BL;


namespace ProyGYM_GUI
{
    public partial class ClienteMan01 : Form
    {
        ClienteBL objClienteBL = new ClienteBL();
        DataView dtv; // Para el filtro 

        public ClienteMan01()
        {
            InitializeComponent();
        }
        public void CargarDatos(String strFiltro)
        {

            dtv.RowFilter = "Apellidos_Cliente like '%" + strFiltro + "%'";
            dtgCliente.DataSource = dtv;
            lblRegistros.Text = dtgCliente.Rows.Count.ToString();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActulizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtenemos el codigo del proveedor que se va actualizar....
                String strId = dtgCliente.CurrentRow.Cells[0].Value.ToString();

                ClienteMan03 obj03 = new ClienteMan03();
                obj03.IdCliente = strId;
                obj03.ShowDialog();

                dtv = objClienteBL.ListarCliente().DefaultView;
                CargarDatos(NombreFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteMan02 obj02 = new ClienteMan02();
                obj02.ShowDialog();

                // Refrescar...
                dtv = objClienteBL.ListarCliente().DefaultView;
                CargarDatos(NombreFiltro.Text.Trim());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void dtgCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblRegistros_Click(object sender, EventArgs e)
        {

        }

        private void NombreFiltro_TextChanged(object sender, EventArgs e)
        {
            CargarDatos(NombreFiltro.Text.Trim());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ClienteMan01_Load(object sender, EventArgs e)
        {
            try
            {
                dtgCliente.AutoGenerateColumns = false;

                dtv = objClienteBL.ListarCliente().DefaultView;
                CargarDatos(String.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void dtgCliente_DoubleClick(object sender, EventArgs e)
        {
            btnActulizar.PerformClick();
        }
    }
}
