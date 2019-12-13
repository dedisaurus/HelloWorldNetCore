using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorld.Models;

namespace HelloWorld.Data_Access.Interface
{
    public interface IStudentRepository
    {
        Student GetStudentById(int StudentId);
    }
}
