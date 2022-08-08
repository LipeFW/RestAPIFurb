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

        public Comanda GetById(int id)
        {
            return _db.Comandas.FirstOrDefault(x => x.Id == id);
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
    }
}
