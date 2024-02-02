using System;
namespace CustomerAccountManager.Models
{
	public class Address
	{
		public Address()
		{
		}

        public int AddressID { get; set; }
        public int CustomerID { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        // Navigation property
        public Customer Customer { get; set; }
    }
}

