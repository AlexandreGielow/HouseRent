using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;


namespace TheCoffee.src.Domain.Model.Store
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public int CountryCode { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int StateCode { get; set; }
        public int StoreId { get; set; }
        [JsonIgnore]
        public Store Store { get; set; }
        public string AddressName { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string Neighborhood { get; set; }
    }
}
