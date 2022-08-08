using RestAPIFurb.Models.Dto.Produto;

namespace RestAPIFurb.Models.Dto.Comanda.Post
{
    public class PostComandaResponseDto
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string TelefoneUsuario { get; set; }
        public ICollection<GetProdutoResponseDto> Produtos { get; set; }
    }
}
