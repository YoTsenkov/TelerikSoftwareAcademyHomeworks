namespace ClassLibrary
{
    using System.Collections.Generic;
    public class School
    {
        Class classOne = new Class();
        Class classTwo = new Class("IdentifierTwo", new List<Student>(), new List<Teacher>());
        Class classThree = new Class();
    }
}
