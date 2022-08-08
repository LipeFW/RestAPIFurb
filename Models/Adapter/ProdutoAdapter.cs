using RestAPIFurb.Models.Dto.Comanda;

namespace RestAPIFurb.Models.Adapter
{
    public static class ProdutoAdapter
    {
        public static Produto FromBody(PostProdutoBody body)
        {
            return new Produto
            {
                Id = body.Id,
                Nome = body.Nome,
                Preco = body.Preco
            };
        }
    }
}
