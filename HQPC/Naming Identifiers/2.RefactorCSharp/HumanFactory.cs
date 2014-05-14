namespace _2.RefactorCSharp
{
    using System;
    using System.Linq;

    public class HumanFactory
    {
        public void CreateHuman(int age)
        {
            Human human = new Human();
            human.Age = age;
            if (age % 2 == 0)
            {
                human.Name = "Ivan";
                human.Gender = Gender.Male;
            }
            else
            {
                human.Name = "Miriqna";
                human.Gender = Gender.Female;
            }
        }
    }
}
