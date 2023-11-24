using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWebApp.Models;

namespace MyWebApp.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private static List<Student> _students = new List<Student> {
            new Student {StudentId = 1, Name = "Natalie", Email = "natalie@gmail.com", BirthDate = new DateOnly(2003, 12, 27) },
            new Student {StudentId = 2, Name = "Vania", Email = "vania@gmail.com", BirthDate = new DateOnly(2002, 11, 23) },
            new Student {StudentId = 3, Name = "Jessica", Email = "jessica@gmail.com", BirthDate = new DateOnly(2003, 1, 14) },
            new Student {StudentId = 4, Name = "Vinsa", Email = "vinsa@gmail.com", BirthDate = new DateOnly(2003, 9, 22) },
        };
       public IEnumerable<Student> GetAll(){
        return _students;
       } 

       public Student GetById(int id){
        return _students.First(s => s.StudentId == id);
       }
    }
}