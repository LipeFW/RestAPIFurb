namespace RestAPIFurb.Models.Dto.Comanda
{
    public class PostComandaBody
    {
        public int IdUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string TelefoneUsuario { get; set; }
        public Produto[] Produtos{ get; set; }
    }
}
