namespace SchoolTask
{
    public class Disciplines : ICommentable
    {
        public Disciplines(string name,int numOfLecture,int numOfExersice,string comment)
        {
            this.Name = name;
            this.NumOfLecture = numOfLecture;
            this.NumOfExersice = numOfExersice;
            this.Comment = comment;
        }
        public string Name { get; set; }
        public int NumOfLecture { get; set; }
        public int NumOfExersice { get; set; }
        public string Comment { get; set; }
    }
}
