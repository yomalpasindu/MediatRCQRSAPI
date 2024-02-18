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
    public class StudentInsertHandler : IRequestHandler<StudentInsertQuery, Student>
    {
        private readonly IStudentDataAccess _studentDataAccess;
        public StudentInsertHandler(IStudentDataAccess studentDataAccess)
        {
            _studentDataAccess = studentDataAccess;
        }
        public async Task<Student> Handle(StudentInsertQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_studentDataAccess.AddStudent(request.FirstName, request.LastName));
        }
    }
}
