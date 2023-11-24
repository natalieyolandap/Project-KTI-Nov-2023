using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWebApp.Models;

namespace MyWebApp.Repositories
{
    public interface IStudentRepository{
        IEnumerable<Student> GetAll();
        Student GetById(int id);
    }
}