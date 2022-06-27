namespace TestAikoProject.Lib.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public int EquipmentModelId { get; set; }
        public string Name { get; set; }

        public Equipment(int id, int equipmentModelId, string name)
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
        public int GetEquipmentModelId()
        {
            return EquipmentModelId;
        }
        public void SetEquipmentModelId(int equipmentModelId)
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