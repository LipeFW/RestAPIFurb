using Microsoft.EntityFrameworkCore;
using RestAPIFurb.Models;
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
            var comandaToRemove = _db.Comandas.FirstOrDefault(x => x.Id == id);

            if (comandaToRemove != null)
            {
                _db.Comandas.Remove(comandaToRemove);
                _db.SaveChanges();
                return true;
            }
            else
                return false;

        }

        public Comanda Get()
        {
            throw new NotImplementedException();
        }

        public Comanda? GetById(int id)
        {
            var ret = _db.Comandas.Where(x => x.Id == id).Include(x => x.Produtos).FirstOrDefault();
            return ret;
        }

        public Comanda Post(PostComandaBody body)
        {
            try
            {
                var comanda = new Comanda
                {
                    IdUsuario = body.IdUsuario,
                    NomeUsuario = body.NomeUsuario,
                    Produtos = body.Produtos,
                    TelefoneUsuario = body.TelefoneUsuario
                };

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
