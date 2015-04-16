namespace ObjectStateValidator.Anotations
{
    using System;
    using System.Collections;

    public class ElementsAttribute : ValidationAttribute
    {
        private int maxCount;

        public ElementsAttribute(int maxCount)
        {
            this.maxCount = maxCount;
            this.ErrorMessage = "{0} should have maximum of " + maxCount + "elements";
        }

        public int MicCount { get; set; }

        public override bool Validate(object obj)
        {
            if (obj is string)
            {
                string objAsString = (string)obj;

                if (this.MicCount <= objAsString.Length && objAsString.Length <= maxCount)
                {
                    return true;
                }
            }

            if (obj is ICollection)
            {
                var collection = (ICollection)obj;

                if (this.MicCount <= collection.Count && collection.Count <= maxCount)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
