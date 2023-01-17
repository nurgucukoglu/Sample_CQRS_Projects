using Sample_CQRS_Projects.CQRS.Queries.StudentQueries;
using Sample_CQRS_Projects.CQRS.Results.StudentResult;
using Sample_CQRS_Projects.DAL.Context;

namespace Sample_CQRS_Projects.CQRS.Handlers.StudentHandler
{
    public class GetStudentByIDQueryHandler
    {
        private readonly ProductContext _context;

        public GetStudentByIDQueryHandler(ProductContext context)
        {
            _context = context;
        }
        public GetStudentByIDQueryResult Handle(GetStudentByIDQuery query)
        {
            var values = _context.Students.Find(query.id);
            return new GetStudentByIDQueryResult
            {
                Age = values.Age,
                City = values.City,
                Name = values.Name,
                Surname = values.Surname,
                StudentID = values.StudentID
            };
        }
    }
}
