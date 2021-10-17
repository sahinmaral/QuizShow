using System;
using Microsoft.EntityFrameworkCore;
using QuizShow.Entities.Concrete;

namespace QuizShow.DataAccess
{
    public class QuizShowContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;database=quizshow_db;user=root;password=31952828;",
                new MySqlServerVersion(new Version(8, 0, 26)));
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Answer>().ToTable("answers");
        //    modelBuilder.Entity<Question>().ToTable("questions");
        //    modelBuilder.Entity<User>().ToTable("users");
        //}

        public DbSet<Answer> Answers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<User> User { get; set; }

    }
}
