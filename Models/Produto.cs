using System.ComponentModel.DataAnnotations;

namespace RestAPIFurb.Models
{
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
    }
}
