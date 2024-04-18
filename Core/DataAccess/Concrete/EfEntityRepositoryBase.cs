using Core.DataAccess.Abstract;
using Core.Entity.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Core.DataAccess.Concrete
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
   where TEntity : class, IEntity, new() 
   where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void DeleteByLocally(TEntity entity)
        {
            using (var context = new TContext())
            {
                var deletedByLocallyEntity = context.Entry(entity);
                deletedByLocallyEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new TContext())
            {
#pragma warning disable CS8603 // Possible null reference return.
                return context.Set<TEntity>().SingleOrDefault(filter);
#pragma warning restore CS8603 // Possible null reference return.
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity,bool>>? filter = null)
        {
            using (var context = new TContext())
            {
                var result = filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>()
                    .Where(filter)
                    .ToList();

                return result;
            }
        }

        public void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
