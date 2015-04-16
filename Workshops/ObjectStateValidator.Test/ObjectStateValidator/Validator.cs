namespace ObjectStateValidator
{
    using ObjectStateValidator.Anotations;
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Validator : IValidator
    {
        private object validatableObject;
        private bool? objectValidated;
        private IDictionary<string, IList<string>> errors;

        public Validator(object validatableObject)
        {
            if (validatableObject == null)
            {
                throw new ArgumentNullException("INvalida object");
            }
            this.validatableObject = validatableObject;
            this.errors = new Dictionary<string, IList<string>>();
        }

        public void Validate()
        {
            this.objectValidated = true;
            this.Validate(validatableObject, string.Empty);
        }

        public bool Isvalid
        {
            get
            {
                if (!this.objectValidated.HasValue)
                {
                    throw new InvalidOperationException("You must invoke the Validate() method first");
                }

                return this.errors.Count == 0;
            }
        }

        public IDictionary<string, IList<string>> Errors
        {
            get
            {
                return this.errors;
            }
        }

        private void Validate(object obj, string name)
        {
            if (validatableObject == null)
            {
                return;
            }

            var type = obj.GetType();

            foreach (var property in type.GetProperties())
            {
                var propertyName = property.Name;                
                var valueToValidate = property.GetValue(obj);
                var validationAttributes = property.GetCustomAttributes(typeof(ValidationAttribute), true);

                foreach (var validationAttr in validationAttributes)
                {                    
                    var attrAsValidationAttr = ((ValidationAttribute)validationAttr);
                    var validatoinResult = attrAsValidationAttr.Validate(valueToValidate);

                    if (!validatoinResult)
                    {
                        var errorMsg = attrAsValidationAttr.ErrorMessage;
                        this.AddError(name  + propertyName, string.Format(errorMsg, name + propertyName));
                    }
                }

                if (valueToValidate != null  && !(valueToValidate is ICollection) && !(valueToValidate is string))
                {
                    this.Validate(valueToValidate, propertyName + '.');
                }
            }
        }

        private void AddError(string name, string error)
        {
            if (!this.errors.ContainsKey(name))
            {
                this.errors.Add(name, new List<string>());
            }

            this.errors[name].Add(error);
        }
    }
}
