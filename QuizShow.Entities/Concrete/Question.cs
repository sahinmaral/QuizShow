using QuizShow.Entities.Abstract;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace QuizShow.Entities.Concrete
{
    [Table("questions")]
    public class Question:IEntity
    {

        [Key]
        [Column("question_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("question_content")]
        [MinLength(10)]
        [MaxLength(100)]
        [NotNull]
        public string Content { get; set; }
        
        public ICollection<QuestionRightAnswer> QuestionRightAnswers { get; set; }

    }
}
