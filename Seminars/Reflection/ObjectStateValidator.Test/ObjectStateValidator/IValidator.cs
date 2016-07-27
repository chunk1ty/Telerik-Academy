namespace ObjectStateValidator
{
    using System.Collections.Generic;

    public interface IValidator
    {
        void Validate();

        bool Isvalid { get; }

        IDictionary<string, IList<string>> Errors { get; }
    }
}
