using System.ComponentModel.DataAnnotations;

namespace RestAPIFurb.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
    }
}
