using StudentLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary.DataAccess
{
    public class StudentDataAccess : IStudentDataAccess
    {
        private List<Student> students = new();
        public StudentDataAccess()
        {
            students.Add(new Student { Id = 1, FirstName = "Yomal", LastName = "Alwis" });
            students.Add(new Student { Id = 2, FirstName = "Ayomi", LastName = "Dilsha" });
        }
        public List<Student> GetAllStudents()
        {
            return students;
        }
        public Student GetStudent(int Id)
        {
            return students.FirstOrDefault(s => s.Id == Id);
        }
        public Student AddStudent(string FirstName, string LastName)
        {
            int studentId = students.Max(s => s.Id) + 1;
            students.Add(new Student { Id = studentId, FirstName = FirstName, LastName = LastName });
            return GetStudent(studentId);
        }
    }
}
