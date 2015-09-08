namespace SchoolTask
{
    using System.Collections.Generic;
    public class Teachers : Person,ICommentable
    {
       // private string p1;
        private Disciplines discipline;
        //private string p2;
        
        public Teachers (string name,List<Disciplines> discipline,string comment):base(name)
        {
            this.Disciplines = discipline;
            this.Comment = comment;
        }       
        public string Comment { get; set; }
        public List<Disciplines> Disciplines { get; set; }
    }
}
