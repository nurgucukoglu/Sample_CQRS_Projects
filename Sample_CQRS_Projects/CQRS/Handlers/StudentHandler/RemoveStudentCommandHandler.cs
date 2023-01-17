using Sample_CQRS_Projects.CQRS.Commands.StudentCommands;
using Sample_CQRS_Projects.DAL.Context;

namespace Sample_CQRS_Projects.CQRS.Handlers.StudentHandler
{
    public class RemoveStudentCommandHandler
    {
        private readonly ProductContext _context;

        public RemoveStudentCommandHandler(ProductContext context)
        {
            _context = context;
        }
        public void Handle(RemoveStudentCommand command)
        {
            var values = _context.Students.Find(command.id);
            _context.Students.Remove(values);
            _context.SaveChanges();
        }
    }
}
