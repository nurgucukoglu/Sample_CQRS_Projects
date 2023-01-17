using Sample_CQRS_Projects.CQRS.Commands.StudentCommands;
using Sample_CQRS_Projects.DAL.Context;
using Sample_CQRS_Projects.DAL.Entities;

namespace Sample_CQRS_Projects.CQRS.Handlers.StudentHandler
{
    public class CreateStudentCommandHandler
    {
        private readonly ProductContext _context;

        public CreateStudentCommandHandler(ProductContext productContext)
        {
            _context = productContext;
        }

        public void Handle(CreateStudentCommand command)
        {
            _context.Students.Add(new Student
            {
                Name = command.Name,
                Surname = command.Surname,
                Age = command.Age,
                City = command.City,
                Status = false

            });
            _context.SaveChanges();

        }
    }
}
