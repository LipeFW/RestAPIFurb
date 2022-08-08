using Microsoft.EntityFrameworkCore;
using RestAPIFurb.Models;
using RestAPIFurb.Models.Adapter;
using RestAPIFurb.Models.Dto.Comanda.Get;
using RestAPIFurb.Models.Dto.Comanda.Post;
using RestAPIFurb.Models.Dto.Comanda.Put;
using RestAPIFurb.Repository.Interface;

namespace RestAPIFurb.Repository
{
    public class ComandaRepository : IComandaRepository
    {
        private readonly _DbContext _db;

        public ComandaRepository(_DbContext db)
        {
            _db = db;
        }

        public bool Delete(int id)
        {
            var comandaToRemove = _db.Comandas.Find(id);

            if (comandaToRemove != null)
            {
                _db.Comandas.Remove(comandaToRemove);
                _db.SaveChanges();
                return true;
            }
            return false;

        }

        public ICollection<GetAllComandaResponseDto> GetAll()
        {
            var result = _db.Comandas.Include(c => c.Produtos).Select(ComandaAdapter.FromDomainToGetAllComandaResponseDto).ToList();
            return result;
        }

        public GetComandaByIdResponseDto? GetById(int id)
        {
            var result = _db.Comandas.Include(c => c.Produtos).FirstOrDefault(x => x.Id == id);

            if (result == null)
                return null;

            return ComandaAdapter.FromDomainToGetComandaByIdResponseDto(result);
        }

        public PostComandaResponsePayloadDto Post(PostComandaRequestDto comandaBody)
        {
            try
            {
                var comanda = ComandaAdapter.FromBody(comandaBody);

                _db.Comandas.Add(comanda);
                _db.SaveChanges();

                return ComandaAdapter.FromDomainToPostComandaResponseDto(comanda, StatusCodes.Status200OK);
            }
            catch (Exception)
            {
                return ComandaAdapter.FromDomainToPostComandaResponseDto(new Comanda(), StatusCodes.Status400BadRequest);

            }
        }

        public bool Put(int id, PutComandaRequestDto body)
        {
            try
            {
                var comandaToUpdate = _db.Comandas.Include(c => c.Produtos).FirstOrDefault(c => c.Id == id);

                if (comandaToUpdate == null)
                    return false;

                foreach (var produto in body.Produtos)
                {
                    var produtoToUpdate = comandaToUpdate.Produtos.FirstOrDefault(x => x.Id == produto.Id);

                    if (produtoToUpdate == null)
                        break;

                    if ((produto.Preco >= 0) && produtoToUpdate.Preco != produto.Preco)
                        produtoToUpdate.Preco = produto.Preco;

                    if (!string.IsNullOrWhiteSpace(produto.Nome) && produtoToUpdate.Nome != produto.Nome)
                        produtoToUpdate.Nome = produto.Nome;

                    _db.SaveChanges();
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
