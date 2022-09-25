using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyGYM_BE
{
    public class ClienteBE
    {
        private String mvarid_cliente;
        public String Id_cliente
        {
            get { return mvarid_cliente; }
            set { mvarid_cliente = value; }
        }

        private String mvardni_cliente;
        public String Dni_cliente
        {
            get { return mvardni_cliente; }
            set { mvardni_cliente = value; }
        }

        private String mvarnombre_cliente;
        public String Nombre_cliente
        {
            get { return mvarnombre_cliente; }
            set { mvarnombre_cliente = value; }
        }

        private String mvarapellido_cliente;
        public String Apellido_cliente
        {
            get { return mvarapellido_cliente; }
            set { mvarapellido_cliente = value; }
        }

        private String mvarfoto_cliente;
        public String Foto_cliente
        {
            get { return mvarfoto_cliente; }
            set { mvarfoto_cliente = value; }
        }

        private Int16 mvartalla_cliente;
        public Int16 Talla_cliente
        {
            get { return mvartalla_cliente; }
            set { mvartalla_cliente = value; }
        }

        private String mvardireccion_cliente;
        public String Direccion_cliente
        {
            get { return mvardireccion_cliente; }
            set { mvardireccion_cliente = value; }
        }

        private String mvarid_ubigeo;
        public String Id_ubigeo
        {
            get { return mvarid_ubigeo; }
            set { mvarid_ubigeo = value; }
        }

        private String mvarDepartamento;
        public String Departamento
        {
            get { return mvarDepartamento; }
            set { mvarDepartamento = value; }
        }

        private String mvarid_Provincia;
        public String Provincia
        {
            get { return mvarid_Provincia; }
            set { mvarid_Provincia = value; }
        }

        private String mvarid_Distrito;
        public String Distrito
        {
            get { return mvarid_Distrito; }
            set { mvarid_Distrito = value; }
        }

        private String mvarcorreo_cliente;
        public String Correo_cliente
        {
            get { return mvarcorreo_cliente; }
            set { mvarcorreo_cliente = value; }
        }

        private String mvartelf_cliente;
        public String Telf_cliente
        {
            get { return mvartelf_cliente; }
            set { mvartelf_cliente = value; }
        }

        private String mvarsexo_cliente;
        public String Sexo_cliente
        {
            get { return mvarsexo_cliente; }
            set { mvarsexo_cliente = value; }
        }

        private DateTime mvarfecha_Nacimiento;
        public DateTime Fecha_Nacimiento
        {
            get { return mvarfecha_Nacimiento; }
            set { mvarfecha_Nacimiento = value; }
        }

        private DateTime mvarfec_registro;
        public DateTime Fec_registro
        {
            get { return mvarfec_registro; }
            set { mvarfec_registro = value; }
        }

        private String mvarusu_registro;
        public String Usu_registro
        {
            get { return mvarusu_registro; }
            set { mvarusu_registro = value; }
        }

        private DateTime mvarfec_ult_mod;
        public DateTime Fec_ult_mod
        {
            get { return mvarfec_ult_mod; }
            set { mvarfec_ult_mod = value; }
        }

        private String mvarusu_ult_mod;
        public String Usu_ult_mod
        {
            get { return mvarusu_ult_mod; }
            set { mvarusu_ult_mod = value; }
        }

        private Int16 mvarestado_cliente;
        public Int16 Estado_cliente
        {
            get { return mvarestado_cliente; }
            set { mvarestado_cliente = value; }
        }

    }
}
