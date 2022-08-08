using RestAPIFurb.Models;
using RestAPIFurb.Models.Dto.Comanda;

namespace RestAPIFurb.Repository.Interface
{
    public interface IComandaRepository
    {
        ICollection<GetComandaResponseDto> GetAll();
        GetComandaResponseDto? GetById(int id);
        GetComandaResponseDto Post(PostComandaRequestDto comandaBody);
        GetComandaResponseDto Put(int id, PostComandaRequestDto body);
        bool Delete(int id);
    }
}
