namespace TestAikoProject.Lib.Models
{
    public class EquipmentState
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public EquipmentState(int id, string name, string color)
        {
            Id = id;
            Name = name;
            Color = color;
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