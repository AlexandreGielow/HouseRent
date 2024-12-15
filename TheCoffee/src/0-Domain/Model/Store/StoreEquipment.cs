using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;


namespace TheCoffee.src.Domain.Model.Property
{
    public enum EquipmentType
    {
        Professional, SemiProfessional, Common
    }
    public class StoreEquipment
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        [JsonIgnore]
        public Store.Store? Property { get; set; }
        public int StoreId { get; set; }
        public required EquipmentType EquipmentType { get; set; }
        public required string Brand { get; set; }
        public required string Type {get; set; }
        public double Cost { get; set; }

    }
}
