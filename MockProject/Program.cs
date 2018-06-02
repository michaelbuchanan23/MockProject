using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockProject {
	class Program {
		static void Main(string[] args) {

			User God = new User();
			God.Id = 1;
			God.Name = "God";
			God.Password = "Password";
			God.PhoneNumber = "555-555-5555";
			God.Email = "god@email.com";
			God.isReviewer = false;
			God.isAdmin = true;

			//Console.WriteLine(God.Name);

			Vendor vendor1 = God.AddVendor("XXCode", "XXName", "XXAddress", "XXCity", "XXState", "XXZip", "XXPhone", "XXEmail", true);
			Console.WriteLine(vendor1.Name, vendor1.Recommended);

			//Product prod1 = new Product();
		}
	}
}
