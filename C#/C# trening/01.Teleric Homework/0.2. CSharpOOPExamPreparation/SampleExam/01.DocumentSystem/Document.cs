using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem_1
{
    public abstract class Document : IDocument
    {
        public string Name { get; protected set; }
        public string Content { get; protected set; }
        public  virtual void LoadProperty(string key, string value)
        {
            if (key == "name")
            {
                this.Name = value;
            }
            else if (key == "content")
            {
                this.Content = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public virtual void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string,object>("name", this.Name));
            output.Add(new KeyValuePair<string,object>("content", this.Content));
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(this.GetType().Name);
            result.Append('[');
            IList<KeyValuePair<string, object>> attributes = new List<KeyValuePair<string, object>>();
            
            var sortedAttribs = attributes.OrderBy(item => item.Key);
            this.SaveAllProperties(attributes);
            foreach (var attr in sortedAttribs)
            {
                if (attr.Value != null)
                {
                    result.Append(attr.Key);
                    result.Append("=");
                    result.Append(attr.Value);
                    result.Append(";");
                }                
            }
            result.Length--;
            result.Append(']');

            return result.ToString();
        }
    }
}
