namespace SchoolProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        private int id;
        private string name;
        private IList<Course> courses;

        public Student(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            this.Courses = new List<Course>();
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (value < 10000 || value > 99999)
                {
                    throw new ArgumentException("Student id must be between 10 000 and 99 999");
                }

                this.id = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Student name cant be null or empty");
                }

                this.name = value;
            }
        }

        public IList<Course> Courses
        {
            get
            {
                return this.courses;
            }
            private set
            {
                this.courses = value;
            }
        }

        public void JoinCourse(Course course)
        {
            this.Courses.Add(course);
            course.AddStudent(this);
        }

        public void LeaveCourse(Course course)
        {
            this.Courses.Remove(course);
            course.RemoveStudent(this);
        }
    }
}
