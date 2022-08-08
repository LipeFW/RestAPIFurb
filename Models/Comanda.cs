using System.ComponentModel.DataAnnotations;

namespace RestAPIFurb.Models
{
    public class Comanda
    {
        [Key]
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string TelefoneUsuario { get; set; }
        public ICollection<Produto> Produtos { get; set; }
    }
}
