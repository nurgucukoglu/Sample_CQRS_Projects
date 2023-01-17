using MediatR;
using Sample_CQRS_Projects.CQRS.Results.UniversityResult;
using System.Collections.Generic;

namespace Sample_CQRS_Projects.CQRS.Queries.UniversityQueries
{
    public class GetAllUniversityQuery: IRequest<List<GetUniversityByIDQueryResult>>
    {
    }
}
