namespace TheCoffee.src.User_Interface.Contracts.DTOs
{
    public record struct ProductCreate
    {
        public string Email { get;set; }
        public string Password { get; set; }
    }
}
