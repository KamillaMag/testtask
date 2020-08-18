using System;

namespace TramisTest.Models
{
    public class Documents
    {
        public string OrderId { get; set; }
        public Order Order { get; set; }//navigation property(relation one to one with Order)
        public string BillOfLading { get; set; }
        public DateTime Telex { get; set; }
        public DateTime CommercialDocumentsPreparation { get; set; }
        public DateTime SendingDocumentsDate { get; set; }
        public DateTime ReceivingDocumentsDate { get; set; }
    }
}