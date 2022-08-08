namespace RestAPIFurb.Models.Dto.Comanda
{
    public class GetComandaResponseDto
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string TelefoneUsuario { get; set; }
        public ICollection<GetProdutoResponseDto> Produtos { get; set; }
    }
}
