using RestAPIFurb.Models.Dto.Comanda;

namespace RestAPIFurb.Models.Adapter
{
    public static class ComandaAdapter
    {
        public static Comanda FromBody(PostComandaBody body)
        {
            return new Comanda
            {
                IdUsuario = body.IdUsuario,
                NomeUsuario = body.NomeUsuario,
                TelefoneUsuario = body.TelefoneUsuario,
                Produtos = body.Produtos.Select(ProdutoAdapter.FromBody).ToList()
            };
        }
    }
}
