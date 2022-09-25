using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using ProyGYM_ADO;

namespace ProyGYM_BL
{
    public class AsistenciaBL
    {
        AsistenciaADO objAsistenciaADO = new AsistenciaADO();

        public DataTable usp_ListarClientesAsistenciaFechas(string strId, DateTime fecini, DateTime fecfin)
        {
            return objAsistenciaADO.usp_ListarClientesAsistenciaFechas(strId, fecini, fecfin);
        }

        public DataTable usp_ListarTrainersAsistenciaFechas(string strId, DateTime fecini, DateTime fecfin)
        {
            return objAsistenciaADO.usp_ListarTrainersAsistenciaFechas(strId, fecini, fecfin);
        }

        public DataTable usp_ListarClientes_Paginacion(string strCod_cli, String strCod_ven, String strEstado, Int16 intNumPag)
        {
            return objAsistenciaADO.usp_ListarClientes_Paginacion(strCod_cli, strCod_ven, strEstado, intNumPag);
        }

        public Int16 usp_NumPag_ListarClientes_Paginacion(string strCod_cli, String strCod_ven, String strEstado)
        {
            return objAsistenciaADO.usp_NumPag_ListarClientes_Paginacion(strCod_cli, strCod_ven, strEstado);
        }

        public DataTable usp_ListarTrainers_Paginacion(string strId_tre, String strId_rec, String strEstado, Int16 intNumPag)
        {
            return objAsistenciaADO.usp_ListarTrainers_Paginacion(strId_tre, strId_rec, strEstado, intNumPag);
        }

        public Int16 usp_NumPag_ListarTrainers_Paginacion(string strId_tre, String strId_rec, String strEstado)
        {
            return objAsistenciaADO.usp_NumPag_ListarTrainers_Paginacion(strId_tre, strId_rec, strEstado);
        }
    }
}
