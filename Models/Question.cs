using System.ComponentModel.DataAnnotations;

namespace zallpy_challenge_back.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        
        public string QuestionBody { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string AnswerCorrect { get; set; } // A1, A2, A3 ou A4
    }
}