using RestAPIFurb.Models.Dto.Comanda.Get;
using RestAPIFurb.Models.Dto.Comanda.Post;

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

        public static GetComandaByIdResponseDto FromDomainToGetComandaByIdResponseDto(Comanda domain)
        {
            return new GetComandaByIdResponseDto
            {
                IdUsuario = domain.IdUsuario,
                NomeUsuario = domain.NomeUsuario,
                TelefoneUsuario = domain.TelefoneUsuario,
                Produtos = domain.Produtos.Select(ProdutoAdapter.FromDomain).ToList()
            };
        }

        public static GetAllComandaResponseDto FromDomainToGetAllComandaResponseDto(Comanda domain)
        {
            return new GetAllComandaResponseDto
            {
                IdUsuario = domain.IdUsuario,
                NomeUsuario = domain.NomeUsuario,
                TelefoneUsuario = domain.TelefoneUsuario,
            };
        }

        public static PostComandaResponsePayloadDto FromDomainToPostComandaResponseDto(Comanda domain, int statusCode)
        {
            return new PostComandaResponsePayloadDto
            {
                StatusCode = statusCode,
                Result =
                    new PostComandaResponseDto
                    {
                        Id = domain.Id,
                        IdUsuario = domain.IdUsuario,
                        NomeUsuario = domain.NomeUsuario,
                        TelefoneUsuario = domain.TelefoneUsuario,
                        Produtos = domain.Produtos.Select(ProdutoAdapter.FromDomain).ToList()
                    }
            };
        }
    }
}
