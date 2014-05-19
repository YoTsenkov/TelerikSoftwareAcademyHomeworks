namespace ClassLibrary
{
    public class Discipline : IComment
    {
        public Discipline()
        {
        }
        public string Name { get; set; }
        public int NumberOfLectures { get; set; }
        public int NumbersOfExercises { get; set; }
        public string Comment { get; set; }
    }
}
