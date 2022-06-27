namespace TestAikoProject.Lib.Models
{
    public class Equipment 
    {
        public int Id { get; set; }
        public string EquipmentModelId { get; set; }
        public string Name { get; set; }
        public List<EquipmentStateHistory> ListEquipmentStateHistory { get; set; } = new List<EquipmentStateHistory>();
        public List<EquipmentPositionHistory> ListEquipmentPositionHistory { get; set; } = new List<EquipmentPositionHistory>();
        
        public Equipment(int id, string equipmentModelId, string name)
        {
            Id = id;
            EquipmentModelId = equipmentModelId;
            Name = name;
        }

        public int GetId()
        {
            return Id;
        }
        public void SetId(int id)
        {
            Id = id;
        }
        public string GetEquipmentModelId()
        {
            return EquipmentModelId;
        }
        public void SetEquipmentModelId(string equipmentModelId)
        {
            EquipmentModelId = equipmentModelId;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetName(string name)
        {
            Name = name;
        }
    }
}