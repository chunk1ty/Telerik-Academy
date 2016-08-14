namespace Dealership.Models
{
    using Common;
    using Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Comment : IComment
    {      
        private readonly string content;

        public Comment(string content)
        {
            this.content = content;

            this.FiltersValidation();
        }

        public string Content
        {
            get
            {
                return this.content;
            }
        }

        public string Author { get; set; }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendLine(string.Format("{0}", "    ----------"));
            builder.AppendLine("    " + this.Content);
            builder.AppendLine("      User: " + this.Author);
            builder.Append(string.Format("{0}", "    ----------"));

            return builder.ToString();
        }

        private void FiltersValidation()
        {
            Validator.ValidateNull(this.content, string.Format(Constants.PropertyCannotBeNull, "Content"));
            Validator.ValidateIntRange(this.content.Length, Constants.MinCommentLength, Constants.MaxCommentLength, string.Format(Constants.StringMustBeBetweenMinAndMax, "Content", Constants.MinCommentLength, Constants.MaxCommentLength));
        }
    }
}
