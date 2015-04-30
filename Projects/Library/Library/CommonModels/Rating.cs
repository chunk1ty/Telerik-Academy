namespace Library
{
    public struct Rating
    {
        private double averageRating;
        
        public Rating(int counter = 0, int totalRatings = 0, double averageRating = 0) 
            :this()
        {
            this.AverageRating = averageRating;
            this.Counter = counter;
            this.TotalRatings = totalRatings;
        }

        public int Counter { get; private set; }
        public int TotalRatings { get; private set; }

        public double AverageRating
        {
            get
            {
                return (double)this.TotalRatings / this.Counter;
            }
            private set
            {
                this.averageRating = value;
            }
        }

        public void ChangeRating(int userRating)
        {
            if (userRating < 0 || userRating > 5)
            {
                throw new LibraryCommonException(LibraryCommonException.ExceptionMessageForRatingPoints);                
            }
            this.IncreaseCounter();
            this.IncreaseTotalRatings(userRating);
            
        }

        private void IncreaseCounter()
        {
            this.Counter++;
        }

        private void IncreaseTotalRatings(int userRating)
        {
            this.TotalRatings += userRating;
        }

        public override string ToString()
        {
            return string.Format("|{0}|{1}|{2}", this.Counter, this.TotalRatings, this.averageRating);
        }
    }
}
