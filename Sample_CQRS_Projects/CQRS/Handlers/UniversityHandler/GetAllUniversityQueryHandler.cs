using MediatR;
using Microsoft.EntityFrameworkCore;
using Sample_CQRS_Projects.CQRS.Queries.UniversityQueries;
using Sample_CQRS_Projects.CQRS.Results.UniversityResult;
using Sample_CQRS_Projects.DAL.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Sample_CQRS_Projects.CQRS.Handlers.UniversityHandler
{
    public class GetAllUniversityQueryHandler: IRequestHandler<GetAllUniversityQuery, List<GetUniversityByIDQueryResult>> //istek ve yanıt parametresi bekler.
        //metodları alıp kullanabilmek için içine parametreler için query'i ve dönecek sonuçları tutmak için Result'ı veririrm.
    {
        private readonly ProductContext _context;

        public GetAllUniversityQueryHandler(ProductContext context)
        {
            _context = context;
        }

        public async Task<List<GetUniversityByIDQueryResult>> Handle(GetAllUniversityQuery request, CancellationToken cancellationToken)
        {
            return await _context.Universities.Select(x =>
            new GetUniversityByIDQueryResult
            {
                UniversityID = x.UniversityID,
                City = x.City,
                Name = x.Name

            }).AsNoTracking().ToListAsync();
        }
    }
}
