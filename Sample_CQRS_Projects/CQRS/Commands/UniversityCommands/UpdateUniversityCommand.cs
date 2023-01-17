using MediatR;

namespace Sample_CQRS_Projects.CQRS.Commands.UniversityCommands
{
    public class UpdateUniversityCommand: IRequest
    {
        public int UniversityID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Population { get; set; }
    }
}
