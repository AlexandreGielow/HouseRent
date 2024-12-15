using System.ComponentModel.DataAnnotations;
using TheCoffee.src.Domain.Model.Property;
using TheCoffee.src.Domain.Model.Person;

namespace TheCoffee.src.Domain.Model.Store
{
    public enum StoreType
    {
        Rental,Owner
    }
    public enum StoreStatus
    {
        Active, Inactive, Expired
    }

    public class Store
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public StoreStatus Status { get; set; }
        public Person.Person? Person { get; set; }
        public DateTime? StartRent { get; set; }
        public DateTime? EndRent { get; set; }
        public double Value { get; set; }
        public int Size { get; set; }
        public int Rooms { get; set; }
        public bool Furnished { get; set; }
        public string? Description { get; set; }
        public StoreType Type { get; set; }
        public Address? Address { get; set; }
        public ICollection<StoreEquipment>? Highlights { get; set; }
        public ICollection<Photos>? Photos { get; set; }

    }
}
