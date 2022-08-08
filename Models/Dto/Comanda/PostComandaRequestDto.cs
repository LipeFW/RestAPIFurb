namespace RestAPIFurb.Models.Dto.Comanda
{
    public class PostComandaRequestDto
    {
        public int IdUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string TelefoneUsuario { get; set; }
        public ICollection<PostProdutoRequestDto> Produtos { get; set; }
    }
}
