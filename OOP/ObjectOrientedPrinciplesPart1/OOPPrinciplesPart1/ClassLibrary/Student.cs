namespace ClassLibrary
{
    using System;
    public class Student : People, IComment
    {
        
        public int ClassNumber { get; private set; }

        public Student()
        {
        }
        public string Comment { get; set; }
    }
}
