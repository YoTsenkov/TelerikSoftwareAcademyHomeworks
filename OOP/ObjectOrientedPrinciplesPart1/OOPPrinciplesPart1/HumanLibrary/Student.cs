namespace HumanLibrary
{
    public class Student : Human
    {
        public int grade;

        public Student()
        {
        }
        public Student(string firstName, string lastName, int grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.grade = grade;
        }
    }
}
