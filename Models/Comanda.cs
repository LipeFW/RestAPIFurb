using System.ComponentModel.DataAnnotations;

namespace RestAPIFurb.Models
{
    public class Comanda
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int IdUsuario { get; set; }
        [Required]
        public string NomeUsuario { get; set; }
        [Required]
        public string TelefoneUsuario { get; set; }
        public ICollection<Produto> Produtos { get; set; }
    }
}
