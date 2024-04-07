using System.Diagnostics;

namespace HouseRent.src.Domain.Model.Person
{
    public class AuthenticationResult
    {
        public string Token { get; set; }
        public bool Success { get; set; }
        public IEnumerable<string> Error { get; set; }
    }
}
