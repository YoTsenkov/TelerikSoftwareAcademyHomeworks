namespace AnimalLibrary
{
    using System;
    public abstract class Cat : Animal, ISound
    {
        public Cat()
        {
        }
        public Cat(string name, string sex, int age)
        {
            this.Name = name;
            this.Sex = sex;
            this.Age = age;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Purr purr le meow purr");
        }
    }
}
