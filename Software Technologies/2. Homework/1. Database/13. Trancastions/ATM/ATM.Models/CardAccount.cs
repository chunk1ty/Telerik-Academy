namespace ATM.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class CardAccount
    {
        public int CardAccountID { get; set; }

        [Required]
        [MaxLength(10)]
        public string CardNumber { get; set; }
        
        [Required]
        [MaxLength(4)]
        public string CardPIN { get; set; }

        [Column(TypeName = "Money")]
        public decimal CardCash { get; set; }
    }
}
