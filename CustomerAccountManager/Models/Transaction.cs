using System;
namespace CustomerAccountManager.Models
{
	public class Transaction
	{
		public Transaction()
		{
		}

        public int TransactionID { get; set; }
        public int AccountID { get; set; }
        public decimal TransactionAmount { get; set; }
        public string TransactionType { get; set; }
        public DateTime TransactionDate { get; set; }

        // Navigation property
        public Account Account { get; set; }
    }
}

