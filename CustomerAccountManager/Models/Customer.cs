using System;
namespace CustomerAccountManager.Models
{
	public class Customer
	{
		public Customer()
		{
		}

        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime RegistrationDate { get; set; }

        // Navigation property
        public List<Address> Addresses { get; set; }
        public List<Account> Accounts { get; set; }
    }
}

