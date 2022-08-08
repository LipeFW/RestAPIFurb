using System.ComponentModel.DataAnnotations;

namespace RestAPIFurb.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public double Preco { get; set; }

        public Comanda Comanda { get; set; } = new Comanda();

        public bool Validate() =>
            !string.IsNullOrWhiteSpace(Nome);
    }
}
