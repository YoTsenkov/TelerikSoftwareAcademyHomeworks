namespace ATM.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class CardAccount
    {
        public int CardAccountId { get; set; }

        [StringLength(10)]        
        public string CardNumber { get; set; }

        [StringLength(4)]
        public string CardPin { get; set; }

        public decimal CardCash { get; set; }
    }
}
