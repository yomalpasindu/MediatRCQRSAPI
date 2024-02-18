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
    public class StudentListHandler : IRequestHandler<StudentListQuery, List<Student>>
    {
        private readonly IStudentDataAccess _studentDataAccess;
        public StudentListHandler(IStudentDataAccess studentDataAccess)
        {
            _studentDataAccess=studentDataAccess;
        }
        public Task<List<Student>> Handle(StudentListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_studentDataAccess.GetAllStudents());
        }
    }
}
