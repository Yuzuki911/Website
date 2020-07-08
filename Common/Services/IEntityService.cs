using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Common.Services
{
    public interface IEntityService<TEntity>
        where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity Find(object id);
        IEnumerable<TEntity> GetAllIncluding(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "");
        bool Exist(Expression<Func<TEntity, bool>> spec = null);
        int Count(Expression<Func<TEntity, bool>> spec = null);

        void Create(TEntity entity);

        void Delete(TEntity entity);

        void Update(TEntity entity, object id);

        void Dispose();
    }
}
