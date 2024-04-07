using HouseRent.src.Domain.Model.Person;

namespace HouseRent.src.User_Interface.Contracts.Requests
{
    public class PersonRegistrationRequest
    {
        public string Name { get; set; }
        public string SureName { get; set; }
        public PersonType PersonType { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
