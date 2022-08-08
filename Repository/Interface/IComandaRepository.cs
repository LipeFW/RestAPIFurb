using RestAPIFurb.Models;
using RestAPIFurb.Models.Dto.Comanda.Get;
using RestAPIFurb.Models.Dto.Comanda.Post;
using RestAPIFurb.Models.Dto.Comanda.Put;

namespace RestAPIFurb.Repository.Interface
{
    public interface IComandaRepository
    {
        ICollection<GetAllComandaResponseDto> GetAll();
        GetComandaByIdResponseDto? GetById(int id);
        PostComandaResponsePayloadDto Post(PostComandaRequestDto comandaBody);
        bool Put(int id, PutComandaRequestDto body);
        bool Delete(int id);
    }
}
