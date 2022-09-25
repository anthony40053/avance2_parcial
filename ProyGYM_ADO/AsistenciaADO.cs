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
    public class AsistenciaADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        // Metodos 
        public DataTable usp_ListarClientesAsistenciaFechas(string strId, DateTime fecini, DateTime fecfin)
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarClientesAsistenciaFechas";
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@vId", strId);
            cmd.Parameters.AddWithValue("@fecini", fecini);
            cmd.Parameters.AddWithValue("@fecfin", fecfin);

            try
            {
                //Codifique
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "AsistenciasCliente");

                return dts.Tables["AsistenciasCliente"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable usp_ListarTrainersAsistenciaFechas(string strId, DateTime fecini, DateTime fecfin)
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarTrainerAsistenciaFechas";
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@vId", strId);
            cmd.Parameters.AddWithValue("@fecini", fecini);
            cmd.Parameters.AddWithValue("@fecfin", fecfin);
            try
            {
                //Codifique
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "AsistenciasTrainers");

                return dts.Tables["AsistenciasTrainers"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable usp_ListarClientes_Paginacion(string strId_cli, String strId_rec, String strEstado, Int16 intNumPag)
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarClientes_Paginacion";
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@Id_Cliente", strId_cli);
            cmd.Parameters.AddWithValue("@Id_Recep", strId_rec);
            cmd.Parameters.AddWithValue("@Estado", strEstado);
            cmd.Parameters.AddWithValue("@NumPag", intNumPag);

            try
            {
                //Codifique
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "ListarClientes_Paginacion");

                return dts.Tables["ListarClientes_Paginacion"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Int16 usp_NumPag_ListarClientes_Paginacion(string strId_cli, String strId_rec, String strEstado)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_NumPag_ListarClientes_Paginacion";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Id_Cliente", strId_cli);
                cmd.Parameters.AddWithValue("@Id_Recep", strId_rec);
                cmd.Parameters.AddWithValue("@Estado", strEstado);
                // Parametro de salida que devolvera la cantidad de registros de la consulta filtrada por
                // cliente, vendedor y estado
                cmd.Parameters.Add("@NUMREG", SqlDbType.Int);
                cmd.Parameters["@NUMREG"].Direction = ParameterDirection.Output;
                cnx.Open();
                cmd.ExecuteScalar();
                Int16 NumReg = Convert.ToInt16(cmd.Parameters["@NUMREG"].Value);
                return NumReg;

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable usp_ListarTrainers_Paginacion (string strId_tre, String strId_rec, String strEstado, Int16 intNumPag)
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarTrainers_Paginacion";
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@Id_Trainer", strId_tre);
            cmd.Parameters.AddWithValue("@Id_Recep", strId_rec);
            cmd.Parameters.AddWithValue("@Estado", strEstado);
            cmd.Parameters.AddWithValue("@NumPag", intNumPag);

            try
            {
                //Codifique
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "ListarTrainers_Paginacion");

                return dts.Tables["ListarTrainers_Paginacion"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Int16 usp_NumPag_ListarTrainers_Paginacion(string strId_tre, String strId_rec, String strEstado)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_NumPag_ListarTrainers_Paginacion";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Id_Trainer", strId_tre);
                cmd.Parameters.AddWithValue("@Id_Recep", strId_rec);
                cmd.Parameters.AddWithValue("@Estado", strEstado);
                // Parametro de salida que devolvera la cantidad de registros de la consulta filtrada por
                // cliente, vendedor y estado
                cmd.Parameters.Add("@NUMREG", SqlDbType.Int);
                cmd.Parameters["@NUMREG"].Direction = ParameterDirection.Output;
                cnx.Open();
                cmd.ExecuteScalar();
                Int16 NumReg = Convert.ToInt16(cmd.Parameters["@NUMREG"].Value);
                return NumReg;

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
