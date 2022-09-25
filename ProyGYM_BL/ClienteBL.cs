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
    public class ClienteBL
    {
        ClienteADO objClienteADO = new ClienteADO();

        public Boolean InsertarCliente(ClienteBE objClienteBE)
        {
            return objClienteADO.InsertarCliente(objClienteBE);
        }

        public Boolean ActualizarCliente(ClienteBE objClienteBE)
        {
            return objClienteADO.ActualizarCliente(objClienteBE);
        }
        public Boolean EliminarCliente(String strid)
        {
            return objClienteADO.EliminarCliente(strid);
        }
        public ClienteBE ConsultarCliente(String strid)
        {
            return objClienteADO.ConsultarCliente(strid);
        }

        public DataTable ListarCliente()
        {
            return objClienteADO.ListarCliente();
        }
    }
}
