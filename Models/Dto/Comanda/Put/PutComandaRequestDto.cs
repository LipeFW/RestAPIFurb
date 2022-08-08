using RestAPIFurb.Models.Dto.Produto;

namespace RestAPIFurb.Models.Dto.Comanda.Put
{
    public class PutComandaRequestDto
    {
        public ICollection<PostProdutoRequestDto> Produtos { get; set; }
    }
}
