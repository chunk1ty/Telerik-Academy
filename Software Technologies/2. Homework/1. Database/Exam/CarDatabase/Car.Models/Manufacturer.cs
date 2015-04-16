namespace Car.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Manufacturer
    {

        private ICollection<CarClass> cars;

        public Manufacturer()
        {
            this.cars = new HashSet<CarClass>();
        }

        public int ManufacturerId { get; set; }

        [Required]
        [MaxLength(10)]
        //[Index("IX_CityName", 1, IsUnique = true)]
        public string Name { get; set; }

        public virtual ICollection<CarClass> Cars 
        { 
            get
            {
                return this.cars;
            }
            set
            {
                this.cars = value;
            }
        }
    }
}
