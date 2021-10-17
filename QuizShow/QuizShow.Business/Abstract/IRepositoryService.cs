using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using QuizShow.Entities.Abstract;

namespace QuizShow.Business.Abstract
{
    public interface IRepositoryService<TEntity> where TEntity : class , IEntity , new()
    {
        TEntity Get(Expression<Func<TEntity, bool>> filter);
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
    }
}
