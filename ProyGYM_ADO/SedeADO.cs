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
    public class SedeADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;


        public Boolean InsertarSede(SedeBE objSedeBE)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_InsertarSede";
            cmd.Parameters.Clear();
            //Agregamos parametros 
            try
            {
                //Codifique
                cmd.Parameters.AddWithValue("@Dir_Sede", objSedeBE.Dir_Sede);
                cmd.Parameters.AddWithValue("@Des_Sede", objSedeBE.Des_Sede);
                cmd.Parameters.AddWithValue("@Id_Ubigeo", objSedeBE.Id_ubigeo);
                cmd.Parameters.AddWithValue("@Usu_Registro", objSedeBE.Usu_registro);
                cmd.Parameters.AddWithValue("@Estado_Sede", objSedeBE.Estado_Sede);
                // Abro la conexion y ejecutamos....
                cnx.Open();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }
        }

        public Boolean ActualizarSede(SedeBE objSedeBE)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ActualizarSede";
            cmd.Parameters.Clear();
            //Agregamos parametros 
            try
            {
                //Codifique
                cmd.Parameters.AddWithValue("@Id_Sede", objSedeBE.Id_Sede);
                cmd.Parameters.AddWithValue("@Dir_Sede", objSedeBE.Dir_Sede);
                cmd.Parameters.AddWithValue("@Des_Sede", objSedeBE.Des_Sede);
                cmd.Parameters.AddWithValue("@Id_Ubigeo", objSedeBE.Id_ubigeo);
                cmd.Parameters.AddWithValue("@Usu_Ult_Mod", objSedeBE.Usu_ult_mod);
                cmd.Parameters.AddWithValue("@Estado_Sede", objSedeBE.Estado_Sede);
                // Abro la conexion y ejecutamos....
                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;


            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }
        }

        public Boolean EliminarSede(String strid)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_EliminarSede";
            cmd.Parameters.Clear();
            //Agregamos parametros 
            try
            {
                //Codifique
                cmd.Parameters.AddWithValue("@Id_Sede", strid);

                //Abro la conexion y ejecuto...
                cnx.Open();
                cmd.ExecuteNonQuery();

                return true;


            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }

        public SedeBE ConsultarSede(String strid)
        {
            SedeBE objSedeBE = new SedeBE();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ConsultarSede";
            cmd.Parameters.Clear();
            try
            {
                //Codifique
                cmd.Parameters.AddWithValue("@Id_Sede", strid);

                // Abrimos la conexion y ejecutamos...
                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objSedeBE.Id_Sede = dtr["Id_Sede"].ToString();
                    objSedeBE.Dir_Sede = dtr["Dir_Sede"].ToString();
                    objSedeBE.Des_Sede = dtr["Des_Sede"].ToString();                
                    objSedeBE.Id_ubigeo = dtr["Id_Ubigeo"].ToString();
                    objSedeBE.Estado_Sede = Convert.ToInt16(dtr["Estado_Sede"]);

                }
                dtr.Close();
                return objSedeBE;

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

        public DataTable ListarSede()
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarSede";
            cmd.Parameters.Clear();
            try
            {
                //Codifique
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Sedes");

                return dts.Tables["Sedes"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
