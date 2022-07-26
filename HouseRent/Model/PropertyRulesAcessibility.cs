using System.ComponentModel.DataAnnotations;


namespace HouseRent.Model
{
    public class PropertyRulesAcessibility
    {
        [Key]
        public int Id  { get; set; }
        public string Name { get; set; }
        public  Property Property { get; set; }

    }
}
