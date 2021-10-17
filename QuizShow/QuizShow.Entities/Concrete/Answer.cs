using System.Collections.Generic;
using QuizShow.Entities.Abstract;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace QuizShow.Entities.Concrete
{
    [Table("answers")]
    public class Answer:IEntity
    {
        [Key]
        [Column("answer_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("answer_question_id")]
        [MinLength(1)]
        [NotNull]
        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }

        
        public ICollection<QuestionRightAnswer> QuestionRightAnswers { get; set; }
    }
}
