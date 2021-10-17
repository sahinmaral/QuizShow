using QuizShow.DataAccess.Abstract;
using QuizShow.Entities.Concrete;

namespace QuizShow.DataAccess.Concrete.EntityFramework
{
    public class EfAnswerDal:EfEntityRepositoryBase<Answer,QuizShowContext> , IAnswerDal
    {
    }
}
