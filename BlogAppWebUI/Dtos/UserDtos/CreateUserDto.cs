namespace BlogAppWebUI.Dtos.UserDtos
{
    public class CreateUserDto
    {
        public string? UserEmail { get; set; }
        public string? UserPassword { get; set; }
        public bool UserStatus { get; set; } = true;
    }
}
