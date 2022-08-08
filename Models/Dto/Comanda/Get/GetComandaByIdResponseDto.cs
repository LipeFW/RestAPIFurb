using RestAPIFurb.Models.Dto.Produto;

namespace RestAPIFurb.Models.Dto.Comanda.Get
{
    public class GetComandaByIdResponseDto
    {
        public int IdUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string TelefoneUsuario { get; set; }
        public ICollection<GetProdutoResponseDto> Produtos { get; set; }
    }
}
