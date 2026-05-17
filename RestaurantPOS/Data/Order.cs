using SQLite;

namespace RestaurantPOS.Data
{
    public class Order
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int TotalItemCount { get; set; }
        public decimal TotalAmount { get; set; }
        public string PaymentMode { get; set; }
    }


}
