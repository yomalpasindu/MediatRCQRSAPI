using MediatR;
using StudentLibrary.DataAccess;
using StudentLibrary.Models;
using StudentLibrary.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary.Handlers
{
    public class StudentHandler : IRequestHandler<StudentQuery, Student>
    {
        private readonly IStudentDataAccess _studentDataAccess;
        public StudentHandler(IStudentDataAccess studentDataAccess)
        {
            _studentDataAccess = studentDataAccess;
        }
        public async Task<Student> Handle(StudentQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_studentDataAccess.GetStudent(request.StudentId));
        }
    }
}
