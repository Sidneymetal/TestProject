using TestAikoProject.Lib.Interface;
using TestAikoProject.Lib.Models;

namespace TestAikoProject.Lib.Date.Repository
{
    public class EquipmentStateHistoryRepository : EquipmentBaseRepository<EquipmentStateHistory> ,IEquipmentStateHistoryRepository
    {
        public EquipmentStateHistoryRepository(TestAikoContext context) : base (context, context.EquipmentsStateHistory)
        {

        }
    }
}