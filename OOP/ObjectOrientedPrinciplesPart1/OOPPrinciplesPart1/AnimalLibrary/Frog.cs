namespace AnimalLibrary
{
    using System;
    public class Frog : Animal, ISound
    {
        public Frog()
        {
        }
        public Frog(string name, string sex, int age)
        {
            this.Name = name;
            this.Sex = sex;
            this.Age = age;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Ribbet ribbet ribbet");
        }
    }
}
