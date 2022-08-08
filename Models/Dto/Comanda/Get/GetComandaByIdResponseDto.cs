using RestAPIFurb.Models.Dto.Produto;

namespace RestAPIFurb.Models.Dto.Comanda.Get
{
    public class GetComandaByIdResponseDto : BaseUsuarioDto
    {
        public ICollection<GetProdutoResponseDto> Produtos { get; set; }
    }
}
