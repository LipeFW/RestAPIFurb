using RestAPIFurb.Models.Dto.Produto;

namespace RestAPIFurb.Models.Dto.Comanda.Post
{
    public class PostComandaRequestDto : BaseUsuarioDto
    {
        public ICollection<PostProdutoRequestDto> Produtos { get; set; }
    }
}
