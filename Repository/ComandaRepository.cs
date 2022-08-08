using Microsoft.EntityFrameworkCore;
using RestAPIFurb.Models;
using RestAPIFurb.Models.Adapter;
using RestAPIFurb.Models.Dto.Comanda;
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

        public ICollection<GetComandaResponseDto> GetAll()
        {
            var result = _db.Comandas.Include(c => c.Produtos).Select(ComandaAdapter.FromDomain).ToList();
            return result;
        }

        public GetComandaResponseDto? GetById(int id)
        {
            var result = _db.Comandas.Include(c => c.Produtos).Select(ComandaAdapter.FromDomain).FirstOrDefault(x => x.Id == id);
            return result;
        }

        public GetComandaResponseDto Post(PostComandaRequestDto comandaBody)
        {
            try
            {
                var comanda = ComandaAdapter.FromBody(comandaBody);

                _db.Comandas.Add(comanda);
                _db.SaveChanges();

                return ComandaAdapter.FromDomain(comanda);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public GetComandaResponseDto Put(int id, PostComandaRequestDto body)
        {
            throw new NotImplementedException();
        }
    }
}
