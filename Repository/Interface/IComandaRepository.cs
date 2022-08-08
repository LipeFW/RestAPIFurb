using RestAPIFurb.Models;
using RestAPIFurb.Models.Dto.Comanda;

namespace RestAPIFurb.Repository.Interface
{
    public interface IComandaRepository
    {
        Comanda Post(PostComandaBody body);
        Comanda GetById(int id);
    }
}
