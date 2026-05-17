using SQLite;

namespace RestaurantPOS.Data
{
    public class OrderItem
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public string Icon { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        [Ignore]
        public decimal Amount => Quantity * Price;
    }


}
