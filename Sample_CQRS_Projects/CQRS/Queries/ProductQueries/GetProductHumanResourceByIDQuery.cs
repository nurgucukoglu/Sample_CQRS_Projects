namespace Sample_CQRS_Projects.CQRS.Queries.ProductQueries
{
    public class GetProductHumanResourceByIDQuery
    {
        public GetProductHumanResourceByIDQuery(int id)
        {
            Id = id;//controller içinde kullanabilmek için consturctor içinde yazılır.
        }

        public int Id { get; set; }
    }
}
