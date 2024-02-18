using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ZeroFramework.Domain.BaseInterface;

namespace ZeroFramework.Infrastructure
{
    public class RepositoryBase<TKey, TEntity> : IBaseRepository<TKey, TEntity> where TEntity : class
    {
        private readonly DbContext _context;

        public RepositoryBase(DbContext context)
        {
            _context = context;
        }

        public void Create(TEntity entity)
        {
            _context.Add(entity);
        }

        public bool Delete(TEntity entity)
        {
            try
            {
                
                _context.Remove(entity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteRange(List<TEntity> entities)
        {
            try
            {
                _context.RemoveRange(entities);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Exists(Expression<Func<TEntity, bool>> expression)
        {
            return _context.Set<TEntity>().Any(expression);
        }
        public TEntity Get(TKey Id)
        {
            return _context.Find<TEntity>(Id);
        }

        public List<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _context.Update(entity);
        }
    }
}
