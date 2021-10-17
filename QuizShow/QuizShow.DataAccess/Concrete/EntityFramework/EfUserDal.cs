using QuizShow.DataAccess.Abstract;
using QuizShow.Entities.Concrete;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace QuizShow.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal:EfEntityRepositoryBase<User,QuizShowContext> , IUserDal
    {
        
    }
}
