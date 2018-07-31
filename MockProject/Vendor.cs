using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockProject {
	class Vendor {
		public int Id { get; set; }
		public string Code { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Zip { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
		public bool IsPreApproved { get; set; }
		public bool Active { get; set; }

		public Product AddProduct(string Name, string VendorPartNumber, double Price, string Unit, string PhotoPath, string Vendor) {
			Product prod = new Product();
			prod.Name = Name;
			prod.VendorPartNumber = VendorPartNumber;
			prod.Price = Price;
			prod.Unit = Unit;
			prod.PhotoPath = PhotoPath;
			prod.Vendor = Vendor;
			return prod;
		}
	}
}
