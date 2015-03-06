namespace MobileInformation
{
    using System;
    public class Call
    {
        //Properties
        public DateTime Date { get; set; }
        public string PhoneNumber { get; set; }
        public int Duration { get; set; }

        //Constructors
        public Call (DateTime date,string phoneNumber,int duration)
        {
            this.Date = date;
            this.PhoneNumber = phoneNumber;
            this.Duration = duration;
        }

        //Methods
        public override string ToString()
        {
            string formatDate = String.Format("{0}",this.Date.ToString("dd.MM.yy"));
            string result = String.Format("Number {0} date {1}  duration {2}", this.PhoneNumber, formatDate, this.Duration);
            return result;
        }
    }
}
