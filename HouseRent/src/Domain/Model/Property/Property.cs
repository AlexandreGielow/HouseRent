﻿using System.ComponentModel.DataAnnotations;

namespace HouseRent.src.Domain.Model.Property
{
    public enum PropertyType
    {
        RoomInHouse, House, Apartment
    }
    public enum PropertyStatus
    {
        Active, Inactive, Expired
    }

    public enum RentalType
    {
        LongTerm, ShortTerm
    }
    public class Property
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public RentalType RentalType { get; set; }
        public PropertyStatus Status { get; set; }
        public Domain.Model.Person.Person Person { get; set; }
        public DateTime? StartRent { get; set; }
        public DateTime? EndRent { get; set; }
        public double Value { get; set; }
        public int Size { get; set; }
        public int Rooms { get; set; }
        public bool Furnished { get; set; }
        public int Accommodates { get; set; }
        public string Description { get; set; }
        public PropertyType Type { get; set; }
        public Address? Address { get; set; }
        public ICollection<PropertyHighlights>? Highlights { get; set; }
        public ICollection<PropertyRulesAcessibility>? RulesAcessibilitiy { get; set; }
        public ICollection<Amenities>? Amenities { get; set; }
        public ICollection<Photos>? Photos { get; set; }

    }
}
