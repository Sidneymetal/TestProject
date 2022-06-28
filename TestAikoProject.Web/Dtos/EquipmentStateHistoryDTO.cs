using TestAikoProject.Lib.Models;

namespace TestAikoProject.Web.Dtos
{
    public class EquipmentStateHistoryDTO
    {
        public Guid EquipmentId { get; set; }
        public DateTime Date { get; set; }
        public Guid EquipmentStatetId { get; set; }
        public virtual Equipment Equipment { get; set; }
        public virtual EquipmentState EquipmentState { get; set; }

    }
}