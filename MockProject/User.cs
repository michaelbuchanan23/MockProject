using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockProject {	
	class User {
		public int Id { get; set; }
		public string Name { get; set; }
		public string Password { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }
		public bool isReviewer { get; set; }
		public bool isAdmin { get; set; }
		public List<PurchaseRequest> PurchaseRequests = new List<PurchaseRequest>(); //uncomment this when we add the PurchaseRequest class


		public Vendor AddVendor(string Code, string Name, string Address, string City, string State, string Zip, string Phone, string Email, bool Recommended) {
			Vendor vend = new Vendor();
			vend.Code = Code;
			vend.Name = Name;
			vend.Address = Address;
			vend.City = City;
			vend.State = State;
			vend.Zip = Zip;
			vend.Phone = Phone;
			vend.Email = Email;
			vend.Recommended = Recommended;
			return vend;
		}

		public User AddUser(int Id, string Name, string Password, string PhoneNumber, string Email, bool isReviewer, bool isAdmin) {
			User user = new User();
			user.Id = Id;
			user.Name = Name;
			user.Password = Password;
			user.PhoneNumber = PhoneNumber;
			user.Email = Email;
			user.isReviewer = isReviewer;
			user.isAdmin = isAdmin;
			return user;
		}

		public PurchaseRequest AddPurchaseRequest (int Id, string Description, string Justification, DateTime DateNeeded, string DeliveryMode, bool DocsAttached, string Status, int Total, string User) {
			PurchaseRequest purchaseRequest = new PurchaseRequest();
			purchaseRequest.Id = Id;
			purchaseRequest.Description = Description;
			purchaseRequest.Justification = Justification;
			purchaseRequest.DateNeeded = DateNeeded;
			purchaseRequest.DeliveryMode = DeliveryMode;
			purchaseRequest.DocsAttached = DocsAttached;
			purchaseRequest.Status = Status;
			purchaseRequest.Total = Total;
			purchaseRequest.User = User;
			return purchaseRequest;
		}
	}
}
