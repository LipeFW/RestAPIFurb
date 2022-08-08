using RestAPIFurb.Models.Dto.Produto;

namespace RestAPIFurb.Models.Dto.Comanda.Post
{
    public class PostComandaResponseDto : BaseUsuarioDto
    {
        public int Id { get; set; }
        public ICollection<GetProdutoResponseDto> Produtos { get; set; }
    }
}
