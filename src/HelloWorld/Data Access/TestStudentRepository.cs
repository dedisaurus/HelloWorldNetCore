using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorld.Models;
using HelloWorld.Data_Access.Interface;

namespace HelloWorld.Data_Access
{
    public class TestStudentRepository : IStudentRepository
    {
        private List<Student> _studentList;

        public TestStudentRepository()
        {
            _studentList = new List<Student>()
            {
                new Student() { StudentId = 101, Name = "James", Branch = "CSE", Section = "A", Gender = "Male" },
                new Student() { StudentId = 102, Name = "Smith", Branch = "ETC", Section = "B", Gender = "Male" },
                new Student() { StudentId = 103, Name = "David", Branch = "CSE", Section = "A", Gender = "Male" },
                new Student() { StudentId = 104, Name = "Sara", Branch = "CSE", Section = "A", Gender = "Female" },
                new Student() { StudentId = 105, Name = "Pam", Branch = "ETC", Section = "B", Gender = "Female" }
            };
        }

        public Student GetStudentById(int StudentId)
        {
            return this._studentList.FirstOrDefault(e => e.StudentId == StudentId);
        }

        //public Student GetStudentAll()
        //{ saya sudah diskusikan dengan istri pak karena dari belum ketemu yg take care baby nya siapa dan 
        //    //return this._studentList.All();
        // 
        //}
    }
}
