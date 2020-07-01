using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ListaPaises.Models
{
    [Table("Paises")]
    public class Pais
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Nome do País")]
        public string Nome { get; set; }
        public string Codigo { get; set; }
    }
}
