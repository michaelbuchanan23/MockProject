using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockProject {
	class PurchaseRequest {
		public int Id { get; set; }
		public string Description { get; set; }
		public string Justification { get; set; }
		public DateTime DateNeeded { get; set; }
		public string DeliveryMode { get; set; }
		public bool DocsAttached { get; set; }
		public string Status { get; set; }
		public int Total { get; set; }
		public string User { get; set; }
		public List<Product> Products = new List<Product>(); //creates a new dynamic array for assigning products to this vendor for the Student class
	}
}
