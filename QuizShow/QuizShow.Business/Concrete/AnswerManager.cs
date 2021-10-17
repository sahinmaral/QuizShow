using QuizShow.Business.Abstract;
using QuizShow.DataAccess.Abstract;
using QuizShow.DataAccess.Concrete.EntityFramework;
using QuizShow.Entities.Concrete;

using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace QuizShow.Business.Concrete
{
    public class AnswerManager:IAnswerService
    {
        private readonly IAnswerDal _answerDal;

        public AnswerManager(IAnswerDal answerDal)
        {
            _answerDal = new EfAnswerDal();
        }

        public Answer Get(Expression<Func<Answer, bool>> filter)
        {
            return _answerDal.Get(filter);
        }

        public List<Answer> GetAll(Expression<Func<Answer, bool>> filter = null)
        {
            return _answerDal.GetAll(filter);
        }

        public void Add(Answer entity)
        {
            _answerDal.Add(entity);
        }

        public void Delete(Answer entity)
        {
            _answerDal.Delete(entity);
        }

        public void Update(Answer entity)
        {
            _answerDal.Update(entity);
        }
    }
}
