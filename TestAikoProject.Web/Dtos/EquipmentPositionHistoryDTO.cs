using TestAikoProject.Lib.Models;

namespace TestAikoProject.Web.Dtos
{
    public class EquipmentPositionHistoryDTO
    {
        public Guid EquipmentId { get; set; }
        public DateTime Date { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        public Equipment Equipment { get; set; }
    }
}