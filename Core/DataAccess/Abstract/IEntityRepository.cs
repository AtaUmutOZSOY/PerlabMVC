using System.Linq.Expressions;

namespace Core.DataAccess.Abstract
{
    public interface IEntityRepository<TEntity> where TEntity : class
    {
        TEntity Get(Expression<Func<TEntity, bool>> filter);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void DeleteByLocally(TEntity entity);
        List<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter = null);


    }
}
