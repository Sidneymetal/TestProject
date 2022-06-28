namespace TestAikoProject.Lib.Models
{
    public class EquipmentModel : EquipmentBase
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<EquipmentModelStateHourlyEarnings> ListEquipmentModelStateHourlyEarnings { get; set; } = new List<EquipmentModelStateHourlyEarnings>();

        public EquipmentModel(Guid id, string name)
        {
            Id = id;
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