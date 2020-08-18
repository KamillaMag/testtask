namespace TramisTest.Models
{
    public class OrderDeclaration
    {
        public int Id { get; private set; }
        public string OrderId { get; set; }
        public Order Order { get; set; }//navigation property(relation one to many with Order)
        public string DeclarationNumber { get; set; }
        public Declaration Declaration { get; set; } //navigation property(relation one to many with Declaration)
    }
}