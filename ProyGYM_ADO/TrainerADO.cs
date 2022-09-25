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
    public class TrainerADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        // Metodos de mantenimiento

        public Boolean InsertarTrainer(TrainerBE objTrainerBE)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_InsertarTrainer";
            cmd.Parameters.Clear();
            //Agregamos parametros 
            try
            {
                //Codifique
                cmd.Parameters.AddWithValue("@vDni_Trainer", objTrainerBE.Dni_trainer);
                cmd.Parameters.AddWithValue("@vNombre_Trainer", objTrainerBE.Nombre_trainer);
                cmd.Parameters.AddWithValue("@vApellidos_Trainer", objTrainerBE.Apellido_trainer);
                cmd.Parameters.AddWithValue("@vFoto_Trainer", objTrainerBE.Foto_trainer);
                cmd.Parameters.AddWithValue("@vTalla_Trainer", objTrainerBE.Talla_trainer);
                cmd.Parameters.AddWithValue("@vDireccion_Trainer", objTrainerBE.Direccion_trainer);
                cmd.Parameters.AddWithValue("@vIdUbigeo", objTrainerBE.Id_ubigeo);
                cmd.Parameters.AddWithValue("@vCorreo_Trainer", objTrainerBE.Correo_trainer);
                cmd.Parameters.AddWithValue("@vTelf_Trainer", objTrainerBE.Telf_trainer);
                cmd.Parameters.AddWithValue("@vSexo_Trainer", objTrainerBE.Sexo_trainer);
                cmd.Parameters.AddWithValue("@vFecha_Nacimiento", objTrainerBE.Fecha_Nacimiento);
                cmd.Parameters.AddWithValue("@vUsu_Registro", objTrainerBE.Usu_registro);
                cmd.Parameters.AddWithValue("@vEstado_Trainer", objTrainerBE.Estado_trainer);
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

        public Boolean ActualizarTrainer(TrainerBE objTrainerBE)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ActualizarTrainer";
            cmd.Parameters.Clear();
            //Agregamos parametros 
            try
            {
                //Codifique
                cmd.Parameters.AddWithValue("@vId", objTrainerBE.Id_trainer);
                cmd.Parameters.AddWithValue("@vDni_Trainer", objTrainerBE.Dni_trainer);
                cmd.Parameters.AddWithValue("@vNombre_Trainer", objTrainerBE.Nombre_trainer);
                cmd.Parameters.AddWithValue("@vApellidos_Trainer", objTrainerBE.Apellido_trainer);
                cmd.Parameters.AddWithValue("@vFoto_Trainer", objTrainerBE.Foto_trainer);
                cmd.Parameters.AddWithValue("@vTalla_Trainer", objTrainerBE.Talla_trainer);
                cmd.Parameters.AddWithValue("@vDireccion_Trainer", objTrainerBE.Direccion_trainer);
                cmd.Parameters.AddWithValue("@vIdUbigeo", objTrainerBE.Id_ubigeo);
                cmd.Parameters.AddWithValue("@vCorreo_Trainer", objTrainerBE.Correo_trainer);
                cmd.Parameters.AddWithValue("@vTelf_Trainer", objTrainerBE.Telf_trainer);
                cmd.Parameters.AddWithValue("@vSexo_Trainer", objTrainerBE.Sexo_trainer);
                cmd.Parameters.AddWithValue("@vFecha_Nacimiento", objTrainerBE.Fecha_Nacimiento);
                cmd.Parameters.AddWithValue("@vUsu_Ult_Mod", objTrainerBE.Usu_ult_mod);
                cmd.Parameters.AddWithValue("@vEstado_Trainer", objTrainerBE.Estado_trainer);
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

        public Boolean EliminarTrainer(String strid)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_EliminarTrainer";
            cmd.Parameters.Clear();
            //Agregamos parametros 
            try
            {
                //Codifique
                cmd.Parameters.AddWithValue("@vId", strid);

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

        public TrainerBE ConsultarTrainer(String strid)
        {
            TrainerBE objTrainerBE = new TrainerBE();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ConsultarTrainer";
            cmd.Parameters.Clear();
            try
            {
                //Codifique
                cmd.Parameters.AddWithValue("@vId", strid);

                // Abrimos la conexion y ejecutamos...
                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objTrainerBE.Id_trainer = dtr["Id_Trainer"].ToString();
                    objTrainerBE.Dni_trainer = dtr["Dni_Trainer"].ToString();
                    objTrainerBE.Nombre_trainer = dtr["Nombre_Trainer"].ToString();
                    objTrainerBE.Apellido_trainer = dtr["Apellidos_Trainer"].ToString();
                    objTrainerBE.Foto_trainer = dtr["Foto_Trainer"].ToString();
                    objTrainerBE.Talla_trainer = Convert.ToInt16(dtr["Talla_Trainer"]);
                    objTrainerBE.Direccion_trainer = dtr["Direccion_Trainer"].ToString();
                    objTrainerBE.Correo_trainer = dtr["Correo_Trainer"].ToString();
                    objTrainerBE.Usu_registro = dtr["Usu_Registro"].ToString();
                    objTrainerBE.Id_ubigeo = dtr["Id_Ubigeo"].ToString();
                    objTrainerBE.Departamento = dtr["Departamento"].ToString();
                    objTrainerBE.Provincia = dtr["Provincia"].ToString();
                    objTrainerBE.Distrito = dtr["Distrito"].ToString();
                    objTrainerBE.Telf_trainer = dtr["Telf_Trainer"].ToString();
                    objTrainerBE.Estado_trainer = Convert.ToInt16(dtr["Estado_Trainer"]);
                    objTrainerBE.Sexo_trainer = dtr["Sexo"].ToString();
                    objTrainerBE.Fecha_Nacimiento = Convert.ToDateTime(dtr["Fecha_Nacimiento"]);

                }
                dtr.Close();
                return objTrainerBE;

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

        public DataTable ListarTrainer()
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarTrainer";
            cmd.Parameters.Clear();
            try
            {
                //Codifique
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Trainers");

                return dts.Tables["Trainers"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
