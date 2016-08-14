namespace Dealership.Models
{
    using Common;
    using Common.Enums;
    using Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Motorcycle : Vehicle, IMotorcycle
    {
        private const string CategoryProperty = "Category";

        private string category;

        public Motorcycle(string make, string model, decimal price, string category) 
            : base(make, model, price, VehicleType.Motorcycle)
        {
            this.category = category;

            this.FieldsValidation();
        }

        public string Category
        {
            get
            {
                return this.category;
            }
        }

        protected override string PrintSpecificInformation()
        {
            return string.Format("  {0}: {1}", "Category", this.Category);
        }

        private void FieldsValidation()
        {
            Validator.ValidateNull(this.category, string.Format(Constants.PropertyCannotBeNull, CategoryProperty));
            Validator.ValidateIntRange(this.category.Length, Constants.MinCategoryLength, Constants.MaxCategoryLength, string.Format(Constants.StringMustBeBetweenMinAndMax, CategoryProperty, Constants.MinCategoryLength, Constants.MaxCategoryLength));

        }
    }
}
