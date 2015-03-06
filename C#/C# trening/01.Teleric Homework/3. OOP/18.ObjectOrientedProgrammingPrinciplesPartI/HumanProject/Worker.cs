namespace HumanProject
{
    public class Worker : Human
    {
        public Worker(string name, string nameLast, decimal weekSalary, byte workHoursPerDay)
            : base(name, nameLast)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
        public decimal WeekSalary { get; set; }
        public byte WorkHoursPerDay { get; set; }
        public decimal MoneyPerHour()
        {
            return WeekSalary / (WorkHoursPerDay * 5);
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4:F2}", this.FirstName, this.LastName, this.WeekSalary, this.WorkHoursPerDay,MoneyPerHour());
        }
    }
}
