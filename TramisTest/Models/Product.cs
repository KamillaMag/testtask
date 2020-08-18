using System.Collections.Generic;

namespace TramisTest.Models
{
    public class Product
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public double GrossWeight { get; set; }
        public double Volume { get; set; }
        public double Price { get; set; }

        public List<OrderProduct> Orders { get; set; } //navigation property(relation one to many with OrderProduct)
    }
}