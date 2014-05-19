namespace ClassLibrary
{
    using System.Collections.Generic;
    public class Class : IComment
    {
        public Class()
        {
        }
        public Class(string Identifier, IEnumerable<Student> students, IEnumerable<Teacher> teachers)
        {
            this.ClassIdentifier = Identifier;
            this.Students = students;
            this.Teachers = teachers;
        }
        public IEnumerable<Student> Students { get; private set; }
        public IEnumerable<Teacher> Teachers { get; private set; }
        public string ClassIdentifier { get; private set; }
        public string Comment { get; set; }
    }
}
