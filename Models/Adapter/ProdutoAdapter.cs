using RestAPIFurb.Models.Dto.Comanda;

namespace RestAPIFurb.Models.Adapter
{
    public static class ProdutoAdapter
    {
        public static Produto FromBody(PostProdutoRequestDto body)
        {
            return new Produto
            {
                Id = body.Id,
                Nome = body.Nome,
                Preco = body.Preco
            };
        }

        public static GetProdutoResponseDto FromDomain(Produto domain)
        {
            return new GetProdutoResponseDto
            {
                Id = domain.Id,
                Nome = domain.Nome,
                Preco = domain.Preco
            };
        }
    }
}
