using RestAPIFurb.Models;
using RestAPIFurb.Models.Dto.Comanda;

namespace RestAPIFurb.Repository.Interface
{
    public interface IComandaRepository
    {
        ICollection<Comanda> GetAll();
        Comanda? GetById(int id);
        Comanda Post(PostComandaBody comandaBody);
        Comanda Put(int id, PostComandaBody body);
        bool Delete(int id);
    }
}
