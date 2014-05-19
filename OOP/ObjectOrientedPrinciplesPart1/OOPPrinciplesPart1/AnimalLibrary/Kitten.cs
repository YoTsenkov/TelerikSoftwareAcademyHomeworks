namespace AnimalLibrary
{
    using System;
    public class Kitten : Cat
    {
        public Kitten()
        {
            this.Sex = "female";
        }
        public Kitten(string name, int age)
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
