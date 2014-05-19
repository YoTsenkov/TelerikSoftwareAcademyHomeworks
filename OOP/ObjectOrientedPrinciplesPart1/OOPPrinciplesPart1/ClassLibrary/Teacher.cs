namespace ClassLibrary
{
    using System.Collections.Generic;
    public class Teacher : People, IComment
    {
        public Teacher()
        {
        }
        public IEnumerable<Discipline> Disciplines { get; private set; }
        public string Comment { get; set; }
    }
}
