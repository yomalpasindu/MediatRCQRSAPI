using StudentLibrary.Models;

namespace StudentLibrary.DataAccess
{
    public interface IStudentDataAccess
    {
        Student AddStudent(string FirstName, string LastName);
        List<Student> GetAllStudents();
        Student GetStudent(int Id);
    }
}