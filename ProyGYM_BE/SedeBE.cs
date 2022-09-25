using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyGYM_BE
{
    public class SedeBE
    {
        private String mvarid_Sede;
        public String Id_Sede
        {
            get { return mvarid_Sede; }
            set { mvarid_Sede = value; }
        } 

        private String mvardir_Sede;
        public String Dir_Sede
        {
            get { return mvardir_Sede; }
            set { mvardir_Sede = value; }
        }

        private String mvardes_Sede;
        public String Des_Sede
        {
            get { return mvardes_Sede; }
            set { mvardes_Sede = value; }
        }

        private String mvarid_ubigeo;
        public String Id_ubigeo
        {
            get { return mvarid_ubigeo; }
            set { mvarid_ubigeo = value; }
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

        private Int16 mvarestado_Sede;
        public Int16 Estado_Sede
        {
            get { return mvarestado_Sede; }
            set { mvarestado_Sede = value; }
        }
    }
}
