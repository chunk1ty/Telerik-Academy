namespace HumanProject
{
    public class Student : Human
    {
        private byte grade;
        public Student(string name, string nameLast, byte grade) : base(name, nameLast)
        {
            this.Grade = grade;
        }
        public byte Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                this.grade = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} grade {2}", this.FirstName, this.LastName, this.Grade);
        }
    }
}
