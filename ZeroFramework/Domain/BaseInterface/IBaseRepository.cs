using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ZeroFramework.Domain.BaseInterface
{
    public interface IBaseRepository<TKey, TEntity> where TEntity : class
    {
        /// <summary>
        /// I made this repository base to avoid reptation some actions that they are routine.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        
        TEntity Get(TKey Id);

        List<TEntity> GetAll();

        void Create(TEntity entity);

        void Update(TEntity entity);

        //bool Delete(TEntity entity);

        //bool DeleteRange(List<TEntity> entities);

        bool Exists(Expression<Func<TEntity, bool>> expression);
      
        void SaveChanges();
 
    }
}
