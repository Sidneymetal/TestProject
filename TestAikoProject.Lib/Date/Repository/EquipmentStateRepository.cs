using TestAikoProject.Lib.Interface;
using TestAikoProject.Lib.Models;

namespace TestAikoProject.Lib.Date.Repository
{
    public class EquipmentStateRepository : EquipmentBaseRepository<EquipmentState> ,IEquipmentStateRepository
    {
        public EquipmentStateRepository(TestAikoContext context) : base (context, context.EquipmentsState)
        {

        }
    }
}