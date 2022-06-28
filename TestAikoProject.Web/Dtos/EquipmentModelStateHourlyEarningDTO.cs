using TestAikoProject.Lib.Models;

namespace TestAikoProject.Web.Dtos
{
    public class EquipmentModelStateHourlyEarningDTO
    {
        public Guid EquipmentStateId { get; set; }
        public Guid EquipmentModelId { get; set; }
        public bool Value { get; set; }
        public virtual EquipmentModel EquipmentModel { get; set; }
        public EquipmentState EquipmentState { get; set; }
    }
}