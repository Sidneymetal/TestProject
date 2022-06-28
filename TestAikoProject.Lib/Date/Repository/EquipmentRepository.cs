using TestAikoProject.Lib.Interface;
using TestAikoProject.Lib.Models;

namespace TestAikoProject.Lib.Date.Repository
{
    public class EquipmentRepository : EquipmentBaseRepository<Equipment>, IEquipmentRepository
    {
        public EquipmentRepository(TestAikoContext context) : base(context, context.Equipments)
        {

        }          
    }
}