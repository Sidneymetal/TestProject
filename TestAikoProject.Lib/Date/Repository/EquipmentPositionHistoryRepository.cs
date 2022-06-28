using TestAikoProject.Lib.Interface;
using TestAikoProject.Lib.Models;

namespace TestAikoProject.Lib.Date.Repository
{
    public class EquipmentPositionHistoryRepository : EquipmentBaseRepository<EquipmentPositionHistory>, IEquipmentPositionHistoryRepository
    {
        public EquipmentPositionHistoryRepository(TestAikoContext context) : base (context, context.EquipmentsPositionHistory)
        {

        }
    }
}