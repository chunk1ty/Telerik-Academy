namespace Dealership.Models
{
    using Common;
    using Common.Enums;
    using Dealership.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Car : Vehicle, ICar
    {
        private const string SeatsProperty = "Seats";

        private int seats;

        public Car(string make, string model, decimal price, int seats) 
            : base(make, model, price, VehicleType.Car)
        {
            this.seats = seats;

            this.FieldsValidation();
        }

        public int Seats
        {
            get
            {
                return this.seats;
            }
        }

        protected override string PrintSpecificInformation()
        {
            return string.Format("  {0}: {1}", "Seats", this.Seats);
        }

        private void FieldsValidation()
        {
            Validator.ValidateIntRange(this.seats, Constants.MinSeats, Constants.MaxSeats, string.Format(Constants.NumberMustBeBetweenMinAndMax, SeatsProperty, Constants.MinSeats, Constants.MaxSeats));

        }
    }
}
