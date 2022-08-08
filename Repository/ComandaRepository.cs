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

        public ICollection<Comanda> GetAll()
        {
            var result = _db.Comandas.Include(c => c.Produtos).ToList();
            return result;
        }

        public Comanda? GetById(int id)
        {
            var result = _db.Comandas.Include(c => c.Produtos).FirstOrDefault(x => x.ComandaId == id);
            return result;
        }

        public Comanda Post(PostComandaBody comandaBody)
        {
            try
            {
                var comanda = ComandaAdapter.FromBody(comandaBody);

                _db.Comandas.Add(comanda);
                _db.SaveChanges();

                return comanda;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Comanda Put(int id, PostComandaBody body)
        {
            throw new NotImplementedException();
        }
    }
}
