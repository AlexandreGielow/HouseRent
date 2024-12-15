using TheCoffee.src.Domain.Model.Person;
using TheCoffee.src.Domain.Model.Order;

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TheCoffee.src.Domain.Model.Order
{
    public enum OrderStatus
    {
        Draft,Ready, Pending, Processing, Delivered, Finished, Cancelled
    }
    public enum ShippingMethod
    {
        Standard, Express, ByHand
    }
    
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public Store.Store? Store { get; set; }
        public Person.Person? Person { get; set; }
        public DateTime DateTime { get; set; } 
        public DateTime ShipDateTime { get; set; }  
        public double TotalPrice { get; set; }  
        public double TotalDiscount { get; set; }
        public ShippingMethod ShippingMethod { get; set; }        
        public OrderStatus OrderStatus {  get; set; }          
        public string? Notes { get; set; }           
        public ICollection<OrderItem>? Items { get; set; }

    }
}
