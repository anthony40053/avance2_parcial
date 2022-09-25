using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProyGYM_BE;
using ProyGYM_ADO;

namespace ProyGYM_BL
{
    public class SedeBL
    {
        SedeADO objSedeADO = new SedeADO();

        public Boolean InsertarSede(SedeBE objSedeBE)
        {
            return objSedeADO.InsertarSede(objSedeBE);
        }

        public Boolean ActualizarSede(SedeBE objSedeBE)
        {
            return objSedeADO.ActualizarSede(objSedeBE);
        }
        public Boolean EliminarSede(String strid)
        {
            return objSedeADO.EliminarSede(strid);
        }
        public SedeBE ConsultarSede(String strid)
        {
            return objSedeADO.ConsultarSede(strid);
        }

        public DataTable ListarSede()
        {
            return objSedeADO.ListarSede();
        }
    }
}
