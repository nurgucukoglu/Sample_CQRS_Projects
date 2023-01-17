using MediatR;

namespace Sample_CQRS_Projects.CQRS.Commands.UniversityCommands
{
    public class RemoveUniversityCommand: IRequest
    {
        public int id { get; set; }

        public RemoveUniversityCommand(int id)
        {
            this.id = id;
        }
    }
}
