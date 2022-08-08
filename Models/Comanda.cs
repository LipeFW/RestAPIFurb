using System.ComponentModel.DataAnnotations;

namespace RestAPIFurb.Models
{
    public class Comanda
    {
        [Key]
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public string NomeUsuario { get; set; } = string.Empty;
        public string TelefoneUsuario { get; set; } = string.Empty;
        public ICollection<Produto> Produtos { get; set; } = new List<Produto>();

        public bool Validate() =>
            (IdUsuario >= 0 &&
            !string.IsNullOrWhiteSpace(NomeUsuario) &&
            !string.IsNullOrWhiteSpace(TelefoneUsuario) &&
            Produtos != null);
    }

}
