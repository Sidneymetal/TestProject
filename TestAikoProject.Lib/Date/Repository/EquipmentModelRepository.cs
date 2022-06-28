using TestAikoProject.Lib.Interface;
using TestAikoProject.Lib.Models;

namespace TestAikoProject.Lib.Date.Repository
{
    public class EquipmentModelRepository : EquipmentBaseRepository<EquipmentModel>, IEquipmentModelRepository
    {
        public EquipmentModelRepository(TestAikoContext context) : base (context, context.EquipmentsModels)
        {

        }
    }
}