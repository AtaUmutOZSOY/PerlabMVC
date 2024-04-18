//using Core.DataAccess.Abstract;
//using Core.Entity.Interfaces;
//using Core.Utilities.Results;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Text;
//using System.Threading.Tasks;

//namespace Core.DataAccess.Concrete
//{
//    public class EfAsyncRepositoryBase<TEntity, TContext> : IEntityAsyncRepository<TEntity>
//    where TEntity : class, IEntity, new()
//    where TContext : DbContext, new()
//    {
//        // Asenkron ekleme işlemi
//        public async IDataResult<Task<TEntity>> AddAsync(TEntity entity)
//        {
//            using (var context = new TContext())
//            {
//                await context.Set<TEntity>().AddAsync(entity);
//                await context.SaveChangesAsync();
//                return new SuccessDataResult<Task<TEntity>>();
//            }
//        }

//        // Asenkron silme işlemi
//        public async Task DeleteAsync(TEntity entity)
//        {
//            using (var context = new TContext())
//            {
//                context.Set<TEntity>().Remove(entity);
//                await context.SaveChangesAsync();
//            }
//        }

//        // Tüm varlıkları asenkron olarak getirme
//        public async Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>? filter = null)
//        {
//            using (var context = new TContext())
//            {
//                if (filter == null)
//                {
//                    return await context.Set<TEntity>().ToListAsync();
//                }
//                else
//                {
//                    return await context.Set<TEntity>().Where(filter).ToListAsync();
//                }
//            }
//        }

//        // Id ile asenkron olarak varlık getirme
//        public async Task<TEntity> GetByIdAsync(Expression<Func<TEntity, bool>> filter)
//        {
//            using (var context = new TContext())
//            {
//                return await context.Set<TEntity>().SingleOrDefaultAsync(filter);
//            }
//        }

//        // Asenkron güncelleme işlemi
//        public async Task UpdateAsync(TEntity entity)
//        {
//            using (var context = new TContext())
//            {
//                context.Set<TEntity>().Update(entity);
//                await context.SaveChangesAsync();
//            }
//        }
//    }

//}
