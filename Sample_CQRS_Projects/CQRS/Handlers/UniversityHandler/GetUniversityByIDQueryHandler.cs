using MediatR;
using Sample_CQRS_Projects.CQRS.Queries.UniversityQueries;
using Sample_CQRS_Projects.CQRS.Results.UniversityResult;
using Sample_CQRS_Projects.DAL.Context;
using System.Threading;
using System.Threading.Tasks;

namespace Sample_CQRS_Projects.CQRS.Handlers.UniversityHandler
{
    public class GetUniversityByIDQueryHandler : IRequestHandler<GetUniversityByIDQuery, GetUniversityByIDQueryResult>
    {
        private readonly ProductContext _context;

        public GetUniversityByIDQueryHandler(ProductContext context)
        {
            _context = context;
        }

        public async Task<GetUniversityByIDQueryResult> Handle(GetUniversityByIDQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Universities.FindAsync(request.id);
            //id'ye göre listeleme için query içindeki id'ye ulaşmalı
            //bu id'yede mediatr'den hazır otomatik gelen handle metodu içindeki
            //request parametresinden ulaşılır.
            return new GetUniversityByIDQueryResult
            {
                UniversityID = values.UniversityID,
                City = values.City,
                Name = values.Name,
                Population = values.Population
            };
        }
    }
}
