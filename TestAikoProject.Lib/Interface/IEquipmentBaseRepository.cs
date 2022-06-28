using TestAikoProject.Lib.Models;

namespace TestAikoProject.Lib.Interface
{
    public interface IEquipmentBaseRepository <T> where T : EquipmentBase
    {
        List<T> GetAllList();
        void SetAllList(T id);
        void ChangeList(Guid id, Equipment equipment);
        void Delete(Guid id);
    }
}