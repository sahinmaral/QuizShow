using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using QuizShow.Entities.Abstract;

namespace QuizShow.Entities.Concrete
{
    [Table("users")]
    public class User:IEntity
    {
        public User()
        {
            Point = 0;
        }

        [Key]
        [Column("user_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("user_username")]
        [MaxLength(20)]
        [MinLength(2)]
        [NotNull]
        public string Username { get; set; }

        [Column("user_firstname")]
        [MaxLength(50)]
        [MinLength(2)]

        [NotNull]
        public string FirstName { get; set; }

        [Column("user_lastname")]
        [MaxLength(50)]
        [MinLength(2)]
        [NotNull]
        public string LastName { get; set; }

        [Column("user_password")]
        [MaxLength(50)]
        [MinLength(2)]
        [NotNull]
        public string Password { get; set; }

        [Column("user_point")]
        public int Point { get; set; }
    }
}
