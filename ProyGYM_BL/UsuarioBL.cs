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
    public class UsuarioBL
    {
        UsuarioADO objUsuarioADO = new UsuarioADO();
        public UsuarioBE ConsultarUsuario(String strLog)
        {
            return objUsuarioADO.ConsultarUsuario(strLog);
        }
    }
}
