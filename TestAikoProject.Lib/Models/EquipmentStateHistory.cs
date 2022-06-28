namespace TestAikoProject.Lib.Models
{
    public class EquipmentStateHistory : EquipmentBase
    {
        public Guid EquipmentId { get; set; }
        public DateTime Date { get; set; }
        public Guid EquipmentStatetId { get; set; }
        public virtual Equipment Equipment { get; set; }
        public virtual EquipmentState EquipmentState {get; set; }

        public EquipmentStateHistory(Guid equipmentId, DateTime date, Guid equipmentStateId)
        {
            EquipmentId = equipmentId;
            Date = date; 
            EquipmentStatetId = equipmentStateId;           
            
        }

        public Guid GetEquipmentId()
        {
            return EquipmentId;
        }
        public void SetEquipmentId(Guid equipmentId)
        {
            EquipmentId = equipmentId;
        }
        public DateTime GetDate()
        {
            return Date;
        }
        public void SetDate(DateTime date)
        {
            Date = date;
        }
        public Guid GetEquipmentStateId()
        {
            return EquipmentStatetId;
        }
        public void SetEquipmentStateId(Guid equipmentStateId)
        {
            EquipmentStatetId = equipmentStateId;
        }        
    }
}