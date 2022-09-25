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
    public partial class TrainerMan01 : Form
    {
        TrainerBL objTrainerBL = new TrainerBL();
        DataView dtv; // Para el filtro
        public void CargarDatos(String strFiltro)
        {

            dtv.RowFilter = "Apellidos_Trainer like '%" + strFiltro + "%'";
            dtgTrainer.DataSource = dtv;
            lblRegistros.Text = dtgTrainer.Rows.Count.ToString();
        }

        public TrainerMan01()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                TrainerMan02 obj02 = new TrainerMan02();
                obj02.ShowDialog();

                // Refrescar...
                dtv = objTrainerBL.ListarTrainer().DefaultView;
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
                String strId = dtgTrainer.CurrentRow.Cells[0].Value.ToString();

                TrainerMan03 obj03 = new TrainerMan03();
                obj03.IdTrainer = strId;
                obj03.ShowDialog();

                dtv = objTrainerBL.ListarTrainer().DefaultView;
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

        private void TrainerMan01_Load(object sender, EventArgs e)
        {
            try
            {
                dtgTrainer.AutoGenerateColumns = false;
                dtv = objTrainerBL.ListarTrainer().DefaultView;
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

        private void dtgTrainer_DoubleClick(object sender, EventArgs e)
        {
            btnActulizar.PerformClick();
        }

        private void lblRegistros_Click(object sender, EventArgs e)
        {

        }
    }
}
