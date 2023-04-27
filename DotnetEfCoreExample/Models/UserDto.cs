namespace DotnetEfCoreExample.Models
{
    public class UserDto
    {
        public required string UserName { get; set; }
        public required string PasswordHash { get; set; }=string.Empty;
        public string Password { get; internal set; }
    }
}
