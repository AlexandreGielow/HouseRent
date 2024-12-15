namespace TheCoffee.src.User_Interface.Contracts.DTOs
{
    public record struct AuthenticateLogin
    {
        public required string Email { get;set; }
        public required string Password { get; set; }
    }
}
