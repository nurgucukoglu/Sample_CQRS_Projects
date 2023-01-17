using Microsoft.EntityFrameworkCore;
using Sample_CQRS_Projects.CQRS.Results.StudentResult;
using Sample_CQRS_Projects.DAL.Context;
using System.Collections.Generic;
using System.Linq;

namespace Sample_CQRS_Projects.CQRS.Handlers.StudentHandler
{
    public class GetAllStudentQueryHandler
    {
        private readonly ProductContext _context;

        public GetAllStudentQueryHandler(ProductContext context)
        {
            _context = context;
        }
        public List<GetAllStudentQueryResult> Handle()
        {
            var values = _context.Students.Select(x =>
            new GetAllStudentQueryResult
            {
                City = x.City,
                Department = x.Department,
                Name = x.Name,
                StudentID = x.StudentID,
                Surname = x.Surname
            }).AsNoTracking().ToList();
            return values;
        }
    }
}
