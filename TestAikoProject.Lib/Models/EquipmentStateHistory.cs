namespace TestAikoProject.Lib.Models
{
    public class EquipmentStateHistory
    {
        public int EquipmentId { get; set; }
        public DateTime Date { get; set; }
        public int EquipmentStatetId { get; set; }
        public virtual Equipment Equipment { get; set; }
        public virtual EquipmentState EquipmentState {get; set; }

        public EquipmentStateHistory(int equipmentId, DateTime date, int equipmentStateId)
        {
            EquipmentId = equipmentId;
            Date = date; 
            EquipmentStatetId = equipmentStateId;           
            
        }

        public int GetEquipmentId()
        {
            return EquipmentId;
        }
        public void SetEquipmentId(int equipmentId)
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
        public int GetEquipmentStateId()
        {
            return EquipmentStatetId;
        }
        public void SetEquipmentStateId(int equipmentStateId)
        {
            EquipmentStatetId = equipmentStateId;
        }        
    }
}