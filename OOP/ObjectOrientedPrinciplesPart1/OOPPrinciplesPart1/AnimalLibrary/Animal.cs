namespace AnimalLibrary
{
    using System;
    using AnimalLibrary;
    public abstract class Animal : ISound
    {
        protected string name;
        protected string sex;

        
        public int Age { get; set; }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("Invalid Name");
                }
            }
        }     
   
        public virtual string Sex
        {
            get
            {
                return this.sex;
            }
            set
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
        public abstract void MakeSound();
    }
}
