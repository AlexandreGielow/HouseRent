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
        public int State  { get; set; }

        public int PropertyId { get; set; }
        public Property Property { get; set; }




}
}
