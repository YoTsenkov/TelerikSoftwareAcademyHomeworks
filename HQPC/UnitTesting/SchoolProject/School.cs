namespace SchoolProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class School
    {
        private IList<Student> students;

        public School()
        {
            this.Students = new List<Student>();
        }

        public School(IList<Student> students)
        {
            this.Students = students;
        }

        public IList<Student> Students
        {
            get
            {
                return this.students;
            }
            private set
            {
                this.students = value;
            }
        }

        public void AddStudent(Student student)
        {
            bool studentAlreadyExists = this.Students.Any(st => st.Id == student.Id);
            if (studentAlreadyExists)
            {
                throw new InvalidOperationException("The student already exists in this school");
            }

            this.Students.Add(student);
        }
    }
}
