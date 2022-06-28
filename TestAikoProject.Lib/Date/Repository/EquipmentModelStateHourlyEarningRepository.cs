using TestAikoProject.Lib.Interface;
using TestAikoProject.Lib.Models;

namespace TestAikoProject.Lib.Date.Repository
{
    public class EquipmentModelStateHourlyEarningRepository : EquipmentBaseRepository<EquipmentModelStateHourlyEarnings>, IEquipmentModelStateHourlyEarningRepository
    {
        public EquipmentModelStateHourlyEarningRepository(TestAikoContext context) : base (context, context.EquipmentsModelsStateHoyrlyEarnings)
        {

        }
    }
}