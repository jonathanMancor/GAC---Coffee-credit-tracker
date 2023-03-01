using Coffee_Project.Data;

namespace Coffee_Project.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DrinkType DrinkType { get; set; }
        public int Count { get; set; }
    }
}
