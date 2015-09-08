namespace SchoolTask
{
    using System.Collections.Generic;
    public class Classes : ICommentable
    {
        //Constructor
        public Classes (string textIdentifier)
        {
            this.TextIdentifier = textIdentifier;
        }

        //Properties
        public string TextIdentifier { get; set; }
        public string Comment { get; set; }
        public List<Teachers> setOfTeachers { get; set; }
        public List<Student> setOfStudents { get; set; }
       
    }
}
