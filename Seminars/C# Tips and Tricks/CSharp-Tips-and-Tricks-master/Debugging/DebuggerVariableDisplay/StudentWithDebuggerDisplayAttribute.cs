namespace Debugging.DebuggerVariableDisplay
{
    using System.Diagnostics;

    [DebuggerDisplay("Student named {FirstName} {LastName}")]
    public class StudentWithDebuggerDisplayAttribute : Student
    {
        public StudentWithDebuggerDisplayAttribute(string firstName, string lastName)
            : base(firstName, lastName)
        {
        }

        public override string ToString()
        {
            return string.Format("ToString method for StudentWithDebuggerDisplayAttribute named {0} {1}.", this.FirstName, this.LastName);
        }
    }
}
