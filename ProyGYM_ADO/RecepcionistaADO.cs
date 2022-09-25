using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ProyGYM_BE;

namespace ProyGYM_ADO
{
    public class RecepcionistaADO
    {
        // Insumos..... 
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarRecepcionista()
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarRecepcionista";
            cmd.Parameters.Clear();
            try
            {
                //Codifique
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Recepcionistas");

                return dts.Tables["Recepcionistas"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
