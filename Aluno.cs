using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APITAT
{
    [Table("Alunos")]
    public class Aluno
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(35)]
        public string nome { get; set; }

        [StringLength(30)]
        public string disciplina { get; set; }

        public float nota1 { get; set; }
        public float nota2 { get; set; }
        
    }
}
