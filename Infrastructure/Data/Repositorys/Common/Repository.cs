using Hackathon.Core.Entities.Common;
using HappyPet.Infrastructure.Interfaces.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyPet.Infrastructure.Data.Repositorys.Common
{
    public abstract class Repository<T> : IRepository<T> where T : Entity
    {
        protected readonly DbContext _context;

        public Repository(DbContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(Guid id)
        {
            return _context.Set<T>().Find(id);
        }
    }
}
