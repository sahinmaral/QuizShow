using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace QuizShow.Entities.Concrete
{
    [Table("question_right_answer")]
    public class QuestionRightAnswer
    {
        [Key]
        [Column("question_right_answer_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("question_id")]
        [NotNull]
        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }


        [Column("right_answer_id")]
        [NotNull]
        public int RightAnswerId { get; set; }
        public virtual Answer RightAnswer { get; set; }
    }
}
