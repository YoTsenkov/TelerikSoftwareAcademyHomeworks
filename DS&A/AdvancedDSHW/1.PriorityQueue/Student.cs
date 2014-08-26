namespace _1.PriorityQueue
{
    using System;

    public class Student : IComparable<Student>
    {
        private string name;
        private double priority; // Smaller values are higher priority

        public Student(string lastName, double priority)
        {
            this.Name = lastName;
            this.Priority = priority;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Student name cant be null");
                }

                this.name = value;
            }
        }

        public double Priority
        {
            get
            {
                return this.priority;
            }
            private set
            {
                this.priority = value;
            }
        }

        //sloppy implementation i know..just for easier testing :)
        public override string ToString()
        {
            return "(" + this.Name + ", " + this.Priority.ToString("F1") + ")";
        }

        public int CompareTo(Student other)
        {
            if (this.Priority < other.Priority)
            {
                return -1;
            }
            else if (this.priority > other.priority)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
