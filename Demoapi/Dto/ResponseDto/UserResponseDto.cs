namespace Practice.Dto
{
    public class UserResponseDto
    {
        public string UserId {get; set;}
        public string Token { get; set; }
        public string Email {get; set; }
        public string Role { get; set; }
        public string UserName { get; internal set; }
    }
}