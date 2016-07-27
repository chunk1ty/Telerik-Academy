namespace Debugging.DebuggerVariableDisplay
{
    public class StudentWithToStringMethod : Student
    {
        public StudentWithToStringMethod(string firstName, string lastName)
            : base(firstName, lastName)
        {
        }

        public override string ToString()
        {
            return string.Format("StudentWithToStringMethod named {0} {1}.", this.FirstName, this.LastName);
        }
    }
}
