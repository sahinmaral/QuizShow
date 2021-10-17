using QuizShow.Entities.Concrete;

namespace QuizShow.Business.Abstract
{
    public interface IUserService : IRepositoryService<User>
    {
        public string Login(User user);
    }
}
