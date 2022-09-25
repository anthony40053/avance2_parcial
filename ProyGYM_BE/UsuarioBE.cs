using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyGYM_BE
{
    public class UsuarioBE
    {
        private String mvarlogin_Usuario;
        public String Login_Usuario
        {
            get { return mvarlogin_Usuario; }
            set { mvarlogin_Usuario = value; }
        }

        private String mvarpass_Usuario;
        public String Pass_Usuario
        {
            get { return mvarpass_Usuario; }
            set { mvarpass_Usuario = value; }
        }

        private Int16 mvarest_Usuario;
        public Int16 Est_Usuario
        {
            get { return mvarest_Usuario; }
            set { mvarest_Usuario = value; }
        }

        private DateTime mvarfec_Registro;
        public DateTime Fec_Registro
        {
            get { return mvarfec_Registro; }
            set { mvarfec_Registro = value; }
        }
    }
}
