using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyGYM_BE
{
    public class TrainerBE
    {
        private String mvarid_trainer;
        public String Id_trainer
        {
            get { return mvarid_trainer; }
            set { mvarid_trainer = value; }
        }

        private String mvardni_trainer;
        public String Dni_trainer
        {
            get { return mvardni_trainer; }
            set { mvardni_trainer = value; }
        }

        private String mvarnombre_trainer;
        public String Nombre_trainer
        {
            get { return mvarnombre_trainer; }
            set { mvarnombre_trainer = value; }
        }

        private String mvarapellido_trainer;
        public String Apellido_trainer
        {
            get { return mvarapellido_trainer; }
            set { mvarapellido_trainer = value; }
        }

        private String mvarfoto_trainer;
        public String Foto_trainer
        {
            get { return mvarfoto_trainer; }
            set { mvarfoto_trainer = value; }
        }

        private Int16 mvartalla_trainer;
        public Int16 Talla_trainer
        {
            get { return mvartalla_trainer; }
            set { mvartalla_trainer = value; }
        }

        private String mvardireccion_trainer;
        public String Direccion_trainer
        {
            get { return mvardireccion_trainer; }
            set { mvardireccion_trainer = value; }
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

        private String mvarcorreo_trainer;
        public String Correo_trainer
        {
            get { return mvarcorreo_trainer; }
            set { mvarcorreo_trainer = value; }
        }

        private String mvartelf_trainer;
        public String Telf_trainer
        {
            get { return mvartelf_trainer; }
            set { mvartelf_trainer = value; }
        }

        private String mvarsexo_trainer;
        public String Sexo_trainer
        {
            get { return mvarsexo_trainer; }
            set { mvarsexo_trainer = value; }
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

        private Int16 mvarestado_trainer;
        public Int16 Estado_trainer
        {
            get { return mvarestado_trainer; }
            set { mvarestado_trainer = value; }
        }
    }
}
