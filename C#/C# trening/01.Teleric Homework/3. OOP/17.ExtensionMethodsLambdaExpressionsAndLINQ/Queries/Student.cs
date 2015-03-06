namespace Queries
{
    using System.Collections.Generic;
    using System.Text;
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
       // public byte Age { get; set; }
        public int FN { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public List<int> Mark { get; set; }
        public int GroupNumber { get; set; }
        public Student (string firstName,string lastName,int fn,string tel,string email,List<int> mark, int groupnumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fn;
            this.Tel = tel;
            this.Email = email;
            this.Mark = mark;
            this.GroupNumber = groupnumber;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.FirstName + " ");
            sb.Append(this.LastName + " ");
            //sb.Append(this.Age);
            sb.Append(this.FN + " ");
            sb.Append(this.Tel + " ");
            sb.Append(this.Email + " ");
            sb.Append(string.Join(" ",this.Mark));
            sb.Append(" "+this.GroupNumber);
            return sb.ToString();
        }
    }
}
