namespace Car.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Dealer
    {
        private ICollection<City> cities;
        private ICollection<CarClass> cars;

        public Dealer()
        {
            this.cities = new HashSet<City>();
            this.cars = new HashSet<CarClass>();
        }

        public int DealerId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public virtual ICollection<City> Cities 
        { 
            get
            {
                return this.cities;
            }
            set
            {
                this.cities = value;
            }
        }

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
