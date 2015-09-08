namespace Car.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CarClass
    {        
        public int CarClassId { get; set; }

        [Required]
        [MaxLength(20)]
        public string Model { get; set; }

        [Required]
        public TransmissionType TransmissionType { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public decimal Price { get; set; }
        
        [Required]
        public int ManufacturerId { get; set; }        
        
        public virtual Manufacturer Manufacturer { get; set; }

        [Required]
        public int DealerId { get; set; }     

        public virtual Dealer Dealer { get; set; }
    }
}
