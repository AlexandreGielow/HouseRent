﻿using System.ComponentModel.DataAnnotations;

namespace HouseRent.Model
{
    public enum PersonType
    {
        Owner,Visitor,Admin
    }
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string SureName  { get; set; }
        ICollection<Property>? Properties { get; set; } 
        public PersonType PersonType { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }//TODO improve the password storage on DB
    }
}