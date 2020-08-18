using System;
using System.Collections.Generic;

namespace TramisTest.Models
{
    public class Declaration
    {
        public string DeclarationNumber { get; set; }
        public DateTime ApplicationDate { get; set; }
        public DateTime IssueDate { get; set; }

        public List<OrderDeclaration> Orders { get; set; } //navigation property(relation one to many with OrderDeclaration)
    }
}