using Microsoft.EntityFrameworkCore;
using TestAikoProject.Lib.Interface;
using TestAikoProject.Lib.Models;

namespace TestAikoProject.Lib.Date.Repository
{
    public class EquipmentBaseRepository <T> : IEquipmentBaseRepository <T> where T : EquipmentBase
    {
        protected readonly TestAikoContext _context;
        protected readonly DbSet<T> _dbset;
        public EquipmentBaseRepository(TestAikoContext dbContext, DbSet<T> dbset)
        {
            _context = dbContext;
            _dbset = dbset;
        }
        public List<T> GetAllList()
        {
            return _dbset.AsNoTracking().ToList();
        }
        public void SetAllList(T id)
        {
            _dbset.Add(id);
            _context.SaveChanges();
        }
        public void ChangeList(Guid id, Equipment equipment)
        {
            var item = _dbset.Find(id);
            item.Id = equipment;
            _context.SaveChanges();
        }
        public void Delete(Guid id)
        {
            var equipment = _dbset.Find(id);
            _dbset.Remove(equipment);
            _context.SaveChanges();
        }
    }
}