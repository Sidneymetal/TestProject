namespace TestAikoProject.Lib.Models
{
    public class EquipmentModelStateHourlyEarnings : EquipmentBase
    {
        public Guid EquipmentStateId { get; set; }
        public Guid EquipmentModelId { get; set; }
        public double Value { get; set; }
        public virtual EquipmentModel EquipmentModel { get; set; }
        public EquipmentState EquipmentState { get; set; }  

        public EquipmentModelStateHourlyEarnings(Guid equipmentStateId, Guid equipmentModelId, double value)
        {
            EquipmentStateId = equipmentStateId;
            EquipmentModelId = equipmentModelId;
            Value = value;
        }

        public Guid GetEquipmentStateId()
        {
            return EquipmentStateId;
        }
        public void SetEquipmentStateId(Guid equipmentStateId)
        {
            EquipmentStateId = equipmentStateId;
        }
        public Guid GetEquipmentModelId()
        {
            return EquipmentModelId;
        }
        public void SetEquipmentModelId(Guid equipmentModelId)
        {
            EquipmentModelId = equipmentModelId;
        }
        public double GetValue()
        {
            return Value;
        }
        public void SetValue(double value)
        {
            Value = value;
        }
    }
}