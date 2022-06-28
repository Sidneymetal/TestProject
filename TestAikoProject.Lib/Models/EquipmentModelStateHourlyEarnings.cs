namespace TestAikoProject.Lib.Models
{
    public class EquipmentModelStateHourlyEarnings : EquipmentBase
    {
        public Guid EquipmentStateId { get; set; }
        public Guid EquipmentModelId { get; set; }
        public bool Value { get; set; }
        public virtual EquipmentModel EquipmentModel { get; set; }
        public EquipmentState EquipmentState { get; set; }  

        public EquipmentModelStateHourlyEarnings(Guid equipmentStateId, Guid equipmentModelId, bool value)
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
        public bool GetValue()
        {
            return Value;
        }
        public void SetValue(bool value)
        {
            Value = value;
        }
    }
}