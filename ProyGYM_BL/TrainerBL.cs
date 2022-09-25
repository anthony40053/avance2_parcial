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
    public class TrainerBL
    {
        TrainerADO objTrainerADO = new TrainerADO();

        public Boolean InsertarTrainer(TrainerBE objTrainerBE)
        {
            return objTrainerADO.InsertarTrainer(objTrainerBE);
        }

        public Boolean ActualizarTrainer(TrainerBE objTrainerBE)
        {
            return objTrainerADO.ActualizarTrainer(objTrainerBE);
        }
        public Boolean EliminarTrainer(String strid)
        {
            return objTrainerADO.EliminarTrainer(strid);
        }
        public TrainerBE ConsultarTrainer(String strid)
        {
            return objTrainerADO.ConsultarTrainer(strid);
        }

        public DataTable ListarTrainer()
        {
            return objTrainerADO.ListarTrainer();
        }
    }
}
