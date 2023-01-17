using Sample_CQRS_Projects.CQRS.Commands.StudentCommands;
using Sample_CQRS_Projects.DAL.Context;

namespace Sample_CQRS_Projects.CQRS.Handlers.StudentHandler
{
    public class UpdateStudentCommandHandler
    {
        private readonly ProductContext _context;

        public UpdateStudentCommandHandler(ProductContext context)
        {
            _context = context;
        }
        public void Handle(UpdateStudentCommand command)
        {
            var values = _context.Students.Find(command.StudentID);
            values.City = command.City;
            values.Name = command.Name;
            values.Surname = command.Surname;
            values.Age = command.Age;
            _context.SaveChanges();
        }
    }
}
