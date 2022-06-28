namespace TestAikoProject.Lib.Models
{
    public class Equipment : EquipmentBase
    {
        public Guid Id { get; set; }
        public Guid EquipmentModelId { get; set; }
        public string Name { get; set; }
        public List<EquipmentStateHistory> ListEquipmentStateHistory { get; set; } = new List<EquipmentStateHistory>();
        public List<EquipmentPositionHistory> ListEquipmentPositionHistory { get; set; } = new List<EquipmentPositionHistory>();
        
        public Equipment(Guid id, Guid equipmentModelId, string name)
        {
            Id = id;
            EquipmentModelId = equipmentModelId;
            Name = name;
        }

        public Guid GetId()
        {
            return Id;
        }
        public void SetId(Guid id)
        {
            Id = id;
        }
        public Guid GetEquipmentModelId()
        {
            return EquipmentModelId;
        }
        public void SetEquipmentModelId(Guid equipmentModelId)
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