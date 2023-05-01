using Hackathon.Core.Entities.Common;

namespace HappyPet.Infrastructure.Interfaces.Common
{
    public interface IRepository<T> where T : Entity
    {
        void Add(T entity);
        void Remove(T entity);
        void Update(T entity);
        IEnumerable<T> GetAll();
        T GetById(Guid id);
    }
}
