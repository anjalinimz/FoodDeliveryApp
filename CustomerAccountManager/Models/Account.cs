using System;
namespace CustomerAccountManager.Models
{
	public class Account
	{
		public Account()
		{
		}

        public int AccountID { get; set; }
        public int CustomerID { get; set; }
        public string AccountType { get; set; }
        public decimal Balance { get; set; }
        public DateTime OpenDate { get; set; }

        // Navigation property
        public Customer Customer { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}

