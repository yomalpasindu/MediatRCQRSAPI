using MediatR;
using StudentLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary.Queries
{
    public record StudentQuery(int StudentId):IRequest<Student>
    {
    }
}
