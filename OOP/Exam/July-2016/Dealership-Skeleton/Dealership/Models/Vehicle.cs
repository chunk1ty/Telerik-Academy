namespace Dealership.Models
{
    using Common.Enums;
    using Contracts;
    using Dealership.Common;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Vehicle : IVehicle, ICommentable
    {
        private const string MakeProperty = "Make";
        private const string ModelProperty = "Model";
        private const string PriceProperty = "Price";
        private const string WheelsProperty = "Wheels";

        private string make;
        private string model;
        private int wheels;
        private decimal price;
        private IList<IComment> comments;
        private VehicleType type;

        protected Vehicle(string make, string model, decimal price, VehicleType type)
        {
            this.make = make;
            this.model = model;
            this.wheels = (int)type;
            this.price = price;
            this.Type = type;
            this.Comments = new List<IComment>();

            this.FieldsValidation();
        }

        public IList<IComment> Comments
        {
            get
            {
                return this.comments;
            }
            private set
            {
                this.comments = value;
            }
        }

        public string Make
        {
            get
            {
                return this.make;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
        }

        public VehicleType Type
        {
            get
            {
                return this.type;
            }
            protected set
            {
                this.type = value;
            }
        }

        public int Wheels
        {
            get
            {
                return this.wheels;
            }
        }

        private void FieldsValidation()
        {
            Validator.ValidateIntRange(this.wheels, Constants.MinWheels, Constants.MaxWheels, string.Format(Constants.NumberMustBeBetweenMinAndMax, WheelsProperty, Constants.MinWheels, Constants.MaxWheels));

            Validator.ValidateNull(this.make, string.Format(Constants.PropertyCannotBeNull, MakeProperty));
            Validator.ValidateIntRange(this.make.Length, Constants.MinMakeLength, Constants.MaxMakeLength, string.Format(Constants.StringMustBeBetweenMinAndMax, MakeProperty, Constants.MinMakeLength, Constants.MaxMakeLength));

            Validator.ValidateNull(this.model, string.Format(Constants.PropertyCannotBeNull, ModelProperty));
            Validator.ValidateIntRange(this.model.Length, Constants.MinModelLength, Constants.MaxModelLength, string.Format(Constants.StringMustBeBetweenMinAndMax, ModelProperty, Constants.MinModelLength, Constants.MaxModelLength));

            Validator.ValidateDecimalRange(this.price, Constants.MinPrice, Constants.MaxPrice, string.Format(Constants.NumberMustBeBetweenMinAndMax, PriceProperty, Constants.MinPrice, Constants.MaxPrice));

        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendLine(string.Format("{0}:", this.GetType().Name));
            builder.AppendLine(string.Format("  {0}: {1}", MakeProperty, this.Make));
            builder.AppendLine(string.Format("  {0}: {1}", ModelProperty, this.Model));
            builder.AppendLine(string.Format("  {0}: {1}", WheelsProperty, this.Wheels));
            builder.AppendLine(string.Format("  {0}: ${1}", PriceProperty, this.Price));
            builder.AppendLine(this.PrintSpecificInformation());
            builder.AppendLine(this.PrintComments());

            return builder.ToString().TrimEnd();
        }

        private string PrintComments()
        {
            var builder = new StringBuilder();

            if (this.Comments.Count <= 0)
            {
                builder.AppendLine(string.Format("{0}", "    --NO COMMENTS--"));
            }
            else
            {
                builder.AppendLine(string.Format("{0}", "    --COMMENTS--"));

                foreach (var comment in this.Comments)
                {
                    builder.AppendLine(comment.ToString());
                }

                builder.AppendLine(string.Format("{0}", "    --COMMENTS--"));
            }

            return builder.ToString().TrimEnd();
        }

        protected abstract string PrintSpecificInformation();
    }
}
