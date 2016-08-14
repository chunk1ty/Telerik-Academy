namespace Dealership.Models
{
    using Common;
    using Common.Enums;
    using Contracts;

    public class Truck : Vehicle, ITruck
    {
        private const string WeightCapacityPropery = "Weight capacity";

        private int weightCapacity;

        public Truck(string make, string model, decimal price, int weightCapacity) 
            : base(make, model, price, VehicleType.Truck)
        {
            this.weightCapacity = weightCapacity;

            this.FieldsValidation();
        }

        public int WeightCapacity
        {
            get
            {
                return this.weightCapacity;
            }
        }

        protected override string PrintSpecificInformation()
        {
            return string.Format("  Weight Capacity: {0}t", this.WeightCapacity);
        }

        private void FieldsValidation()
        {
            Validator.ValidateIntRange(this.weightCapacity, Constants.MinCapacity, Constants.MaxCapacity, string.Format(Constants.NumberMustBeBetweenMinAndMax, WeightCapacityPropery, Constants.MinCapacity, Constants.MaxCapacity));

        }
    }
}
