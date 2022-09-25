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
    public partial class SedeMan01 : Form
    {
        SedeBL objSedeBL = new SedeBL();
        DataView dtv; // Para el filtro 
        public SedeMan01()
        {
            InitializeComponent();
        }

        public void CargarDatos(String strFiltro)
        {

            dtv.RowFilter = "Id_Sede like '%" + strFiltro + "%'";
            dtgSede.DataSource = dtv;
            lblRegistros.Text = dtgSede.Rows.Count.ToString();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                SedeMan02 obj02 = new SedeMan02();
                obj02.ShowDialog();

                // Refrescar...
                dtv = objSedeBL.ListarSede().DefaultView;
                CargarDatos(NombreFiltro.Text.Trim());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

        }

        private void btnActulizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtenemos el codigo del proveedor que se va actualizar....
                String strId = dtgSede.CurrentRow.Cells[0].Value.ToString();

                SedeMan03 obj03 = new SedeMan03();
                obj03.IdSede = strId;
                obj03.ShowDialog();

                dtv = objSedeBL.ListarSede().DefaultView;
                CargarDatos(NombreFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SedeMan01_Load(object sender, EventArgs e)
        {
            try
            {
                dtgSede.AutoGenerateColumns = false;

                dtv = objSedeBL.ListarSede().DefaultView;
                CargarDatos(String.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void NombreFiltro_TextChanged(object sender, EventArgs e)
        {
            CargarDatos(NombreFiltro.Text.Trim());
        }

        private void dtgSede_DoubleClick(object sender, EventArgs e)
        {
            btnActulizar.PerformClick();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblRegistros_Click(object sender, EventArgs e)
        {

        }
    }
}
