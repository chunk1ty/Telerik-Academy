namespace InvalidRangeExceptionNamespace
{
    using System;
    public class InvalidRangeExeption<T> : ApplicationException where T : IComparable<T>
    {
        public T Start { get; set; }
        public T End { get; set; }
        public InvalidRangeExeption(T startRange, T endRange)
        {
            this.Start = startRange;
            this.End = endRange;
        }

        public InvalidRangeExeption (T startRange, T endRange,string message, Exception e):base(message,e)
        {
            this.Start = startRange;
            this.End = endRange;
        }
    }
}
