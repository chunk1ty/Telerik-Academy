namespace ATM.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    public class TransactionHistory
    {
        public int TransactionHistoryID { get; set; }

        public string CardNumber { get; set; }

        public DateTime? TransactionDate { get; set; }

        [Column(TypeName = "Money")]
        public decimal Amount { get; set; }
    }
}
