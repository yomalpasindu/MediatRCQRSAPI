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
    }
}
