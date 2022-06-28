namespace TestAikoProject.Lib.Models
{
    public class EquipmentState : EquipmentBase
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }        
        public List<EquipmentStateHistory> ListEquipmentStateHistory { get; set; }
        public List<EquipmentModelStateHourlyEarnings> ListEquipmentModelStateHourlyEarnings { get; set; }

        public EquipmentState(Guid id, string name, string color)
        {
            Id = id;
            Name = name;
            Color = color;
        }

        public Guid GetId()
        {
            return Id;
        }
        public void SetId(Guid id)
        {
            Id = id;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public string GetColor()
        {
            return Color;
        }
        public void SetColor(string color)
        {
            Color = color;
        } 
    }
}