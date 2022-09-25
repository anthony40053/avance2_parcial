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
    public class ClienteADO
    {
        // Insumos..... 
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        // Metodos de mantenimiento

        public Boolean InsertarCliente(ClienteBE objClienteBE)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_InsertarCliente";
            cmd.Parameters.Clear();
            //Agregamos parametros 
            try
            {
                //Codifique
                cmd.Parameters.AddWithValue("@Dni_Cliente", objClienteBE.Dni_cliente);
                cmd.Parameters.AddWithValue("@Nombre_Cliente", objClienteBE.Nombre_cliente);
                cmd.Parameters.AddWithValue("@Apellido_Cliente", objClienteBE.Apellido_cliente);
                cmd.Parameters.AddWithValue("@Foto_Cliente", objClienteBE.Foto_cliente);
                cmd.Parameters.AddWithValue("@Talla_Cliente", objClienteBE.Talla_cliente);
                cmd.Parameters.AddWithValue("@Direccion_Cliente", objClienteBE.Direccion_cliente);
                cmd.Parameters.AddWithValue("@Id_Ubigeo", objClienteBE.Id_ubigeo);
                cmd.Parameters.AddWithValue("@Correo_Cliente", objClienteBE.Correo_cliente);
                cmd.Parameters.AddWithValue("@Telf_Cliente", objClienteBE.Telf_cliente);
                cmd.Parameters.AddWithValue("@Sexo_Cliente", objClienteBE.Sexo_cliente);
                cmd.Parameters.AddWithValue("@Fecha_Nacimiento", objClienteBE.Fecha_Nacimiento);
                cmd.Parameters.AddWithValue("@Usu_Registro", objClienteBE.Usu_registro);
                cmd.Parameters.AddWithValue("@Estado_Cliente", objClienteBE.Estado_cliente);
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

        public Boolean ActualizarCliente(ClienteBE objClienteBE)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ActualizarCliente";
            cmd.Parameters.Clear();
            //Agregamos parametros 
            try
            {
                //Codifique
                cmd.Parameters.AddWithValue("@Id_Cliente", objClienteBE.Id_cliente);
                cmd.Parameters.AddWithValue("@Dni_Cliente", objClienteBE.Dni_cliente);
                cmd.Parameters.AddWithValue("@Nombre_Cliente", objClienteBE.Nombre_cliente);
                cmd.Parameters.AddWithValue("@Apellido_Cliente", objClienteBE.Apellido_cliente);
                cmd.Parameters.AddWithValue("@Foto_Cliente", objClienteBE.Foto_cliente);
                cmd.Parameters.AddWithValue("@Talla_Cliente", objClienteBE.Talla_cliente);
                cmd.Parameters.AddWithValue("@Direccion_Cliente", objClienteBE.Direccion_cliente);
                cmd.Parameters.AddWithValue("@Id_Ubigeo", objClienteBE.Id_ubigeo);
                cmd.Parameters.AddWithValue("@Correo_Cliente", objClienteBE.Correo_cliente);
                cmd.Parameters.AddWithValue("@Telf_Cliente", objClienteBE.Telf_cliente);
                cmd.Parameters.AddWithValue("@Sexo_Cliente", objClienteBE.Sexo_cliente);
                cmd.Parameters.AddWithValue("@Fecha_Nacimiento", objClienteBE.Fecha_Nacimiento);
                cmd.Parameters.AddWithValue("@Usu_Ult_Mod", objClienteBE.Usu_ult_mod);
                cmd.Parameters.AddWithValue("@Estado_Cliente", objClienteBE.Estado_cliente);
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

        public Boolean EliminarCliente(String strid)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_EliminarCliente";
            cmd.Parameters.Clear();
            //Agregamos parametros 
            try
            {
                //Codifique
                cmd.Parameters.AddWithValue("@Id_Cliente", strid);

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

        public ClienteBE ConsultarCliente(String strid)
        {
            ClienteBE objClienteBE = new ClienteBE();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ConsultarCliente";
            cmd.Parameters.Clear();
            try
            {
                //Codifique
                cmd.Parameters.AddWithValue("@Id_Cliente", strid);

                // Abrimos la conexion y ejecutamos...
                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objClienteBE.Id_cliente = dtr["Id_Cliente"].ToString();
                    objClienteBE.Dni_cliente = dtr["Dni_Cliente"].ToString();
                    objClienteBE.Nombre_cliente = dtr["Nombre_Cliente"].ToString();
                    objClienteBE.Apellido_cliente = dtr["Apellidos_Cliente"].ToString();
                    objClienteBE.Foto_cliente = dtr["Foto_Cliente"].ToString();
                    objClienteBE.Talla_cliente = Convert.ToInt16(dtr["Talla_Cliente"]);
                    objClienteBE.Direccion_cliente = dtr["Direccion_Cliente"].ToString();
                    objClienteBE.Correo_cliente = dtr["Correo_Cliente"].ToString();
                    objClienteBE.Usu_registro = dtr["Usu_Registro"].ToString();
                    objClienteBE.Id_ubigeo = dtr["Id_Ubigeo"].ToString();
                    objClienteBE.Departamento = dtr["Departamento"].ToString();
                    objClienteBE.Provincia = dtr["Provincia"].ToString();
                    objClienteBE.Distrito = dtr["Distrito"].ToString();
                    objClienteBE.Telf_cliente = dtr["Telf_Cliente"].ToString();
                    objClienteBE.Estado_cliente = Convert.ToInt16(dtr["Estado_Cliente"]);
                    objClienteBE.Sexo_cliente = dtr["Sexo"].ToString();
                    objClienteBE.Fecha_Nacimiento = Convert.ToDateTime(dtr["Fecha_Nacimiento"]);

                }
                dtr.Close();
                return objClienteBE;

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

        public DataTable ListarCliente()
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarCliente";
            cmd.Parameters.Clear();
            try
            {
                //Codifique
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Clientes");

                return dts.Tables["Clientes"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
