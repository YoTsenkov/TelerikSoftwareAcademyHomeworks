namespace AnimalLibrary
{
    using System;
    public class Tomcat : Cat
    {
        public Tomcat()
        {
            this.Sex = "female";
        }
        public Tomcat(string name, int age)
        {
            this.Name = name;
            this.Sex = "female";
            this.Age = age;
        }

        public new string Sex
        {
            get
            {
                return this.Sex;
            }
            private set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    this.sex = value;
                }
                else
                {
                    throw new ArgumentException("Invalid Sex");
                }
            }
        }
    }
}
