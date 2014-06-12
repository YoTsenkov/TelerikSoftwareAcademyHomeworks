namespace SchoolProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Course
    {
        const int MaxStudents = 29;
        private IList<Student> students;

        public Course()
        {
            this.Students = new List<Student>();
        }

        public Course(IList<Student> students)
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
                if (value.Count > MaxStudents)
                {
                    throw new ArgumentException("The students in a single course should be less than 30");
                }

                this.students = value;
            }
        }

        public void AddStudent(Student student)
        {
            if (this.Students.Count == MaxStudents)
            {
                throw new InvalidOperationException("Cant add new student because the course is full");
            }

            this.students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (this.Students.Count == 0)
            {
                throw new InvalidOperationException("Cant remove student because the course is empty");
            }

            this.students.Remove(student);
        }
    }
}
