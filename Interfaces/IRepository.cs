using rugby_stat_tracker.Models;

namespace rugby_stat_tracker.Interfaces
{
    public interface IRepository<T> where T : class
    {
        ICollection<T> GetAll();
        Player GetById(int id);
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        bool Save();

    }
}
