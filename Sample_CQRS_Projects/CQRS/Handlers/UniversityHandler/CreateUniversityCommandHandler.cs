using MediatR;
using Sample_CQRS_Projects.CQRS.Commands.UniversityCommands;
using Sample_CQRS_Projects.DAL.Context;
using Sample_CQRS_Projects.DAL.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Sample_CQRS_Projects.CQRS.Handlers.UniversityHandler
{
    public class CreateUniversityCommandHandler: IRequestHandler<CreateUniversityCommand>
    {
        //tek parametre isteyen overload kullandık. isteğin yanıtlanacağı kısım

        //listeleme işleminde RequestHandler da hem request hem response kullanılıyordu. Güncelleme eklemede bu metodun farklı bir overload'u olacak /bu defa buradan parametre olarak güncellenecek yeni verilerin karşılığı olan CreateUniversityCommand sınıfını veriyoruz.
        //Sadece isteği yanıtlayacağım kısım yani IRequesti kalıttığım kısımı veriyorum

        private readonly ProductContext _context;

        public CreateUniversityCommandHandler(ProductContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateUniversityCommand request, CancellationToken cancellationToken)
        {
            _context.Universities.Add(new University
            {
                City = request.City,
                Name = request.Name,
                Population = request.Population,
                FacultyCount = request.FacultyCount

            });
            await _context.SaveChangesAsync();
            return Unit.Value;    //
        }
    }
}
