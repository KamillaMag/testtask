using System;

namespace TramisTest.Models
{
    public class Customs
    {
        public string OrderId { get; set; }
        public Order Order { get; set; } //navigation property(relation one to one with Order)
        public bool BTT { get; set; }
        public DateTime ArrivalDate { get; set; }
        public string HBL { get; set; }
        public DateTime HBLReleaseDate { get; set; }
        public string CustomsPost { get; set; }
        public DateTime CheckDate { get; set; }

    }
}