namespace SchoolTask
{
    public class Student : Person,ICommentable
    {
        public Student(string name,int uniqueNumber) : base(name)
        {
            this.UniqueNumber = uniqueNumber;
        }
        public Student(string name, int uniqueNumber,string comment) : this(name,uniqueNumber)
        {
            this.Comment = comment;
        }
        public int UniqueNumber { get; private set; }
        public string Comment { get; set; }
    }
}
