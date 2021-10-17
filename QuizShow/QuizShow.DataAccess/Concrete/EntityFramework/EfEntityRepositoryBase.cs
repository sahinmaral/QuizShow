using Microsoft.EntityFrameworkCore;

using QuizShow.Entities.Concrete;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using QuizShow.Entities.Abstract;

namespace QuizShow.DataAccess.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity,TContext> 
        where TEntity : class , IEntity , new()
        where TContext : DbContext , new()
    {
        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (QuizShowContext context = new QuizShowContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (QuizShowContext context = new QuizShowContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Add(TEntity entity)
        {
            using (QuizShowContext context = new QuizShowContext())
            {
                
                var entry = context.Entry(entity);
                entry.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (QuizShowContext context = new QuizShowContext())
            {
                var entry = context.Entry(entity);
                entry.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Update(TEntity entity)
        {
            using (QuizShowContext context = new QuizShowContext())
            {
                var entry = context.Entry(entity);
                entry.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
