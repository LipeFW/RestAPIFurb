namespace RestAPIFurb.Models.Dto.Login
{
    public class LoginResponseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Token { get; set; }

        public LoginResponseDto(int id, string name, string agentToken)
        {
            this.Id = id;
            this.Name = name;
            this.Token = agentToken;
        }
    }
}
