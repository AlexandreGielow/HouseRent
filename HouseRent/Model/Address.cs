using System.ComponentModel.DataAnnotations;


namespace HouseRent.Model
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
        public int PropertyId { get; set; }
        public  Property Property {get; set;}
    }
}
