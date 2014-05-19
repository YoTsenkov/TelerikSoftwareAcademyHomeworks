namespace AnimalLibrary
{
    using System;
    public class Dog : Animal, ISound
    {
        public Dog()
        {
        }
        public Dog(string name, string sex, int age)
        {
            this.Name = name;
            this.Sex = sex;
            this.Age = age;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Woof woof");
        }
    }
}
