
namespace _09AndAbove
{
    using System.Collections.Generic;
    public class Student
    {
        //private List<int> marks = new List<int>();
        public Student()
        {
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int FN { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public List<int> Marks { get; set; }        
        public int GroupNumber { get; set; }
        public Group Group { get; set; }
    }
}
