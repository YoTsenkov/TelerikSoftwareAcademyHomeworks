namespace HumanLibrary
{
    public class Worker : Human
    {
        public Worker()
        {
        }
        public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
        public int WeekSalary { get; set; }
        public int WorkHoursPerDay { get; set; }

        public int MoneyPerHour()
        {
            return (WeekSalary / 5) / WorkHoursPerDay;
        }
    }
}
