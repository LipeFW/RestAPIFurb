using RestAPIFurb.Models.Dto.Comanda;

namespace RestAPIFurb.Models.Adapter
{
    public static class ComandaAdapter
    {
        public static Comanda FromBody(PostComandaRequestDto body)
        {
            return new Comanda
            {
                IdUsuario = body.IdUsuario,
                NomeUsuario = body.NomeUsuario,
                TelefoneUsuario = body.TelefoneUsuario,
                Produtos = body.Produtos.Select(ProdutoAdapter.FromBody).ToList()
            };
        }

        public static GetComandaResponseDto FromDomain(Comanda domain)
        {
            return new GetComandaResponseDto
            {
                Id = domain.Id,
                IdUsuario = domain.IdUsuario,
                NomeUsuario = domain.NomeUsuario,
                TelefoneUsuario = domain.TelefoneUsuario,
                Produtos = domain.Produtos.Select(ProdutoAdapter.FromDomain).ToList()
            };
        }
    }
}
