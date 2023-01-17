using MediatR;
using Sample_CQRS_Projects.CQRS.Commands.StudentCommands;
using Sample_CQRS_Projects.CQRS.Commands.UniversityCommands;
using Sample_CQRS_Projects.DAL.Context;
using System.Threading;
using System.Threading.Tasks;

namespace Sample_CQRS_Projects.CQRS.Handlers.UniversityHandler
{
    public class RemoveUniversityCommandHandler: IRequestHandler<RemoveUniversityCommand>
    {
        //SİLME
        private readonly ProductContext _context;

        public RemoveUniversityCommandHandler(ProductContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(RemoveUniversityCommand request, CancellationToken cancellationToken)
        {
            var values = _context.Universities.Find(request.id);//silinecek verileri bul
            _context.Universities.Remove(values);
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
