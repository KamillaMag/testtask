using System;

namespace TramisTest.Models
{
    public class Shipment
    {
        public string OrderId { get; set; }
        public Order Order { get; set; }//navigation property(relation one to one with Order)
        public string ShipmentPlace { get; set; }
        public string ShipmentCountry { get; set; }
        public string Port { get; set; }
        public string ShipmentTerms { get; set; }
        public string SpecialTerms { get; set; }
        public DateTime ReadyDate { get; set; }
        public DateTime LoadingDate { get; set; }
        public DateTime PackingDate { get; set; }
        public DateTime SailingDate { get; set; }
        public DateTime TrainDepartureDate { get; set; }
        public string Comment { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime UnloadingDate { get; set; }
    }
}