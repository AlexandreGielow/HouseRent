using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using TheCoffee.src.Domain.Model.Store;

namespace TheCoffee.src.Domain.Model.Person
{
    public enum PersonType
    {
        Owner, Manager, Admin,Visitor
    }
    public class Person
    {
        [Key]
        public int Id { get; set; }

        public int IdentityUserId { get; set; }
        public required string Name { get; set; }
        public required string SureName { get; set; }
        ICollection<Store.Store>? Stores { get; set; }
        public required PersonType PersonType { get; set; }
        public required string Email { get; set; }
        public bool ValidUser { get; set; }
        public Address? Address { get; set; }

    }
}