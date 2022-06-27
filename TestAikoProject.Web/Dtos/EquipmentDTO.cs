using TestAikoProject.Lib.Models;

namespace TestAikoProject.Web.Dtos
{
    public class EquipmentDTO
    {
        public int Id { get; set; }
        public int EquipmentModelId { get; set; }
        public string Name { get; set; }
        public List<EquipmentStateHistory> ListEquipmentStateHistory { get; set; }
        public List<EquipmentPositionHistory> ListEquipmentPositionHistory { get; set; }
    }
}