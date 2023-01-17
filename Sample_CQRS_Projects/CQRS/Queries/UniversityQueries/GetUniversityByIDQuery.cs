using MediatR;
using Sample_CQRS_Projects.CQRS.Results.UniversityResult;

namespace Sample_CQRS_Projects.CQRS.Queries.UniversityQueries
{
    public class GetUniversityByIDQuery : IRequest<GetUniversityByIDQueryResult> //bu kez request sonucu bir tane bilgi geleceği list yok
                               
    {
        public GetUniversityByIDQuery(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
