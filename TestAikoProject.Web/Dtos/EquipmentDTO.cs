using TestAikoProject.Lib.Models;

namespace TestAikoProject.Web.Dtos
{
    public class EquipmentDTO
    {
        public Guid Id { get; set; }
        public Guid EquipmentModelId { get; set; }
        public string Name { get; set; }       
    }
}