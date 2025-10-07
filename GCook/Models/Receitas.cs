using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GCook.Models;

    [Table("Receita")]
    public class Receitas
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Categoria")]
        [Required(ErrorMessage = "A Categoria é obrigatoria")]

        public Categoria Categoria { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "O Nome é obrigatorio")]

        public string Nome { get; set; }
        
        [StringLength(1000)]
        [Required(ErrorMessage = "A Descrição é obrigatoria")]

        public string Descricao { get; set; }

        [StringLength(30)]
        [Display(Name = "Tempo de Preparo")]
        public string TempoPreparo { get; set; }


    }
