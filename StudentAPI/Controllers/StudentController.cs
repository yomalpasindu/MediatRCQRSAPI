using MediatR;
using Microsoft.AspNetCore.Mvc;
using StudentLibrary.Models;
using StudentLibrary.Queries;

namespace StudentAPI.Controllers
{
    public class StudentController : Controller
    {
        private readonly IMediator _mediator;
        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("GetStudents")]
        public async Task<List<Student>> GetAllStudents()
        {
            return await _mediator.Send(new StudentListQuery());
        }
        [HttpGet("GetStudent")]
        public async Task<Student> GetStudent(int Id)
        {
            return await _mediator.Send(new StudentQuery(Id));
        }
        [HttpPost("AddStudent")]
        public async Task<Student> InsertStudent(string FirstName,string LastName)
        {
            return await _mediator.Send(new StudentInsertQuery(FirstName,LastName));
        }
    }
}
