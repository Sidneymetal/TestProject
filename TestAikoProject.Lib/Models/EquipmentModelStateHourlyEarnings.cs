namespace TestAikoProject.Lib.Models
{
    public class EquipmentModelStateHourlyEarnings
    {
        public int EquipmentStatetId { get; set; }
        public int EquipmentModelId { get; set; }
        public bool Value { get; set; }
        public virtual EquipmentModel EquipmentModel { get; set; }
        public virtual EquipmentState EquipmentState { get; set; }  

        public EquipmentModelStateHourlyEarnings(int equipmentStateId, int equipmentModelId, bool value)
        {
            EquipmentStatetId = equipmentStateId;
            EquipmentModelId = equipmentModelId;
            Value = value;
        }

        public int GetEquipmentStateId()
        {
            return EquipmentStatetId;
        }
        public void SetEquipmentStateId(int equipmentStateId)
        {
            EquipmentStatetId = equipmentStateId;
        }
        public int GetEquipmentModelId()
        {
            return EquipmentModelId;
        }
        public void SetEquipmentModelId(int equipmentModelId)
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