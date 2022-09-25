using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProyGYM_ADO;

namespace ProyGYM_BL
{
    public class RecepcionistaBL
    {
        RecepcionistaADO objRecepcionistaADO = new RecepcionistaADO();
        public DataTable ListarRecepcionista()
        {
            return objRecepcionistaADO.ListarRecepcionista();
        }
    }
}
