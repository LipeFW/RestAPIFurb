using System.ComponentModel.DataAnnotations;

namespace RestAPIFurb.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public double Preco { get; set; }

        public Comanda Comanda { get; set; }
    }
}
