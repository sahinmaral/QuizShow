using QuizShow.Business.Abstract;
using QuizShow.DataAccess.Abstract;
using QuizShow.DataAccess.Concrete.EntityFramework;
using QuizShow.Entities.Concrete;

using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace QuizShow.Business.Concrete
{
    public class UserManager:IUserService
    {
        private readonly IUserDal _answerDal;

        public UserManager(IUserDal answerDal)
        {
            _answerDal = new EfUserDal();
        }

        public User Get(Expression<Func<User, bool>> filter)
        {
            return _answerDal.Get(filter);
        }

        public List<User> GetAll(Expression<Func<User, bool>> filter = null)
        {
            return _answerDal.GetAll(filter);
        }

        public void Add(User entity)
        {
            _answerDal.Add(entity);
        }

        public void Delete(User entity)
        {
            _answerDal.Delete(entity);
        }

        public void Update(User entity)
        {
            _answerDal.Update(entity);
        }

        public string Login(User user)
        {
            User searchedUser = _answerDal.Get(x => x.Username == user.Username);

            if (searchedUser == null)
            {
                return "Böyle bir kullanıcı yok";
            }

            if (searchedUser.Password != user.Password)
            {
                return "Şifreniz veya kullanıcı adınız yanlış";
            }

            return null;

        }
    }
}
