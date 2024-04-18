//using Core.Entity.Interfaces;
//using Core.Utilities.Results;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Text;
//using System.Threading.Tasks;

//namespace Core.DataAccess.Abstract
//{
//    public interface IEntityAsyncRepository<TEntity> where TEntity : class,IEntity,new()
//    {
//        IDataResult<Task<TEntity>> AddAsync(TEntity entity);
//        IDataResult<Task<TEntity>> DeleteAsync(TEntity entity);
//        IDataResult<Task<IEnumerable<TEntity>>> GetAllAsync(Expression<Func<TEntity, bool>>? filter = null);
//        IDataResult<Task<IEnumerable<TEntity>>> GetByIdAsync(Expression<Func<TEntity, bool>> filter);
//        IDataResult<Task<TEntity>> UpdateAsync(TEntity entity);

//    }
//}
