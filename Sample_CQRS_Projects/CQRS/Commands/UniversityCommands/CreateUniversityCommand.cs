using MediatR;

namespace Sample_CQRS_Projects.CQRS.Commands.UniversityCommands
{
    public class CreateUniversityCommand :IRequest
    {
        //güncellenecek verileri tutan sınıf request karşılığı mediatrde
        public int UniversityID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Population { get; set; }
        public string FacultyCount { get; set; }
    }
}
