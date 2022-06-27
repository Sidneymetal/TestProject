namespace TestAikoProject.Lib.Models
{
    public class EquipmentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public EquipmentModel(int id, string name)
        {
            Id = id;
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