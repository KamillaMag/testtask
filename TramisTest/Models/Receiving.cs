using System;

namespace TramisTest.Models
{
    public class Receiving
    {
        public string OrderId { get; set; }
        public Order Order { get; set; }//navigation property(relation one to one with Order)
        public string Storehouse { get; set; }
        public string Line { get; set; }
        public string ContainerNumber { get; set; }
        public string ContainerType { get; set; }
        public string ReceivingType { get; set; }
        public DateTime ReceivingDate { get; set; }
    }
}