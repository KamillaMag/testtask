namespace TramisTest.Models
{
    public class OrderProduct
    {
        public string Id { get; set; }
        public string OrderId { get; set; }
        public Order Order { get; set; } //navigation property(relation one to many with Order)
        public string ProductId { get; set; }
        public Product Product { get; set; } //navigation property(relation one to many with Product)
    }
}