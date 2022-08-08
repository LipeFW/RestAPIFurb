using RestAPIFurb.Models.Dto.Produto;

namespace RestAPIFurb.Models.Dto.Comanda.Post
{
    public class PostComandaRequestDto : BaseUsuarioDto
    {
        public ICollection<PostProdutoRequestDto> Produtos { get; set; }

        public bool IsValid() =>
            (IdUsuario >= 1 &&
            !string.IsNullOrWhiteSpace(NomeUsuario) &&
            !string.IsNullOrWhiteSpace(TelefoneUsuario) &&
            Produtos != null);
    }
}
