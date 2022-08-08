using RestAPIFurb.Models;
using RestAPIFurb.Models.Dto.Comanda;

namespace RestAPIFurb.Repository.Interface
{
    public interface IComandaRepository
    {
        Comanda Get();
        Comanda? GetById(int id);
        Comanda Post(PostComandaBody body);
        Comanda Put(int id, PostComandaBody body);
        bool Delete(int id);
    }
}
