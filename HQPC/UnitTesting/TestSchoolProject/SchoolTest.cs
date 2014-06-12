namespace TestSchoolProject
{
    using System;
    using SchoolProject;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;    

    [TestClass]
    public class SchoolTest
    {
        [TestMethod]
        public void InitializeWithList()
        {
            var school = new School(new List<Student>(new Student[5000]));
            Assert.AreEqual(school.Students.Count, 5000,
                "The school is not init correctly with list of students");
        }

        [TestMethod]
        public void AddSingleStudentToTheSchool()
        {
            var school = new School();
            var student = new Student(15000, "Ivan");
            school.AddStudent(student);
            Assert.AreEqual(school.Students.Count, 1,
                "The student is not added to the school");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException),
            "The student already exists")]
        public void AddStudentWithSameId()
        {
            var school = new School();
            var firstStudent = new Student(15000, "Ivan");
            var secondStudent = new Student(15000, "Manol");
            school.AddStudent(firstStudent);
            school.AddStudent(secondStudent);
        }
    }
}
