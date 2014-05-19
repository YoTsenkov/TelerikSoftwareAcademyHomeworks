namespace _03.Animals
{
    using System;
    using System.Linq;

    using AnimalLibrary;
    using System.Collections.Generic;
    public class Animals
    {
        static void Main()
        {
            var animals = new List<ISound>()
            {
                new Dog("Doge", "male", 10),
                new Dog("Doge", "male", 5),
                new Dog("Doge", "male", 3),                
                new Frog("Sildan", "male", 30),
                new Frog("Sildan", "male", 7),
                new Frog("Sildan", "male", 12),
                new Kitten("Sildan", 8),
                new Kitten("Sildan", 4),
                new Kitten("Sildan", 10),
                new Tomcat("Sildan", 3),
                new Tomcat("Sildan", 7),
                new Tomcat("Sildan", 6),
            };

            var avarageAge = animals
                .OfType<Dog>()
                .Average(an => an.Age);


            Console.WriteLine("Dogs' avarage age is " + (int)avarageAge);

            avarageAge = animals
                .OfType<Cat>()
                .Average(an => an.Age);


            Console.WriteLine("Cats' avarage age (Kittens + Tomcats) is " + (int)avarageAge);

            avarageAge = animals
                .OfType<Frog>()
                .Average(an => an.Age);


            Console.WriteLine("Frogs' avarage age is " + (int)avarageAge);

            avarageAge = animals
                .OfType<Kitten>()
                .Average(an => an.Age);


            Console.WriteLine("Kittens' avarage age is " + (int)avarageAge);

            avarageAge = animals
                .OfType<Tomcat>()
                .Average(an => an.Age);


            Console.WriteLine("Tomcats' avarage age is " + (int)avarageAge);

        }
        
    }
}
