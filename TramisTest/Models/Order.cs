using System;
using System.Collections.Generic;

namespace TramisTest.Models
{
    public class Order
    {
        public string OrderId { get; set; }
        public DateTime DateOfCreation { get; set; }
        public string Client { get; set; }
        public string Provider { get; set; }
        public string Broker { get; set; }
        public int ReceiverId { get; set; }   
        public string Forwarder { get; set; }
        public string Agent { get; set; }
        public string InvoiceNumber { get; set; }
    
        public Receiver Receiver { get; set; } //navigation property(relation one to many with Receiver)
        public List<OrderProduct> Products { get; set; } //navigation property(relation one to many with OrderProduct)
        public Documents Documents { get; set; } //navigation property(relation one to one with Documents)
        public Shipment Shipment { get; set; } //navigation property(relation one to one with Shipment)
        public Receiving Receiving { get; set; } //navigation property(relation one to one with Receiving)
        public Customs Customs { get; set; } //navigation property(relation one to one with Customs)
        public List<OrderDeclaration> Declarations { get; set; } //navigation property(relation one to many with OrderDeclaration)
    }
}