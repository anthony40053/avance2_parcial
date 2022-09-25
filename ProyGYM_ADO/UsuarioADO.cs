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
    public class UsuarioADO
    {
        // Insumos..... 
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;


        public UsuarioBE ConsultarUsuario(String strLog)
        {
            UsuarioBE objUsuarioBE = new UsuarioBE();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ConsultarUsuario";
            cmd.Parameters.Clear();
            try
            {
                //Codifique
                cmd.Parameters.AddWithValue("@Login_Usuario", strLog);

                // Abrimos la conexion y ejecutamos...
                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objUsuarioBE.Login_Usuario = dtr["Login_Usuario"].ToString();
                    objUsuarioBE.Pass_Usuario = dtr["Pass_Usuario"].ToString();
                    objUsuarioBE.Est_Usuario = Convert.ToInt16(dtr["Est_Usuario"]);
                    objUsuarioBE.Fec_Registro = Convert.ToDateTime(dtr["Fec_Registro"]);
                }
                dtr.Close();
                return objUsuarioBE;

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }

        }
    }
}
