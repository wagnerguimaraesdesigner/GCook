using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GCook.Models;

[Table("categoria")]

    public class Categoria
    {
       [Key]
       public int Id { get; set; }
       [StringLength(30)]
       [Required(ErrorMessage ="O nome é obrigatório")] 

       public string Nome { get; set; }

       [StringLength(300)]
       public String Foto { get; set; }

        [Display(Name = "Exibir na Home?")]
       public bool ExibirHome { get; set; } = false;

    }
