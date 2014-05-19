namespace _02.ClassHuman
{
    using System;
    using System.Linq;

    using HumanLibrary;
    public class ClassHuman
    {
        static void Main()
        {
            var listOfStudents = new[]
            {
                new Student("Ivan", "Valkov", 8),
                new Student("Hasinta", "Vatev", 5),
                new Student("Zlatomir", "Spasov", 7),
                new Student("Melina", "Aleksova", 11),
                new Student("Shesa", "Tsenkov", 1),
                new Student("Angel", "Damqnov", 8),
                new Student("Petur", "nachev", 3),
                new Student("Aleksander", "Zlatkov", 10),
                new Student("Vasil", "Ushilov", 2),
                new Student("Martin", "Belev", 3)
            };

            var studentsSortedByGrade = listOfStudents
                .OrderBy(st => st.grade);

            var listOfWorkers = new[]
            {
                new Worker("Kaspichan", "Ivanov", 100, 5),
                new Worker("Kupidon", "Stoimenov", 200, 6),
                new Worker("Aisha", "Kernova", 500, 10),
                new Worker("Martin", "Djerov", 333, 3),
                new Worker("Vladimir", "Putin", 420, 7),
                new Worker("Barack", "Obama", 1273, 12),
                new Worker("Plamen", "Oresharski", 9000, 2),
                new Worker("Kalin", "Kuzmanov", 836, 5),
                new Worker("Aspat", "Bavarov", 435, 6),
                new Worker("Yavor", "Stoilov", 683, 8),
            };

            var workersSortedByMoneyDesc = listOfWorkers
                .OrderByDescending(wk => wk.MoneyPerHour());

            var mergedList = studentsSortedByGrade.Union<Human>(workersSortedByMoneyDesc)
                .OrderBy(human => human.FirstName)
                .ThenBy(human => human.lastName);

            foreach (var human in mergedList)
            {
                Console.WriteLine(human.firstName + " " + human.lastName + "  type-> " + human.GetType());
            }
        }
    }
}
