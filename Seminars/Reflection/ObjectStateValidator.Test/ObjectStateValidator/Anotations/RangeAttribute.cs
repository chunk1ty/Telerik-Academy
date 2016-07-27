namespace ObjectStateValidator.Anotations
{
    using System;   

    public class RangeAttribute : ValidationAttribute
    {
        private int min;
        private int max;

        public RangeAttribute(int min, int max)
        {
            this.min = min;
            this.max = max;
            this.ErrorMessage = "{0} should be between " + min + "and " + max;
        }

        public override bool Validate(object obj)
        {
            //If i want my validator to work with decimal i have to do the same 
            if (obj is int)
            {
                var objAsInt = (int)obj;

                if (min <= objAsInt && objAsInt <= max)
                {
                    return true;
                }               
            }

            return false;
        }
    }
}
