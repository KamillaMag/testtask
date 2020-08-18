using System.Collections.Generic;

namespace TramisTest.Models
{
    public class Receiver
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public List<Order> Orders { get; set; }//navigation property(relation one to many with Order)
    }
}